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
            int i,max=-200,posl,zero=0;
            

            Random rand = new Random();            
            Console.WriteLine("Числовая последовательность: ");

            do
            {
                posl = rand.Next(-5, 5);                  //последовательность чисел
                if (posl > max)                               //поиск максимального элемента последовательности
                {
                    max = posl;
                }
                Console.WriteLine(" {0}", posl);

            } while (posl != 0);
  
            Console.WriteLine("\nМаксимальный элемент последовательности = {0}", max);
            Console.ReadLine();
        }

        }
}
 
