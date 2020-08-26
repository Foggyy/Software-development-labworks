using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ok1 = true, ok2 = false;
            double x, y, x1, y1, x2, y2, x3, y3;

            Console.WriteLine("Введите x");
            while (!Double.TryParse(Console.ReadLine(), out x)) //ввод x
                Console.WriteLine("Ошибка ввода. Введите целое или вещественное число");
            Console.WriteLine("Введите y");
            while (!Double.TryParse(Console.ReadLine(), out y)) //ввод y
                Console.WriteLine("Ошибка ввода. Введите целое или вещественное число");
            Console.WriteLine("Точка принадлежит плоскости?");




            // треугольник во 2 четверти
            if (x <= -5 && y < 0 || x >= 5 && y < 0)
            {
                Console.WriteLine(ok2);
                Console.ReadLine();
            }
            else
            {
                x1 = -5 - x;
                y1 = 3 - y;
                if (y1 / x1 <= 0.6 /*тангенс*/ && y <= 3 && y >= 0 && x >= -5 && x <= 0 || x == -5 && y == 0) // проверка принадлежности точки 2 четверти
                    Console.WriteLine(ok1);
                else
                {
                    // треугольник в 3 четверти
                    x2 = -5 - x;
                    y2 = -5 - y;
                    if (y2 / x2 <= 1 /*тангенс*/ && x >= -5 && y >= -5 && x <= 0 && y <= 0 || x == 0 && y == -5) // проверка принадлежности точки 3 четверти
                        Console.WriteLine(ok1);
                    else
                    {
                        // треугольник в 4 четверти
                        x3 = 5 - x;
                        y3 = -5 - y;
                        if (y3 / x3 <= 1 && x <= 5 && x >= 0 && y >= -5 && y <= 0 || x == 5 && y == 0) // проверка принадлежности точки 4 четверти
                            Console.WriteLine(ok1);
                        else

                            Console.WriteLine(ok2);
                    }
                }


                Console.ReadLine();

            }
        }
    }
}
