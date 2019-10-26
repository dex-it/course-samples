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

        }

      
        private class Car
        {
            public string Name { get; set; }
            public int Price { get; set; }
            public DateTime ProductionDate { get; set; }
            public bool IsNew { get; set; }

        }

            
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