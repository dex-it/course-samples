using System;
using NUnit.Framework;

namespace Stage1
{
    public class MyClonableTest
    {
       public class Car : ICloneable
       {
           public int Id  { get; set; }
           public string Name  { get; set; }
           public string Number  { get; set; }

           public object Clone()
           {
//               return new Car
//               {
//                   Name = this.Name,
//                   Id = this.Id,
//                   Number = this.Number
//               };

               return this.MemberwiseClone();
           }
       }
       

       [Test]
       public void ClonableTest()
       {
           var car1 = new Car
           {
                Id = 1,
                Name = "1",
                Number = "1"
           };

           var car2 = car1;
           car2.Id = 1;
           Assert.AreEqual(car1.Id, car2.Id);

           car2 = car1.Clone() as Car;
           car2.Id = 2;
           Assert.AreNotEqual(car1.Id, car2.Id);
           
       }
    }
}