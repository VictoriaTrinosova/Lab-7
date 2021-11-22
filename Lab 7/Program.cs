using System;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Длины сторон первого треугольника");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Длины сторон второго треугольника");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            CalcArea(a, b, c, x, y, z);
            Console.ReadKey();
        }
        static void CalcArea (double a,double b, double c, double x, double y, double z)
        {
            double p1 = (a + b + c) / 2;
            double p2 = (x + y + z) / 2;
            double s1 = Math.Sqrt (p1 * (p1 - a) * (p1 - b) * (p1 - c));
            double s2 = Math.Sqrt(p2 * (p2 - x) * (p2 - y) * (p2 - z));
            if(s1>s2)
            {
                Console.WriteLine("Площадь первого треугольника больше");
            }
            else
            {
                Console.WriteLine("Площадь второго треугольника больше");
            }
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            
        }
    }
}
