using System;
using System.Reflection;

namespace Stage1DeepClone
{
    public class Cloneable
    {
        public object DeepCopyMine(object obj)
        {
            if (obj == null) return null;

            object newCopy = Activator.CreateInstance(obj.GetType(), true);
          
            foreach (var property in newCopy.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
            {
                //Console.WriteLine($"{property.Name} - {property.GetValue(obj)} - {property.PropertyType.IsValueType}");

                if (!property.PropertyType.IsValueType && property.PropertyType != typeof(string))
                {
                    //Console.WriteLine($"{property.Name} - {property.GetValue(obj)}");
                    var propertyCopy = DeepCopyMine(property.GetValue(obj));
                    property.SetValue(newCopy, propertyCopy);
                }
                else
                {
                    //Console.WriteLine($"{property.Name} - {property.GetValue(obj)}"); 
                    property.SetValue(newCopy, property.GetValue(obj));
                }
            }
            return newCopy;
        }
    }
}
