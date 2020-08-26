using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 100, b=0.001;                                        //присвоение значений переменным 
            
            double FirstBrackets,SecondBrackets,Znam,Result,Diff;
             
            FirstBrackets = Math.Pow(a + b, 3);                             //раскрытие первых скобок
            SecondBrackets = Math.Pow(a, 3) + 3 * Math.Pow(a, 2) * b;       //раскрытие вторых скобок
            Znam = 3 * a * Math.Pow(b, 2) + Math.Pow(b, 2);                 //вычисление знаменателя
            Diff = FirstBrackets - SecondBrackets;                          //разность 1 и 2 скобки(числителя)
            Result = Diff / Znam;                                           //деление числителя на знаменатель(конечный результат)
            
            Console.WriteLine("Первые скобки: {0}", FirstBrackets);
            Console.WriteLine("Вторые скобки: {0}", SecondBrackets);
            Console.WriteLine("Знаменатель: {0}",Znam);
            Console.WriteLine("Разность в числителе: {0}",Diff);
            Console.WriteLine("Результат вычислений: {0}", Result);
            Console.WriteLine("Нажмите 'Enter' чтобы продолжить...");
            Console.ReadLine();


            float aF = 100, bF = 0.001F;                                        //присвоение значений переменным 

            float FirstBracketsF, SecondBracketsF, ZnamF, ResultF, DiffF;

            FirstBracketsF = (float)Math.Pow(aF + bF, 3);                             //раскрытие первых скобок (в типе float)
            SecondBracketsF = (float)Math.Pow(aF, 3) + 3 * (float)Math.Pow(aF, 2) * bF;       //раскрытие вторых скобок (в типе float)
            ZnamF = 3 * aF * (float)Math.Pow(bF, 2) + (float)Math.Pow(bF, 2);                 //вычисление знаменателя  (в типе float)
            DiffF = FirstBracketsF - SecondBracketsF;                          //разность 1 и 2 скобки(числителя)
            ResultF = DiffF / ZnamF;                                           //деление числителя на знаменатель(конечный результат)

            Console.WriteLine("Первые скобки: {0}", FirstBracketsF);
            Console.WriteLine("Вторые скобки: {0}", SecondBracketsF);
            Console.WriteLine("Знаменатель: {0}", ZnamF);
            Console.WriteLine("Разность в числителе: {0}", DiffF);
            Console.WriteLine("Результат вычислений: {0}", ResultF);
            Console.WriteLine("Нажмите 'Enter' для выхода из программы...");
            Console.ReadLine();


        }
    }
}
