using System;
using System.ComponentModel;
using System.Threading;

namespace Topic_13_Events___INotifyPropertyChanged__
{
	class Program
	{
		static void Main(string[] args)
		{
			Figure figure = new Figure();
			figure.PropertyChanged += PrintChangedPropertyInfo;
						
			figure.Name = "Triangle";
			Thread.Sleep(3000);
			figure.Color = "Red";
			Thread.Sleep(3000);
			figure.NumberOfFaces = 3;
			Thread.Sleep(3000);
			Console.WriteLine($"figure.Name = {figure.Name} \nfigure.Color = {figure.Color}  \nfigure.NumberOfFaces = {figure.NumberOfFaces}");
		}
		
		public static void PrintChangedPropertyInfo(object sender, EventArgs e)
		{
			Console.WriteLine($"Handler Was used, {e}");
//			Console.WriteLine($"Handler Was used, {e.PropertyName}");
		}
	}
}
