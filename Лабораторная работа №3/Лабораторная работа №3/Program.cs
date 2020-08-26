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
            double x, y, shag,shag2,shag3,shag4, SN=0, SE=0,SN1=0,SE1=0;
            double b = 1, a = 0.1;                      //максимальное и минимальное значение x
            int n, k = 10;
            float E = 0.0001F,e;
            shag = (b - a) / k;                         //шаг x

            for (x = a; x <=b; x = x + shag)            //цикл для изменения x в заданном диапозоне
            {

                for (n = 0; n<=40; n++)                 //цикл подсчета суммы для n=40
                {
                    shag2 = Math.Pow(-1, n) * Math.Pow(x, 2 * n + 1) / (2 * n + 1);
                    
                    /*double chisl = Math.Pow(-1, n) * (Math.Pow(x, 2 * n + 1));
                    double znam = (2 * n + 1);
                    double shag2 = chisl / znam;*/
                    
                    SN=SN+shag2;  //n
                    /* SN1 = x - (Math.Pow(x, 3)/3) + Math.Pow(-1, (n + 1)) * (Math.Pow(x, 2 * (n + 1)) / (2 * (n + 1)));*/ //n+1
                }
                
                e = 0;
                do        //|Sn+1-Sn|<E
                {
                    shag3 = Math.Pow(-1, e) * Math.Pow(x, 2 * e + 1) / (2 * e + 1);
                    SE = SE + shag3;
                    e++;
                    shag3 = Math.Pow(-1, e) * Math.Pow(x, 2 * e + 1) / (2 * e + 1);                    
                    SE1 = SE1 + shag3;// сумма с заданной точностью
                    

                } while (Math.Abs(SE1 - SE) < E);

                y = Math.Atan(x);                                                               //точное значение функции
                Console.WriteLine("X = {0} SN = {1}  SE = {2}  Y = {3}",x,SN,SE,y);
                SN = 0; // возвращение к исходному значению
                SE = 0;
                SE1 = 0;
            }
            Console.ReadLine();



        }
     }
}

            