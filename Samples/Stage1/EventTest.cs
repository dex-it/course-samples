using System;
using NUnit.Framework;

namespace Stage1
{
    [TestFixture]
    public class EventTest
    {
        [Test]
        public void Test1()
        {
            var isThresholdReached = false;
            var counter = new Counter(5);
            
            counter.ThresholdReached += (sender, args) =>
            {
                Console.WriteLine("Threshold reached");
                isThresholdReached = true;
            };

            for (int i = 0; i < 5; i++)
            {
                counter.Increment();
            }

            Assert.IsTrue(isThresholdReached);
        }


        private class Counter
        {
            private readonly int _threshold;
            private int _count = 0;

            public event EventHandler ThresholdReached;

            public Counter(int threshold)
            {
                _threshold = threshold;
            }

            protected virtual void OnThresholdReached(EventArgs e)
            {
                EventHandler handler = ThresholdReached;
                handler?.Invoke(this, e);
            }

            public void Increment()
            {
                _count++;

                if (_count >= _threshold)
                {
                    ThresholdReached?.Invoke(this, EventArgs.Empty);
                }
            }
        }
    }
}