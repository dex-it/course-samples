using System;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using NUnit.Framework;

namespace Stage1
{
    [TestFixture]
    public class ReflectionTest
    {
        [Test]
        public void TestCreateInstance()
        {
         var car =CreateInstance("Stage1.Car");
         Assert.IsTrue(car is Car);
        }
        

        private object CreateInstance(string typeName)
        {
            var type = Type.GetType(typeName);
            if (type == null)
            {
                 throw new ArgumentNullException("typeName");
            }
            return Activator.CreateInstance(type);
        }
    }
    
}