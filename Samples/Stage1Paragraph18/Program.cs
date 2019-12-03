using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stage1Paragraph9;
using System.Reflection;

namespace Stage1Paragraph18
{
    class Program
    {
        static void Main(string[] args)
        {
            // получаем строку наименования класса
            Type rectangleType = typeof(Rectangle);
            string assemblyQualifiedName = rectangleType.AssemblyQualifiedName;

            // Создаем экзмемпляр экземпляр класса Type, а затем экземпляр класса Rectangle
            Type recType = Type.GetType(assemblyQualifiedName);
            ConstructorInfo ctor = recType.GetConstructor(new Type[] { typeof(int), typeof(int) });
            Rectangle rectangle = (Rectangle)ctor.Invoke(new object[] { 5, 10 });

            // выводим информацию о созданном экземпляре rectangle
            rectangle.PrintInfo();

            // работа с членами 
            var propertyInfo = recType.GetProperty("Length");
            propertyInfo.SetValue(rectangle, 100);

            rectangle.PrintInfo();

            recType.GetMethod("IncreaseLength").Invoke(rectangle, new object[] { 50 });

            rectangle.PrintInfo();

            rectangle.PrintPrivateProperty();

            var privateProperty = recType.GetProperty("privateProperty",
                BindingFlags.NonPublic | BindingFlags.Instance);
            privateProperty.SetValue(rectangle, 2);

            rectangle.PrintPrivateProperty();

            Console.ReadKey();
        }
    }
}