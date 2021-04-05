using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new1
{
    static class Ekran
    {
        public static double Ekran1
        {
            get
            {
                Console.WriteLine("Введите длину двух катетов (целых или с плавающей точкой) последовательно через Enter ");
                return Convert.ToDouble(Console.ReadLine());
            }
        }

        public static double Ekran2
        {
            get
            {
                Console.WriteLine();
                return Convert.ToDouble(Console.ReadLine());
            }
        }
        public static double VichislimGipotenuzu(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }
    }
}
