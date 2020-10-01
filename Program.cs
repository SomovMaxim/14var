using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDIUM_14var
{
    class Program
    {
        static void Main(string[] args)
        {
            //средний
            try
            {
                const double k = 3.4;
                double Y, t, a, b;
                Console.Write("Введите b:");
                b = double.Parse(Console.ReadLine());
                t = Math.Pow(b, 2) + Math.Pow(k, 3);
                a = Math.Sqrt(b + t);
                Y = Math.Pow(Math.Sin(Math.Pow(a, 2)) + (Math.Pow(b, 2)), 4);
                Console.WriteLine("t =" + t);
                Console.WriteLine("a =" + a);
                Console.WriteLine("Y =" + Y);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}