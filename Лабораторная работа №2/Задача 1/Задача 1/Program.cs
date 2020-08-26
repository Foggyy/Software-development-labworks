using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0,i,posl;
            uint n;


            Random rand = new Random();
            Console.WriteLine("Введите длину числовой последовательности");
            
            //ввод длины последовательности и проверка на ввод целого положительного числа
            while (!uint.TryParse(Console.ReadLine(), out n) || (n == 0))
                Console.WriteLine("Ошибка ввода, введите целое положительное число");

            Console.WriteLine("Числовая последовательность: ");
            
            for (i = 0; i < n; i++)
            {
                posl = rand.Next(-200,200);                           //последовательность чисел
                Console.Write(" {0}",posl);
                
                if ((posl % 2) != 0)                   //проверка элемента на нечетность
                {
                    sum += posl;                       //прибавление нечетного числа к сумме
                }            
            }
            Console.WriteLine("\nСумма нечетных элементов последовательности равна: {0}",sum);
            Console.ReadLine();



        }
    }
}
