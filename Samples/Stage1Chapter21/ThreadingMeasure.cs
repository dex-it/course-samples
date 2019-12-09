using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Stage1Chapter21
{
    public class ThreadingMeasure
    {
        public long sumFirstHalf = 0;
        public long sumSecondHalf = 0;

        public long AvgWithThreads(long startValue, long quantityNumbers)
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

            return (sumFirstHalf + sumSecondHalf) / quantityNumbers;
        }

        public long AvgWithotThreads(long startValue, long quantityNumbers)
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

            return (sumFirstHalf + sumSecondHalf) / quantityNumbers;

        }

        public void Sum(object obj)
        {
            Storage storage = (Storage)obj;

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
