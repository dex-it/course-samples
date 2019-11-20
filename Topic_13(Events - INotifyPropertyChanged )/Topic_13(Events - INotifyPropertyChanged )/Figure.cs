using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Topic_13_Events___INotifyPropertyChanged__
{
	public class Figure : INotifyPropertyChanged
	{
		private string name;
		private string color;
		private int numberOfFaces;
		public string Name
		{
			get { return name; }
			set
			{
				name = value;
				OnPropertyChanged("Name");
			}
		}
		public string Color
		{
			get { return color; }
			set
			{
				color = value;
				OnPropertyChanged("Color");
			}
		}
		public int NumberOfFaces
		{
			get { return numberOfFaces; }
			set
			{
				numberOfFaces = value;
				OnPropertyChanged("NumberOfFaces");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
		public void OnPropertyChanged([CallerMemberName] String propertyName = "")
		{
			Console.WriteLine($"Было изменено свойство {propertyName} ");
			if (PropertyChanged != null)
			{				
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
