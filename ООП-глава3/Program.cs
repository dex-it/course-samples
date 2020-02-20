using System;

namespace ООП_глава3
{
    class Program
    {
        static void Main(string[] args)
        {

           
            while (true)
            {
                Console.WriteLine("Выберете фигуру:1-квадрат,2-прямоугольник,3-круг,4-треугольник....при выходе введите 0");
                int vibor = Convert.ToInt32(Console.ReadLine());
                if (vibor == 0) break;
                switch (vibor)
                {
                    case 1:
                        Kvadrat kvadrat = new Kvadrat(); // подключение к классу "квадрат"
                        Console.WriteLine("Введите длину первой стороны:"); kvadrat.Storona1 = Convert.ToDouble(Console.ReadLine()); //ввод данных связанные с ним
                        Console.WriteLine("Введите длину второй стороны:"); kvadrat.Storona2 = Convert.ToDouble(Console.ReadLine());
                        kvadrat.S_kv(kvadrat.Storona1, kvadrat.Storona2); //обращение к методу в квадрате для нахождения площади
                        break;
                    case 2:
                        Pryamougolnik pryamougolnik = new Pryamougolnik();
                        Console.WriteLine("Введите длину первой стороны:"); pryamougolnik.Storona1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите длину второй стороны:"); pryamougolnik.Storona2 = Convert.ToDouble(Console.ReadLine());
                        pryamougolnik.S_pr(pryamougolnik.Storona1, pryamougolnik.Storona2);
                        break;
                    case 3:
                        Krug krug = new Krug();
                        Console.WriteLine("Введите длину радиуса:"); krug.Radius = Convert.ToDouble(Console.ReadLine());
                        krug.S_kr(krug.Radius);
                        break;
                    case 4:
                        Treugolnik treugolnik = new Treugolnik();
                        Console.WriteLine("Введите длину основания:"); treugolnik.Storona1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите длину высоты:"); treugolnik.Visota = Convert.ToDouble(Console.ReadLine());
                        treugolnik.S_tr(treugolnik.Storona1, treugolnik.Visota);
                        break;
             
                } 
            }
        }
    }
    public abstract class Figure // класс с хранением возможных данных о фигуре, стороны, высота, радиус, углы и тд....
    {
        private double a, b, r, h;

        public double Storona1 { get { return a; } set { a = value; } } //свойства
        public double Storona2 { get { return b; } set { b = value; } }
        public double Radius { get { return r; } set { r = value; } }
        public double Visota { get { return h; } set { h = value; } }     

    }
   interface I_ploshad_kvadrata  //интерфейс с сигнатурой для нахлждения площади
    {
        void S_kv(double a, double b);
    }
    interface I_ploshad_pryamougolnika
    {
        void S_pr(double a, double b);
    }
    interface I_ploshad_kruga
    {
        void S_kr(double r);
    }
    interface I_ploshad_treugolnika
    {
        void S_tr(double a, double h);
    }
    public class Kvadrat : Figure, I_ploshad_kvadrata  // класс для реальзации вычислении связанные с квадратом
    {
        public void S_kv(double a, double b)
        {
            if (a == b)
                Console.WriteLine("Площадь квадрата =" + (a * b).ToString());
            else Console.WriteLine("Данная фигура не квадрат");
        }
    }
    public class Krug : Figure, I_ploshad_kruga
    {
        public void S_kr(double r)
        {
            Console.WriteLine("Площадь круга =" + (Math.PI * Math.Pow(r, 2)).ToString());
        }    
    }
    public class Pryamougolnik : Figure, I_ploshad_pryamougolnika
    {
        public void S_pr(double a, double b)
        {
            if (a == b)
                Console.WriteLine("Площадь прямоугольника =" + (a * b).ToString());
        }       
    }
    public class Treugolnik : Figure, I_ploshad_treugolnika
    {
        public void S_tr(double a, double h)
        {      
                Console.WriteLine("Площадь треугольника =" + ((a * h)/2.0).ToString());
        }
    }
}
