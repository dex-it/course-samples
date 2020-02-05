using System;
using System.ComponentModel;

namespace События
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            t.PropertyChanged += DisplayMessage;
            t.NotifyPropertyChanged("Hello Word!!");
            t.PropertyChanged -= DisplayMessage;
            Console.ReadLine();
        }
        private static void DisplayMessage(object sender, PropertyChangedEventArgs e)
        {
            Console.WriteLine(e.PropertyName);
        }
        class Test : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;
           public void NotifyPropertyChanged(string msg)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(msg));
            }
           
        }
    }
}
