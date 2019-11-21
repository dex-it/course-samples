using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Stage1.MyThreadsTest
{
    public class MyJobExecutor : IJobExecutor
    {
        public MyJobExecutor()
        {
            _actions = new BlockingCollection<Action>();
        }

        private BlockingCollection<Action> _actions;

        private volatile bool _shouldStop;
        private volatile bool _jobIsStarted;


        public int Amount => _actions.Count;

        public void Start(int maxConcurrent)
        {
            if (maxConcurrent <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(maxConcurrent));
            }

            if (_jobIsStarted) return;
               
            _jobIsStarted = true;

            
            var tasks = new List<Task>();
            using var semaphoreSlim = new SemaphoreSlim(Environment.ProcessorCount,maxConcurrent);
            

            while (!_shouldStop)
            {
                if (_actions.Count < 1) return;

                semaphoreSlim.Wait();
                tasks.Add(Task.Run(() =>
                {
                    try
                    {
                        _actions.Take().Invoke();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        semaphoreSlim.Release();
                    }
                }));
            }

            Task.WaitAll(tasks.ToArray());
            _jobIsStarted = false;
        }
    
        public void Stop()
        {
            _shouldStop = true;
        }

        public void Add(Action action)
        {
            if (action == null) throw new ArgumentNullException(nameof(action));

            _actions.Add(action);
        }

        public void Clear()
        {
            _actions = new BlockingCollection<Action>();
        }


        /* 
          //Parallel.ForEach
        public void Start(int maxConcurrent)
         {

             var source = new CancellationTokenSource();
             var cancellationToken = source.Token;
             var options = new ParallelOptions
             {
                 MaxDegreeOfParallelism = 10,
                 CancellationToken = cancellationToken
             };

             try
             {
                 Parallel.ForEach(_actions,
                     options,
                     action =>action.Invoke());
             }
             catch (OperationCanceledException e)
             {
                 Console.WriteLine(e.Message);
             }
             catch (Exception ex)
             {
                 Console.WriteLine(ex.Message);
             }
             finally
             {
                 source.Dispose();
             }
         }
         */

        /*
         //Parallel.Invoke
   public void Start( int maxConcurrent)
    {
        var cancellationToken = new CancellationToken();

        var parallelOptions = new ParallelOptions
        {
            MaxDegreeOfParallelism = maxConcurrent,
            CancellationToken = cancellationToken
        };

        Parallel.Invoke(parallelOptions, _actions.ToArray());
        _jobIsStarted = false;
    }
    */
    }

}