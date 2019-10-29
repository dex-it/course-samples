using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Dex.ABolokan.Services.IComparableTest
{
	public class Circle : IComparable
	{
		public Circle(double radius)
		{
			Radius = radius;
			Area = GetArea();
		}

		public double Area { get; }
		public double Radius { get; }


		public double GetArea()
		{
			return 2 * Math.PI * Math.Sqrt(Radius);
		}

		public int CompareTo(object obj)
		{
			if (!(obj is Circle circle))
			{
				throw new InvalidCastException("Object is not valid");
			}

			if (Area < circle.Area)
			{
				return -1;
			}

			if (Area.EqualTo(circle.Area, 0))
			{
				return 0;
			}

			if (Area > circle.Area)
			{
				return 1;
			}

			return 0;
		}

		public override string ToString()
		{
			return $"Radius: {Radius}, Area: {Area}";
		}
	}

	public class RadiusComparer : IComparer<Circle>
	{
		public int Compare(Circle x, Circle y)
		{
			if (x == null || y == null)
			{
				throw new InvalidCastException("Object is not valid");
			}

			if (x.Radius < y.Radius)
			{
				return -1;
			}

			if (x.Radius.EqualTo(y.Radius, 0))
			{
				return 0;
			}

			if (x.Radius > y.Radius)
			{
				return 1;
			}

			return 0;
		}
	}

}

public static class DoubleExtensions
{
	public static bool EqualTo(this double value1, double value2, double epsilon)
	{
		return Math.Abs(value1 - value2) < epsilon;
	}
}

