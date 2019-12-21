using System;
using System.Reflection;
using System.Threading;

namespace Topic_2_ICloneable_DeepCopy_
{
	class Program
	{
		static void Main(string[] args)
		{
			FullName fullName;
			Person person1 = new Person
			{
				fullName = new FullName { Name = "Jon", Patronymic = "Jonsci", Surname = "Jonov" },
				PaspotrNumber = 12321
			};

			var person2 = CloneObject(person1);

			person2.fullName.Name = "GeRALD";
			person2.PaspotrNumber = 33322211;

			Console.WriteLine($"person1 = {person1.PaspotrNumber} {person1.fullName.Name }  person2 = {person2.PaspotrNumber} {person2.fullName.Name }");
		}
		
		private static T CloneObject<T>(T obj)
		{
			T copy = SurfaceCopy(obj);

			foreach (var item in typeof(T).GetFields(BindingFlags.Instance|BindingFlags.NonPublic|BindingFlags.Public))
			{
				object original = item.GetValue(obj);
				item.SetValue(copy,CloneObject(original));
			}
			return copy;
		}

		private static T SurfaceCopy<T>(T obj)
		{
			MethodInfo mInfo = obj.GetType().GetMethod("MemberwiseClone", BindingFlags.Instance | BindingFlags.NonPublic);
			return (T)mInfo.Invoke(obj, null);
		}
	}
}
