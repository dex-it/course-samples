using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace Stage1Chapter18
{
    public class ReflectionTest
    {
        public List<string> GetProperties (object target)
        {
            List<string> _listProperties = new List<string>();

            if (target == null)
            {
                throw new ArgumentNullException(nameof(target));
            }
            var type = target.GetType();
            var props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);

            var values = props.Select(x => $"({x.PropertyType}) {x.Name} : {x.GetValue(target)}");

            foreach (var val in values)
            {
                _listProperties.Add(val);
            }

            return _listProperties;
        }


        public List<string> GetConstructors(object target)
        {
            List<string> _listConstructors = new List<string>();

            if (target == null)
            {
                throw new ArgumentNullException(nameof(target));
            }
            var type = target.GetType();
            foreach (ConstructorInfo constructorInfo in type.GetConstructors())
            {
                string st = type.Name + " (";
                ParameterInfo[] parameters = constructorInfo.GetParameters();
                for (int i = 0; i < parameters.Length; i++)
                {
                    st += parameters[i].ParameterType.Name + " " + parameters[i].Name;
                    if (i + 1 < parameters.Length)
                    {
                        st += ", ";
                    }
                }
                st += ")";
                _listConstructors.Add(st);
            }

            return _listConstructors;
        }

    }
}
