using System;

namespace HomeWork_2
{
    class Program
    {
        static double segment1(double x, double r)
        {
            double a = -7;
            double b = 2;
            double y = Math.Sqrt(r * r - (x - a) * (x - a)) + b;

            return y; // Возвращаем значение в верхней четверти
        }

        static double segment2(double x)
        {
            return 2;
        }

        static double segment3(double x)
        {
            return -0.5*x;
        }

        static double segment4(double x)
        {
            return Math.Sin(x);
        }


        static double segment5(double x)
        {
            return x - Math.PI;
        }



        static void Main(string[] args)
        {
            double r;

            Console.WriteLine("Введите r");
            r = double.Parse(Console.ReadLine());

            for (double x = -9; x <= 5; x += 0.2)
            {
                if (x < -9)
                {
                    Console.WriteLine("Функция не определена");
                }
                else if (x < -5)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment1(x, r));
                }
                else if (x < -4)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment2(x));
                }
                else if (x < 0)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment3(x));
                }
                else if (x < Math.PI)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment4(x));
                }
                else if (x <= 5)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment5(x));
                }
            }
        }
    }
}

