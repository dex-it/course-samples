using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Stage1Chapter21
{
    public class ThreadingMeasure
    {
        private double sumFirstHalf = 0;
        private double sumSecondHalf = 0;


        public double GetSumFirstHalf()
        {
            return sumFirstHalf;
        }

        public double GetSumSecondHalf()
        {
            return sumSecondHalf;
        }

        public double AvgWithoutThreads(long startValue, long quantityNumbers)
        {
            long middleRange = quantityNumbers / 2;

            Storage storage1 = new Storage
            {
                startValue = startValue,
                quantityNumbers = middleRange,
                indexSum = 1
            };

            Sum(storage1);

            Storage storage2 = new Storage
            {
                startValue = startValue + middleRange,
                quantityNumbers = quantityNumbers - middleRange,
                indexSum = 2
            };

            Sum(storage2);

            return (GetSumFirstHalf() + GetSumSecondHalf()) / quantityNumbers;

        }


        public double AvgWithThreads(long startValue, long quantityNumbers)
        {

            long middleRange = quantityNumbers / 2;

            Storage storage1 = new Storage
            {
                startValue = startValue,
                quantityNumbers = middleRange,
                indexSum = 1
            };

            Thread m = new Thread(new ParameterizedThreadStart(Sum));
            m.Start(storage1);

            Storage storage2 = new Storage
            {
                startValue = startValue + middleRange,
                quantityNumbers = quantityNumbers - middleRange,
                indexSum = 2
            };

            Sum(storage2);
            
            while (m.IsAlive)
            {
                Thread.Sleep(1);
            }
            
            return (sumFirstHalf + sumSecondHalf) / quantityNumbers;
        }

        public double AvgParallelInvoke(long startValue, long quantityNumbers)
        {
            sumSecondHalf = 0;

            Storage storage1 = new Storage
            {
                startValue = startValue,
                quantityNumbers = quantityNumbers,
                indexSum = 1
            };

            Parallel.Invoke(() => Sum(storage1));
            return (sumFirstHalf + sumSecondHalf) / quantityNumbers;

        }

        public double AvgPlinq(long startValue, long quantityNumbers)
        {
            double val = 0;
            return val = ((ParallelQuery<int>)ParallelEnumerable.Range((int)startValue, (int)quantityNumbers))
                                        .WithExecutionMode(ParallelExecutionMode.ForceParallelism)
                                        .Select(i => i)
                                        .Average();
        }

        public void Sum(object obj)
        {

            Storage storage = (Storage)obj;

            if (storage.indexSum == 1)
            {
                sumFirstHalf = 0;
            }
            else
            {
                sumSecondHalf = 0;
            }

            long summ = 0;
            for (long i = storage.startValue; i <= (storage.startValue + storage.quantityNumbers - 1); i++)
            {
                summ += i;
            }

            if (storage.indexSum == 1)
            {
                sumFirstHalf = summ;
            }
            else
            {
                sumSecondHalf = summ;
            }
        }

        private class Storage
        {
            public long startValue;
            public long quantityNumbers;
            public long indexSum;
        }
    }
}
