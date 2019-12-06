using System;
using System.Reflection;

namespace Stage1
{
    public class Copier
    {
        public static object Copy(object obj)
        {
            var type = typeof(object);
            var memberwiseClone = type.GetMethod("MemberwiseClone", BindingFlags.Instance | BindingFlags.NonPublic);

            var copy = memberwiseClone.Invoke(obj, new object[0]);
          
            var fields= copy.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
           
            foreach (var field in fields)
            {
                if (!field.FieldType.IsPrimitive && field.FieldType != typeof(string))
                {
                    var fieldCopy = Copy(field.GetValue(copy));
                    field.SetValue(copy, fieldCopy);
                }
            }
            return copy;
        }
    }
}