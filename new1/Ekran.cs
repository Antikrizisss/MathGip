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
                try
                {
                    Console.WriteLine("Введите длину двух катетов (целых или с плавающей точкой) последовательно через Enter ");
                    return Convert.ToDouble(Console.ReadLine());
                }
                catch (SystemException)
                {
                    Console.WriteLine("Можно вводить только числа (4 или 4,3)");
                    Console.WriteLine("Введите длину еще раз: ");
                    return Convert.ToDouble(Console.ReadLine());
                }
            }
        }

        public static double Ekran2
        {
            get
            {
                try
                {
                    Console.WriteLine("Вторая длина: ");
                    return Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Можно вводить только числа (например 4 или 4,3)");
                    Console.WriteLine("Введите длину еще раз: ");
                    return Convert.ToDouble(Console.ReadLine());
                }
            }
        }
        public static double VichislimGipotenuzu(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }
    }
}
