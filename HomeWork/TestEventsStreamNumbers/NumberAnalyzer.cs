using System;

namespace TestEventsNumbersStream
{
    class NumberAnalyzer
    {
        private int _previousNumber;
        private int _percentageThreshold;
        private bool isSetFirstMumber;
        private double percent;
        public NumberAnalyzer(int percentageThreshold)
        {
            _percentageThreshold = percentageThreshold;
        }

        public event EventHandler<double> BigDifference;

        public void Analyz(int number)
        {
            if (isSetFirstMumber)
            {
                if (_previousNumber != 0)
                {
                    percent = ((double)(number - _previousNumber) / (double)_previousNumber) * 100;
                    percent = Math.Round(percent, 2);
                    if (Math.Abs(percent) > _percentageThreshold)
                        OnBigDifference(percent);
                    _previousNumber = number;
                }
            }
            else
            {
                _previousNumber = number;
                isSetFirstMumber = true;
            }
            
        }

        private void OnBigDifference(double percent)
        {
            if (BigDifference != null)
                BigDifference (this, percent);
        }
    }
}
