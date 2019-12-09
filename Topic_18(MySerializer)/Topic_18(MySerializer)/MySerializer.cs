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
		

		public List<string> Serialize(object graph)
		{
			List<string> SerList = new List<string> { };
			Type type = graph.GetType();

			SerList.Add(type.Name.ToString());
			foreach (var item in type.GetProperties(BindingFlags.Instance | BindingFlags.Public))
			{
				SerList.Add(item.Name.ToString() + " = " + item.GetValue(graph, null).ToString());				
			}

			return SerList;
		}

		public string Serialize2(object graph)// Dictionary<string, object>
		{
			Type type = graph.GetType();			
			Dictionary<string, object> serializedObj = new Dictionary<string, object> { };

			//serializedObj.Add("type", type); 
			string s = "";
			foreach (var item in type.GetProperties(BindingFlags.Instance | BindingFlags.Public))
			{
				
				Console.WriteLine($"{item.Name.ToString()}  = {item.GetValue(graph, null).ToString()}");
				serializedObj.Add(item.Name.ToString(), item.GetValue(graph, null));

				s = s + $"\"{item.Name.ToString()}\" : \"{item.GetValue(graph,null)}\",";
				
			}

			//return serializedObj;
			var j = "{\"Name\":\"Byll\",\"Surname\":\"Byll\",\"Patronymic\":\"Byll\"}";
			Console.WriteLine("________ ______");
			Console.WriteLine("{"+$"{s}"+"}");
			Console.WriteLine("________ ______");
			Console.WriteLine("________ _ _____");
			Console.WriteLine(j); 
			Console.WriteLine("________ ___ ___");
			return j;
		}

		public void Deserializer<T>(string json) where T : new()//(Dictionary<string, object> serObj)where T:new()
		{
			var ser = new DataContractJsonSerializer(typeof(T));
			var stream1 = new MemoryStream(Encoding.UTF8.GetBytes(json));
			stream1.Position = 0;
			var p2 = (T)ser.ReadObject(stream1);

			var p = new T()
			{

			};
			
			
			//foreach (var item in serObj)
			//{
			//	if (item.Key == "type")
			//	{
			//		type = item.Value;
			//	}			
			//	else
			//	{
			//		o[i] = item.Value;
			//	}
			//	i++;
			//}


			dynamic obj = new ExpandoObject();

			obj.pr1 = "fd";
			obj.pr3 = "fw";
			obj.pr2 = "fg";

			Console.WriteLine($"p = {obj.pr1}");
			int i = 0;
			//foreach (var item in serObj)
			//{
			//	i++;
			//	if (i==1)
			//	{
			//		obj.prop1 = item.Value;
			//	}
			//	if (i == 2)
			//	{
			//		obj.prop2 = item.Value;
			//	}
			//	if (i == 3)
			//	{
			//		obj.prop3 = item.Value;
			//	}
			//}
			

			//p = (T)obj;
					
			

		}
	}
}
