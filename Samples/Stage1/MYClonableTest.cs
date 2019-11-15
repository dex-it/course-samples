using System;
using NUnit.Framework;

namespace Stage1
{
    public class MyClonableTest
    {
       private class Car : ICloneable
       {
           public int Id  { get; set; }
           public string Name  { get; set; }
           public string Number  { get; set; }

           public Owner Owner { get; set; }
           

           public object Clone()
           {
               return this.MemberwiseClone();
           }

           public Car DeepClone()
           {
               return new Car
               {
                   Name = this.Name,
                   Id = this.Id,
                   Number = this.Number,
                   Owner = new Owner("ClonedOwner")
               };
           }
       }
       
       private class Owner
       {
           public string Name { get; set; }

           public Owner(string name)
           {
               Name = name;
           }

           public Owner()
           {
               
           }
       }

       [Test]
       public void ClonableTest()
       {
           var car1 = new Car
           {
                Id = 1,
                Name = "1",
                Number = "1",
                Owner = new Owner("Owner1")
           };

           var car2 = car1;

           Assert.AreEqual(car1.Owner, car2.Owner);
               
           
           car2 = car1.Clone() as Car;

           Assert.AreEqual(car1.Owner, car2.Owner);

           
           car2 = car1.DeepClone();

           Assert.AreNotEqual(car1.Owner, car2.Owner);
           

       }
       
       
       
    }
}