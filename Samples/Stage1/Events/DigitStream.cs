using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Stage1.Events
{
//    реализовать класс анализирующий поток чисел и 
//    если число отличается более чем x процентов выбрасывает событие
    public class DigitStream
    {
        public event EventHandler ItemMore ;
        
        private Queue<int> digits;
        public int Percent { get; set; } = 30;

        public DigitStream()
        {
            digits = new Queue<int>();
        }

        public void Add(int item)
        {
            if (digits.Count==0)
            {
                digits.Enqueue(item);
                return;
            }
            
            if ( item/ 100 * Percent > digits.Average())
            {
                ItemMore?.Invoke(this,EventArgs.Empty);
            }
            
            digits.Enqueue(item);

        }

        [Test]
        public void Test()
        {
            var stream = new DigitStream();

            void PrintMessage(object sender, EventArgs e)
            {
                Console.WriteLine("Item more");
            }

            stream.ItemMore += PrintMessage;
            
            stream.Add(3);
            stream.Add(100);

            stream.ItemMore -= PrintMessage;
        }
        
    }
}    