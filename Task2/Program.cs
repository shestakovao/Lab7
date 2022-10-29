using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void CalculateAreaAndVolume(double a, out double s, out double v)
        {
            s = 6*Math.Pow(a, 2);
            v = Math.Pow(a, 3);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер ребра куба");
            double a = Convert.ToDouble(Console.ReadLine());
            double s;
            double v;
            CalculateAreaAndVolume(a, out s, out v);
            Console.WriteLine("Площадь куба равна {0}\nОбъём куба равен {1}", s, v);
            Console.ReadKey();
        }
    }
}
