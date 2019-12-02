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
				OnPropertyChanged();
			}
		}
		public string Color
		{
			get { return color; }
			set
			{
				color = value;
				OnPropertyChanged();
			}
		}
		public int NumberOfFaces
		{
			get { return numberOfFaces; }
			set
			{
				numberOfFaces = value;
				OnPropertyChanged();
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged([CallerMemberName] string propertyName = "")
		{
			Console.WriteLine($"Было изменено свойство {propertyName} ");

			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
