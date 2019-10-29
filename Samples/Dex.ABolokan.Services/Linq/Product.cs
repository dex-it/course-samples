using System;
using System.Collections.Generic;
using System.Text;

namespace Dex.ABolokan.Services.Linq
{
	public class Product
	{
		public Product(int id)
		{
			Id = id;
			Created = DateTime.UtcNow;
		}

		public int Id { get; private set; }
		public string Name { get; set; }
		public int Count { get; set; }

		public int TypeId { get; set; }

		public bool IsNew { get; set; }
		public DateTime Created { get; private set; }


		public override string ToString()
		{
			const string format = "Id: {0}, Name : {1}, Count: {2}, Type Id: {3}, New: {4}, Created: {5:dd MMM yyyy}";
			return string.Format(format, Id, Name, Count, TypeId, IsNew, Created);
		}
	}
}
