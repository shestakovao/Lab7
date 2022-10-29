using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static double CalculateArea(double x, double y, double z)
        {
            double p = (x + y + z) / 2.0;
            double s = Math.Sqrt(p*(p-x)*(p-y)*(p-z));
            return s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны первого треугольника A,B,C");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            double c1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите стороны второго треугольника A,B,C");
            double a2 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());
            double c2 = Convert.ToDouble(Console.ReadLine());
            double s1 = CalculateArea(a1, b1, c1);
            double s2 = CalculateArea(a2, b2, c2);

            if (s1 < s2)
            {
                Console.WriteLine("Площадь второго треугольника больше");
            }
            else
            {
                if (s1 > s2)
                {
                    Console.WriteLine("Площадь первого треугольника больше");
                }
                else 
                {
                    Console.WriteLine("Площади треугольников равны");
                }
                    
             }

            Console.ReadKey();
        }
    }
}
