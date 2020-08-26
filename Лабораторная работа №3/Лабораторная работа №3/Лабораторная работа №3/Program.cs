using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, Y, shag,shag2,SN=0, SE=0,SE1=0;
            double b = 1, a = 0.1;                      //максимальное и минимальное значение x
            int n, k = 10;
            double E = 0.0001,e=0;

            shag = (b - a) / k;                         //шаг x
            
            for (x = a; x <=b; x = x + shag)            //цикл для изменения x в заданном диапазоне
            {
                Y = Math.Atan(x);                       //точное значение функции
                for (n = 0; n<=40; n++)                 //цикл подсчета суммы для n=40
                {
                    shag2 = Math.Pow(-1, n) * Math.Pow(x, 2 * n + 1) / (2 * n + 1);
                    SN+=shag2;
                }

                
                  while (Math.Abs(Math.Pow(-1, e) * Math.Pow(x, 2 * e + 1) / (2 * e + 1)) > E)
                {    
                    SE =SE+ Math.Pow(-1, e) * Math.Pow(x, 2 * e + 1) / (2 * e + 1);                // сумма с заданной точностью  
                    //SE1 =SE1+ Math.Pow(-1, e + 1) * Math.Pow(x, 2 * (e + 1) + 1) / (2 * (e + 1) + 1);
                    e = e + 1;
                }                                       //|Sn+1-Sn|<E

                                                                               
                Console.WriteLine("X = {0} SN = {1}  SE = {2}  Y = {3}",x,SN,SE,Y);
                SN = 0; // возвращение к исходному значению
                SE = 0;
                SE1 = 0;
                e = 0;

            }
            Console.ReadLine();



        }
     }
}

            