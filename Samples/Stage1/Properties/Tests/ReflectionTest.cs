using System;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

namespace Stage1
{
    [TestFixture]
    public class ReflectionTest
    {
        [Test]
        public void Test1()
        {
            var user = new TestUser()
            {
                Id = 1,
                Name = "Max",
                Birthday = DateTime.Now.AddYears(-25),
                Salary = 1000
            };

            Console.WriteLine(CreateObjectPropertiesString(user));
        }

        private class TestUser
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Salary { get; set; }
            public DateTime Birthday { get; set; }
        }

        /// <summary>
        /// Принимает объект любого типа и формирует строку из значение публичных свойств
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        private string CreateObjectPropertiesString(object target)
        {
            if (target == null) throw new ArgumentNullException(nameof(target));

            var type = target.GetType(); // получаем тип
            var props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance); // получаем все публичные свойства, не статические
            var values = props.Select(x => $"{x.Name} : {x.GetValue(target)}"); // перебираем все свойства и описываем формат сохранения в строку

            return string.Join(", ", values); // формируем строку
        }
    }
}