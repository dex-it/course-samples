using System;
using System.CodeDom;
using System.Linq;
using System.Reflection;

namespace Stage1.ReflectionTest
{
    public static class DeepCloneObjectExstentions
    {
        public static object DeepClone(this object original)
        {
            if (original == null)
            {
                return null;
            }

            Type type = original.GetType();
            
            var memberwiseClone = type.GetMethod("MemberwiseClone", BindingFlags.NonPublic | BindingFlags.Instance);

            if (memberwiseClone == null)
            {
                return null;
            }

            
            var copy = memberwiseClone.Invoke(original, null);

            var fields = copy.GetType().GetRuntimeFields()
                .Where(f => !f.FieldType.IsValueType)
                .Where(f => f.FieldType != typeof(string));


            foreach (var field in fields)
            {
                var clonedValue = field.GetValue(original);
                field.SetValue(copy, DeepClone(clonedValue));
            }

            return copy;
        }
    }
}