using System;

namespace test_lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вариант 3
            Console.WriteLine(MyClass.MyFunction(50));
        }
    }

    public static class MyClass
    {
        public static double MyFunction(double x)
        {
            if (x >= 0)
            {
                return Ln(x) * Cos(x);
            }
            else
            {
                var a = Sin(x) - Cos(x);
                a = Abs(a);
                return a / (Ln(Abs(x)) + 1);
            }
        }

        public static double Ln(double x)
        {
            x = (x - 1) / (x + 1);
            double sum = 0;
            for (int n = 1; n < 200; n = n + 2)
            {
                sum += Math.Pow(x, n) / n;

            }
            return Math.Round(sum*2, 4);
        }

        public static double Cos(double x)
        {
            x = (x / 180) * Math.PI; // переводим угол в радианы
            double sum = 0;
            double a;
            long b;
            for (int n = 0; n < 10; n++)
            {
                a = Math.Pow(-1, n) * Math.Pow(x, (2 * n));
                b = Factorial(2 * n);
                sum += a / b;
            }
            return Math.Round(sum, 4);
        }

        public static double Sin(double x)
        {
            x = (x / 180) * Math.PI; // переводим угол в радианы
            double sum = 0;
            double a;
            long b;
            for (int n = 0; n < 10; n++)
            {
                a = Math.Pow(-1, n) * Math.Pow(x, (2 * n + 1));
                b = Factorial(2 * n + 1);
                sum += a / b;
            }
            return Math.Round(sum, 4);
        }

        public static long Factorial(int x)
        {
            if (x < 0)
                return -1;
            else if (x < 2)
                return 1;
            else
            {
                long fact = 1;
                for (int i = 1; i <= x; i++)
                {
                    fact *= i;
                }
                return fact;
            }
        }

        public static double Abs(double x)
        {
            if (x < 0)
            {
                return x * -1;
            }
            else
                return x;
        }
    }
}