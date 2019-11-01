using System.Collections.Generic;
using NUnit.Framework;

namespace Stage1
{
    public class ListTests
    {
        [Test]
        public void Test()
        {
            List<int> numbers = new List<int>() { 4, 3, 2, 1 };
            numbers.Add(5); // добавление элемента
            numbers.AddRange(new int[] { 6, 7, 8 }); //добавляем несколько элементов
            numbers.Insert(0, 666); // вставляем на первое место в списке число 666
            numbers.RemoveAt(1); // удаляем второй элемент
 
            numbers.Sort(); // сортируем элементы
            
            Assert.AreEqual(numbers.Count, 8);
            Assert.AreEqual(numbers[0], 1);
        }
    }
}