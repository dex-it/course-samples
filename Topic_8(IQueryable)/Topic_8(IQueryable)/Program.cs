using System;
using System.Linq;

namespace Topic_8_IQueryable_
{
	class Program
	{
		static void Main(string[] args)
		{
			var chemicalElements = GenerateACollection();

			ExampleWithWhere(chemicalElements);
			ExampleWithOrderNumber(chemicalElements);
			ExampleWithOrderByDescending(chemicalElements);
			ExampleWithGroupBy(chemicalElements);
			ExampleWithSingle(chemicalElements);
			ExampleWithAny(chemicalElements);
			ExampleWithMax(chemicalElements);					
		}

		
		public static void ExampleWithWhere(ChemicalElement[] ElementsCollection)
		{
			var selectedElementsArray = ElementsCollection.Where(e => e.IsMetal==true).ToArray();

			Console.WriteLine($"Name            |OrderNumber|OpeningYear  |IsMetal ");

			foreach (var item in selectedElementsArray)
			{
				Console.WriteLine($"{item.Name}   |{item.OrderNumber}         |{item.OpeningYear.ToString("d")}     |{item.IsMetal}");
			}

			Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
		}

		public static void ExampleWithOrderNumber(ChemicalElement[] ElementsCollection)
		{
			var selectedElementsArray = ElementsCollection.Where(e => e.OrderNumber > 50).Where(e => e.IsMetal == true).ToArray();

			foreach (var item in selectedElementsArray)
			{
				Console.WriteLine(item.OrderNumber);				
			}

			Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
		}

		public static void ExampleWithOrderByDescending(ChemicalElement[] ElementsCollection)
		{
			var selectedElementsArray = ElementsCollection.Where(e => e.OrderNumber > 90).OrderByDescending(e => e.OrderNumber);

			foreach (var item in selectedElementsArray)
			{
				Console.WriteLine(item.OrderNumber);
			}

			Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
		}
		public static void ExampleWithGroupBy(ChemicalElement[] ElementsCollection)
		{
			Console.WriteLine("New Collection:");
			Console.WriteLine("MaxOrderNumbr |IsMetal");

			var selectedElementsArray = (from element in ElementsCollection
										 group element by element.IsMetal into nCollectoin
										 select new
										 {
											 MaxOrderNubber = nCollectoin.Max(e => e.OrderNumber),
											 IsMetal = nCollectoin.Key											
										 }).ToList();

			foreach (var item in selectedElementsArray)
			{

				Console.WriteLine($"{item.MaxOrderNubber}           |{item.IsMetal}");
			}

			Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");			
		}

		public static void ExampleWithSingle(ChemicalElement[] ElementsCollection)
		{			
			var selectedElementsArray = ElementsCollection.Single(e => e.OpeningYear.Year == 1940);

			Console.WriteLine("Collection.Single()");
			Console.WriteLine($"Name            |OrderNumber|OpeningYear         |IsMetal ");
			Console.WriteLine($"{selectedElementsArray.Name}    |{selectedElementsArray.OrderNumber}  " +
				$"      |{selectedElementsArray.OpeningYear.ToString("d")}		 |{selectedElementsArray.IsMetal}");
			Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
		}
		public static void ExampleWithAny(ChemicalElement[] ElementsCollection)
		{
			var selectedElementsArray = ElementsCollection.Any(e => e.OrderNumber == 55);

			Console.WriteLine("Collection.Any()");
			Console.WriteLine($"Искомый элемент найден? = {selectedElementsArray} ");
			Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
		}

		public static void ExampleWithMax(ChemicalElement[] ElementsCollection)
		{
			var maxOrderNumber = ElementsCollection.Max(e => e.OrderNumber);
			var minOrderNumber = ElementsCollection.Min(e => e.OrderNumber);
			var sumOrderNumber = ElementsCollection.Sum(e => e.OrderNumber);

			Console.WriteLine("Collection.Max_Min_Sum");
			Console.WriteLine($"MaxOrderNumber = {maxOrderNumber} \nMinOrderNumber = {minOrderNumber} \nSumOrderNumber = {sumOrderNumber}");
			Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
		}
		///
		public static ChemicalElement[] GenerateACollection()
		{
			var ElementsCollection = new ChemicalElement[100];

			for (int i = 0; i < 100; i++)
			{
				var dateTime = new DateTime(); 
				var chemicalElement = new ChemicalElement();
				chemicalElement.Name = "Element_№_" + i+1;
				chemicalElement.OrderNumber = i+1;
				chemicalElement.OpeningYear = dateTime.AddYears(1900 + i);

				if ((i+1)%10 == 0)
				{
					chemicalElement.IsMetal = true;
				}
				else
				{
					chemicalElement.IsMetal = false;
				}

				ElementsCollection[i] = chemicalElement;
				
			}
			
			return ElementsCollection;
		}
	}
}
