using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace События
{
    class Program
    {
       public delegate int Stop_while(string str);
       public static event Stop_while Stoping;
        static void Main(string[] args)
        {
            // первое задание
            Test t = new Test();
            t.PropertyChanged += DisplayMessage;
            t.NotifyPropertyChanged("Hello Word!! (сообщение от INotifyPropertyChanged) \n");
            t.PropertyChanged -= DisplayMessage;

            //второе задание
            Stoping += Event_Stop;
            int count = 0, flag_while = 1;
            Queue<MyObject> obj = new Queue<MyObject>();          
            Console.WriteLine("Введите предел очереди (число n)");
                int n = Convert.ToInt32(Console.ReadLine());
            while (flag_while == 1) // цикл для добавления
            {
                obj.Enqueue(new MyObject() { Info = "Объект" + count.ToString() }); //добавление обьекта в очередь   
                if (count+1>=n)
                {
                    if (Stoping != null)
                        flag_while = Stoping("Событие активировалось через " + obj.Count + " добавлении обьектов в очередь \n"); //вызов событмия с прерыванием цикла
                    else Console.WriteLine("нет обработчика");                    
                }
                          
                count++;             
            }
            flag_while = 1;
            while (flag_while == 1) // цикл для очищения
            {
                MyObject my = obj.Dequeue();
                Console.WriteLine("Удален " + my.Info);
                if (obj.Count==0)
                {
                    if (Stoping != null)
                        flag_while = Stoping("Событие-Обьекты удалены из очереди \n"); //вызов событмия с прерыванием цикла
                    else Console.WriteLine("нет обработчика");
                }
               
            }
            Stoping -= Event_Stop;



            //третье задание
            Number_stream_analysis stream = new Number_stream_analysis();
            stream.method_stream();


            Console.ReadLine();
        }
       public static void DisplayMessage(object sender, PropertyChangedEventArgs e) //обработчик а
        {
            Console.WriteLine(e.PropertyName);
        }

        private static int Event_Stop(string str)
        {

            Console.WriteLine(str);
            return 0;

        }

        class Test : INotifyPropertyChanged
        {           
         
            public event PropertyChangedEventHandler PropertyChanged;
           public void NotifyPropertyChanged(string msg)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(msg));
            }
           
        }

        class MyObject
        {
            public string Info { get; set; }
        }


        class Number_stream_analysis
        {
            private Random random = new Random();
            private double number1, number2, avarge, deviation;
            private delegate void Stream_analysis(int n, double number1, double number2, double average, double deviation);
            private event Stream_analysis Stream;

            public void method_stream()
            {
                Stream += Event_Stream;
                Console.WriteLine("введите предел отклонения (x)");
                double x =Convert.ToDouble(Console.ReadLine());
                number1 = random.Next(100);
                Console.Write(number1.ToString()+" ");
                int k = 0;
                for (int i=0;i<10;i++)
                {
                    number2 = random.Next(100);
                    Console.Write(number2.ToString()+" ");
                    avarge = (number2 + number1) / 2; //среднее
                    
                    deviation = Math.Sqrt((Math.Pow(avarge - number1, 2) + Math.Pow(avarge - number2, 2)) / 2); //стандартное отклонение
                    if (deviation > x)
                    {
                        Stream?.Invoke(i+1, number1, number2, avarge, deviation);

                    }
                    else k++;
                    number1 = number2;
                }
                if (k == 10)
                    Console.WriteLine("Нет аварийных отклонении");
                Stream -= Event_Stream;
            }
            private void Event_Stream(int n, double number1, double number2, double average, double deviation)
            {
                Console.WriteLine("\n Cработало событие "+n+" - N1=" + number1.ToString() + "  N2=" + number2.ToString() + "   Среднее=" + avarge.ToString() + "   Отклонение=" + deviation.ToString());

            }



        }
    }
}
