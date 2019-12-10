using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Dynamic;
using System.Runtime.Serialization.Json;
using System.IO;

namespace Topic_18_MySerializer_
{
	public class MySerializer
	{
		public string Serialize(object graph)
		{
			string s = "";
			Type type = graph.GetType();

			foreach (var item in type.GetProperties(BindingFlags.Instance | BindingFlags.Public))
			{
				s = s + $"\"{item.Name.ToString()}\":\"{item.GetValue(graph, null)}\", ";
			}

			s = "{" + $"{s}" + "}";

			return s;
		}

		public T Deserializer<T>(string json) where T : new()
		{
			var ser = new DataContractJsonSerializer(typeof(T));
			var stream1 = new MemoryStream(Encoding.UTF8.GetBytes(json));
			stream1.Position = 0;
			var obj = (T)ser.ReadObject(stream1);

			return obj;
		}
	}
}
