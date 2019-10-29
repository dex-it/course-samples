using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Dex.ABolokan.Services.Linq
{
	public class ProductService
	{
		private List<Product> _products;

		public ProductService()
		{
			CreateList();
		}

		public List<Product> GetAll()
		{
			return _products;
		}

		private void CreateList()
		{
			_products = new List<Product>();

			var r = new Random();
			int itemCount = r.Next(5, 15);

			for (var i = 0; i < itemCount; i++)
			{
				_products.Add(Create(i + 1));
			}

		}

		private Product Create(int index)
		{
			var r = new Random();
			var newProduct = new Product(index)
			{
				Count = r.Next(0, 1000),
				Name = $"Product_{index}",
				TypeId = r.Next(1, 5),
				IsNew = r.Next(1, 20) > 10
			};

			return newProduct;
		}
	}
}
