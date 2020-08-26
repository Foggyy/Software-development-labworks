using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача__1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, res1; ;
            bool res2, res3;
                  
            
            //начало 1 задачи

            Console.WriteLine("Задача 1");
            Console.Write("Введите число: n = ");                           
           
            while (!int.TryParse(Console.ReadLine(), out n))                        //ввод переменной n
                Console.WriteLine("Ошибка ввода, введите целое число");

            Console.Write("Введите число: m = ");
            while (!int.TryParse(Console.ReadLine(), out m))                         //ввод переменной m
                Console.WriteLine("Ошибка ввода, введите целое число");
            if (m>1 || m<1)                                                         //проверка деления на 0
            {
                res1 = n++ / --m;                                                   //преобразования
                Console.WriteLine("n = {0}, m = {1}, res1 = {2}.", n, m, res1);     //вывод вычислений
                Console.WriteLine("Нажмите 'Enter' чтобы продолжить");
                Console.ReadLine();
            }
            else
            Console.WriteLine("Ошибка вычисления, деление на 0 невозможно");        


            //конец 1 задачи

            //начало 2 задачи

            Console.WriteLine("Задача 2");
            if (m==0)                                                       //проверка деления на 0
                Console.WriteLine("Ошибка вычисления, m должно быть больше, либо меньше 0");                            
            else
            {
                res2 = n-- > n / m++;                                       //преобразования
                Console.WriteLine("n={0}, m={1}, res2={2}", n, m, res2);    //вывод вычислений
                Console.WriteLine("Нажмите 'Enter' чтобы продолжить");
                Console.ReadLine();
            }

            //конец 2 задачи

            //начало 3 задачи

            Console.WriteLine("Задача 3");
            res3 = m < n++;                                                 //преобразования
            Console.WriteLine("n={0}, m={1}, res3={2}", n, m, res3);        //вывод вычислений
            Console.WriteLine("Нажмите 'Enter' чтобы продолжить");
            Console.ReadLine();

            //конец 3 задачи

            //начало 4 задачи

            double x, res4;
            Console.WriteLine("Задача 4");
            Console.Write("Введите значение: x=");                          
            while (!double.TryParse(Console.ReadLine(), out x))                         //ввод переменной x
                Console.WriteLine("Ошибка ввода, введите целое или вещественное число");

                double uravnenie= (Math.Pow(Math.E, x) - Math.Sin(x));          //подкоренное уравнение
            double koren = 1.0 / 3.0;                                           //значение корня
            res4 = Math.Pow(uravnenie, koren);                                //вычисление кубического корня из уравнения
            Console.WriteLine("x={0}  res4={1}", x , res4);                  //вывод результата
            Console.WriteLine("Нажмите 'Enter' чтобы завершить программу");
            Console.ReadLine();

            //конец 4 задачи
            //Конец программы





        }
    }
}
