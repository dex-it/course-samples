using System;

namespace Topic_2_ReferenceType_
{
	class Program
	{
		static void Main(string[] args)
		{
			Area area1 = new Area { x = 3, y = 3 };
			Area area2 = new Area { };
			area2 = area1;
			Console.WriteLine("area1.x = " + area1.x + " area1.y = " + area1.y);
			Console.WriteLine("area2.x = " + area2.x + " area2.y = " + area2.y);
			area1.x = 5;
			Console.WriteLine("After changing the area1.x");
			Console.WriteLine("area1.x = " + area1.x + " area1.y = " + area1.y);
			Console.WriteLine("area2.x = " + area2.x + " area2.y = " + area2.y);

			Fruit fruit = new Fruit { Color = "yellow", Name = "Banana" };
			Console.WriteLine("fruit = " + fruit.Color + " " + fruit.Name);
			ChangColor(fruit);
			Console.WriteLine("After changing the fruit color");
			Console.WriteLine("fruit = " + fruit.Color + " " + fruit.Name);

			

		}
		static void ChangColor(Fruit fruit1)
		{
			fruit1.Color = "Green";
			fruit1 = new Fruit { Color = "Read" };
			Console.WriteLine("fruit1 = " + fruit1.Color + " " + fruit1.Name);
		}


	}
}
