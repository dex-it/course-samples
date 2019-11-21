using System;
using System.Linq;

namespace Topic_8_IQueryable_
{
	class Program
	{
		static void Main(string[] args)
		{
			ChemicalElement[] chemicalElements = GenerateACollection();

			ExampleWith_Where(chemicalElements);
			ExampleWith_OrderNumber_Where(chemicalElements);
			ExampleWith_OrderNumber_OrderByDescending(chemicalElements);
			ExampleWith_GroupBy(chemicalElements);
			ExampleWith_Single(chemicalElements);
			ExampleWith_Any(chemicalElements);
			ExampleWith_Max(chemicalElements);					
		}

		
		public static void ExampleWith_Where(ChemicalElement[] ElementsCollection)
		{
			var selectedElementsArray = ElementsCollection.Where(e => e.IsMetal==true).ToArray();
			Console.WriteLine($"Name            |OrderNumber|OpeningYear  |IsMetal ");
			foreach (var item in selectedElementsArray)
			{
				Console.WriteLine($"{item.Name}   |{item.OrderNumber}         |{item.OpeningYear.ToString("d")}     |{item.IsMetal}");
			}
			Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
		}

		public static void ExampleWith_OrderNumber_Where(ChemicalElement[] ElementsCollection)
		{
			var selectedElementsArray = ElementsCollection.Where(e => e.OrderNumber > 50).Where(e => e.IsMetal == true).ToArray();
			foreach (var item in selectedElementsArray)
			{
				Console.WriteLine(item.OrderNumber);				
			}
			Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
		}

		public static void ExampleWith_OrderNumber_OrderByDescending(ChemicalElement[] ElementsCollection)
		{
			var selectedElementsArray = ElementsCollection.Where(e => e.OrderNumber > 90).OrderByDescending(e => e.OrderNumber);
			foreach (var item in selectedElementsArray)
			{
				Console.WriteLine(item.OrderNumber);
			}
			Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
		}
		public static void ExampleWith_GroupBy(ChemicalElement[] ElementsCollection)
		{
			Console.WriteLine("New Collection:");
			Console.WriteLine("MaxOrderNumbr |IsMetal");
			var selectedElementsArray = (from element in ElementsCollection
										 group element by element.IsMetal into nCollectoin
										 select new
										 {
											 MaxOrderNubber = nCollectoin.Max(e => e.OrderNumber),
											 IsMetal = nCollectoin.Key
											 //IsMetal = nCollectoin(e=>e.Is)
										 }).ToList();
			foreach (var item in selectedElementsArray)
			{

				Console.WriteLine($"{item.MaxOrderNubber}           |{item.IsMetal}");
			}
			Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
			//var res = (from a in chemicalElements
			//		   group a by a.IsMetal into tmp
			//		   select new
			//		   {
			//			   Name = tmp.Key,
			//			   MaxNum = tmp.Max(x => x.IsMetal),
			//			   MinNum = tmp.Min(x => x.Name),
			//			   SumNum = tmp.Sum(x => x.OrderNumber),
			//			   Other = tmp.Max(x => x.OpeningYear)
			//		   }).ToList();
		}

		public static void ExampleWith_Single(ChemicalElement[] ElementsCollection)
		{			
			var selectedElementsArray = ElementsCollection.Single(e => e.OpeningYear.Year == 1940);
			Console.WriteLine("Collection.Single()");
			Console.WriteLine($"Name            |OrderNumber|OpeningYear         |IsMetal ");
			Console.WriteLine($"{selectedElementsArray.Name}    |{selectedElementsArray.OrderNumber}  " +
				$"      |{selectedElementsArray.OpeningYear.ToString("d")}		 |{selectedElementsArray.IsMetal}");
			Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
		}
		public static void ExampleWith_Any(ChemicalElement[] ElementsCollection)
		{
			var selectedElementsArray = ElementsCollection.Any(e => e.OrderNumber == 55);
			Console.WriteLine("Collection.Any()");
			Console.WriteLine($"Искомый элемент найден? = {selectedElementsArray} ");

			Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
		}

		public static void ExampleWith_Max(ChemicalElement[] ElementsCollection)
		{
			var MaxOrderNumber = ElementsCollection.Max(e => e.OrderNumber);
			var MinOrderNumber = ElementsCollection.Min(e => e.OrderNumber);
			var SumOrderNumber = ElementsCollection.Sum(e => e.OrderNumber);
			Console.WriteLine("Collection.Max_Min_Sum");
			Console.WriteLine($"MaxOrderNumber = {MaxOrderNumber} \nMinOrderNumber = {MinOrderNumber} \nSumOrderNumber = {SumOrderNumber}");
			Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
		}
		///
		public static ChemicalElement[] GenerateACollection()
		{
			ChemicalElement[] ElementCollection = new ChemicalElement[100];
			for (int i = 0; i < 100; i++)
			{
				DateTime dateTime = new DateTime(); 
				ChemicalElement chemicalElement = new ChemicalElement();
				chemicalElement.Name = "Element_№_" + i+1;
				chemicalElement.OrderNumber = i+1;
				chemicalElement.OpeningYear = dateTime.AddYears(1900 + i);// new DateTime(1990 + (i+1));
				if ((i+1)%10 == 0)
				{
					chemicalElement.IsMetal = true;
				}
				else
				{
					chemicalElement.IsMetal = false;
				}

				ElementCollection[i] = chemicalElement;
				//Console.WriteLine(ElementCollection[i].OrderNumber + ElementCollection[i].Name + ElementCollection[i].IsMetal);
			}
			
			return ElementCollection;
		}
	}
}
