using System;
using System.Reflection;
using NUnit.Framework;

namespace Stage1
{
    #region tasks

     /*
        Научиться создавать класс по строковому наименованию, берем из прошлых занятий
        например object Create("Triangle")
        
        Вызвать метод с параметрами
        
        Попробуйте получить закрытые свойства класса, считать из них значения
        
        Исследуйте
        GetFields(BindingFlags)
        GetProperties(BindingFlags)
        GetMethods(BindingFlags)
        GetConstructors(BindingFlags)
        */

#endregion
    public class MyReflectionTest
    {
        
        [Test]
        public void CreateInstanceTest()
        {
         var test = CreateInstance("Stage1.MyReflectionTest");
         Assert.IsTrue(test is MyReflectionTest);

         var car = CreateInstance("Stage1.Car") as Car ;

         car?.Start();
        
        }


        [Test]
        public void GetPrivatePropertyTest()
        {
            object obj = new Car();
            var type = obj.GetType();
            
            var privateProps = type.GetProperties(BindingFlags.NonPublic | BindingFlags.Static);
           
            foreach (var propertyInfo in privateProps)
            {
                Console.WriteLine(propertyInfo.GetValue(null));
            }
        }
        

        [Test]
        public void GetFieldsTest()
        {
            object obj = new Car();
            var type = obj.GetType();
            
            var fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
           
            foreach (var fieldInfo in fields)
            {
                Console.WriteLine(fieldInfo.Name);
            }
        }
        
        
        [Test]
        public void GetMethodsTest()
        {
            object obj = new Car();
            var type = obj.GetType();
            
            var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance);
           
            foreach (var methodInfo in methods)
            {
                Console.WriteLine(methodInfo.Name);
            }
        }
        
        
        [Test]
        public void GetConstructorsTest()
        {
            object obj = new Car();
            var type = obj.GetType();
            
            var constructors = type.GetConstructors(BindingFlags.Public | BindingFlags.Instance);
           
            foreach (var constructor in constructors)
            {
                Console.WriteLine(constructor);
            }
        }

        
        private  object CreateInstance(string typeName)
        {
            var type = Type.GetType(typeName);
            if (type == null)
            {
                 throw new ArgumentNullException("typeName");
            }
            return Activator.CreateInstance(type);
        }

    }
    public  class Car
    {
        public Car()
        {
            
        }
        
        public Car(string name, string number)
        {
            Name = name;
            Number = number;
        }
        
        public string Name { get; set; }
       
        public string Number { get; set; }
       
        private static string testPrivateProp { get; set; }="testValue";
        //private  string TestClosedProp { get; set; }="testValue";

        
        public void Start()
        {
            
        }
        
    }
    
    
}