using System;

namespace Lab_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Длина ребра куба");
            int a = Convert.ToInt32(Console.ReadLine());
            CalcKub(a);
            Console.ReadKey();
        }
        static void CalcKub(double a)
        {
            double v = a * a * a;
            double s = 6 * a * a;
            Console.WriteLine("Объем {0}",v);
            Console.WriteLine("Площадь поверхности {0}",s);
        }
    }
}
