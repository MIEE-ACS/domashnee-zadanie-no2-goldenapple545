using System;

namespace HomeWork_2
{
    class Program
    {
        static double segment1(double x, double r)
        {
            double a = -7;
            double b = 2;
            double y = 0;
            if (r >= 2) { 
                y = Math.Sqrt(r * r - (x - a) * (x - a)) + b;
            } else if (r < 2) {
                if (a - r > x | a + r < x)
                {
                    return -10000;
                } else
                {
                    return y = Math.Sqrt(r * r - (x - a) * (x - a)) + b;
                }
            }


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
            double r, x;

            Console.WriteLine("Введите r");
            r = double.Parse(Console.ReadLine());

            if (r > 0)
            {
                for (x = -9; x < 5.2; x += 0.2)
                {
                    if (x < -9)
                    {
                        Console.WriteLine("Функция не определена");
                    }
                    else if (x < -4.9)
                    {
                        if (segment1(x, r) == -10000)
                        {
                            Console.WriteLine("Функция не определена в точке {0:0.00}", x);
                        } else
                        {
                            Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment1(x, r));
                            if (r > 2 & (x < -4.9 & x > -5.1))
                            {
                                Console.WriteLine("Разрыв в точке -5");
                                Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment2(x));
                            }
                        }
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
                    else if (x < 5.2)
                    {
                        Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment5(x));
                    }
                }
            } else
            {
                Console.WriteLine("Радиус меньше нуля!");
            }

            while (true)
            {
                Console.WriteLine("Введите x");
                x = double.Parse(Console.ReadLine());

                if (x < -9)
                {
                    Console.WriteLine("Функция не определена");
                }
                else if (x < -4.9)
                {
                    Console.WriteLine("Введите r");
                    r = double.Parse(Console.ReadLine());

                    if (segment1(x, r) == -10000)
                    {
                        Console.WriteLine("Функция не определена в точке {0:0.00}", x);
                    }
                    else
                    {
                        Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment1(x, r));
                        if (r > 2 & (x < -4.9 & x > -5.1))
                        {
                            Console.WriteLine("Разрыв в точке -5");
                            Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment2(x));
                        }
                    }
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
                else
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment5(x));
                }
            }
        }
    }
}

