using System;

namespace Topic_2_ICloneable_Value_type_
{
	class Program
	{
		static void Main(string[] args)
		{
			Poligon poligon1;
			Poligon poligon2;
			Poligon poligon3;
			poligon1.width = 10;
			poligon1.heignt = 5;

			poligon2 = (Poligon)poligon1.Clone();
			poligon3 = poligon1;

			Console.WriteLine($"poligon1.heignt = {poligon1.heignt} poligon1.width = {poligon1.width}");
			Console.WriteLine($"poligon2.heignt = {poligon2.heignt} poligon2.width = {poligon2.width}");
			Console.WriteLine($"poligon3.heignt = {poligon3.heignt} poligon3.width = {poligon3.width}");

		}

		public struct Poligon:ICloneable
		{
			public int width;
			public int heignt;

			public object Clone()
			{
				return new Poligon
				{
					width = this.width,
					heignt = this.heignt
				};
			}
		}
	}
}
