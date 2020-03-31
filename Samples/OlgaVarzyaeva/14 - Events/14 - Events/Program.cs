using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace _14___Events
{
    class Program
    {
        public class Gamer : INotifyPropertyChanged
        {
            private string LoginValue = String.Empty;
            private int IDValue = 0;

            public event PropertyChangedEventHandler PropertyChanged;

            private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                Console.WriteLine("Внимание! Было изменено: "+ propertyName);
            }

            private Gamer()
            {
                LoginValue = "Gamer";
                IDValue = 123;
            }
            public static Gamer CreateNewGamer()
            {
                return new Gamer();
            }

            public string Login
            {
                get
                {
                    return this.LoginValue;
                }

                set
                {
                    if (value != this.LoginValue)
                    {
                        this.LoginValue = value;
                        NotifyPropertyChanged();
                    }
                }
            }

            public int ID
            {
                get
                {
                    return this.IDValue;
                }
                set
                {
                    if (value != this.IDValue)
                    {
                        this.IDValue = value;
                        NotifyPropertyChanged();
                    }
                }
            }

        }
        static void Main(string[] args)
        {
            BindingList<Gamer> gamerList = new BindingList<Gamer>();
            gamerList.Add(Gamer.CreateNewGamer());
            gamerList.Add(Gamer.CreateNewGamer());
            gamerList.Add(Gamer.CreateNewGamer());            
            gamerList[0].Login = "Destructor!!!";
            gamerList[0].ID = 25;
            Console.ReadLine();

        }
    }
}
