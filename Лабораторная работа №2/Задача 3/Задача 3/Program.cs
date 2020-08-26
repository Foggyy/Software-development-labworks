using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1,j=1;
            double x, P, chisl = 0, znam = 0;

            Console.WriteLine("Введите значение x");
            while(!double.TryParse(Console.ReadLine(), out x))      //значение x
                Console.WriteLine("Ошибка ввода, введите число");

            double proizvChisl = 1,proizvZnam = 1;              

            for (i=1;i<=63;i=(i*2)+1) ;
            {               
                proizvChisl = proizvChisl * (x - i);                            //произведение в числителе               
            }

            for (j=1;j<=64;j=j*2) ;
            {
                proizvZnam = proizvZnam*(x - j);                             //произведение в знаменателе        
            }

            P = proizvChisl / proizvZnam;                             //частное числителя и знаменателя
            Console.WriteLine("P = {0}",P);
            Console.ReadLine();

        }
    }
}
