using System;
using System.Threading;


namespace TestEventsNumbersStream
{
    class NumbersStream: IDisposable
    {

        private int _currentNumber;
        private Thread _thread;
        private bool isThreadStart;
        public void Dispose()
        {
            if (CurrentNumberChanged != null)
                foreach (EventHandler<int> ev in CurrentNumberChanged.GetInvocationList())
                {
                    CurrentNumberChanged -= ev;
                }
        }

        public event EventHandler<int> CurrentNumberChanged;
        public int CurrentNumber
        {
            get
            {
                return _currentNumber;
            }
        }
        public void StartStream()
        {
            _thread = new Thread(MakeNewNumber);
            isThreadStart = true;
            _thread.Start();
        }
        public void StopStream()
        {
            if (_thread != null)
                isThreadStart = false;
        }

        private void MakeNewNumber()
        {
            Random rnd = new Random();
            while (isThreadStart)
            {
                Thread.Sleep(rnd.Next(500, 3000));
                _currentNumber = rnd.Next(1, 100);
                OnCurrentNumberChanged(_currentNumber);
            }
        }

        private void OnCurrentNumberChanged(int currentNumber)
        {
            if (CurrentNumberChanged != null)
            {
                CurrentNumberChanged(this, currentNumber);
            }
        }


    }
}
