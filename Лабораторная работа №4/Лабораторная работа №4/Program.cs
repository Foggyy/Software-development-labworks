using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Лабораторная_работа__4
{
    class Program
    {
        static int KolvoElem()          //длина массива
        {
            int length;
            Console.WriteLine("Введите длину массива");
            while (!int.TryParse(Console.ReadLine(), out length) || length == 0 || length < 0) //ввод длины массива
                Console.WriteLine("Ошибка ввода, введите целое число больше 0");

            return length;

        }

        static int ViborVvoda()        //выбор заполнения массива
        {
            int vibor;
            choice:
            Console.WriteLine("Выберите способ формирования массива: 1 - ввод с клавиатуры, 2 - случайным образом");
            while (!int.TryParse(Console.ReadLine(), out vibor) || vibor > 2 || vibor < 1
            ) //выбор способа формирования массива
                Console.WriteLine("Ошибка ввода, выберите 1 или 2 способ");
            if (vibor > 2 | vibor <= 0)
            {
                goto choice;
            }
            return vibor;

        }
        static void VvodMas(int length, int[] mas)      //заполнение массива

        {
            Console.WriteLine("Введите значения элементов массива:");
            int i;
            for (i = 0; i < length; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out mas[i]))
                    Console.WriteLine("Ошибка ввода, введите целое число");
            }
            Console.Write("Массив: ");
            for (i = 0; i < length; i++)
                Console.Write("{0} ", mas[i]); //вывод массива


        }

        static void RandomVvodMas(int length, int[] mas)
        {
            int i;
            Random rand = new Random();
            {
                Console.Write("Массив: ");
                for (i = 0; i < length; i++)
                {
                    mas[i] = rand.Next(-100, 100);
                    Console.Write("{0} ", mas[i]); //вывод массива
                }
                Console.WriteLine("");

            }
        }

        static int Select()
        {
            int v;
            Console.WriteLine("\nВыберите желаемое действие");
            Console.WriteLine("1-Удаление элемента с заданным номером");
            Console.WriteLine("2-Добавление K элементов в начало массива");
            Console.WriteLine("3-Переставить положительные элементы в начало массива, а отрицательные в конец");
            Console.WriteLine("4-Поиск первого четного элемента");
            Console.WriteLine("5-Сортировка методом простого включения");
            Console.WriteLine("6-Выход");
            while (!int.TryParse(Console.ReadLine(), out v) || v > 6 || v < 1) //проверка на ввод
                Console.WriteLine("Ошибка ввода, введите число от 1 до 6");
            return v;
        }



        static void DeleteElem(ref int length, ref int[] mas) //метод для удаления элемента с заданным номером
        {
            int elem, i;
            if (mas.Length == 0)
            {
                Console.WriteLine("Массив пуст");
                
            }
            else
            {
                Console.WriteLine("Введите номер элемента, который необходимо удалить(счет элементов начинается с 0)");
                while (!int.TryParse(Console.ReadLine(), out elem) || elem >= length || elem < 0) //проверка на ввод
                    Console.WriteLine("Ошибка ввода, введите элемент, входящий в рамки данного массива");
                for (i = 0; i < length; i++)
                {
                    if (i == length - 1)
                    {
                        Array.Resize(ref mas, length - 1);
                    }
                    else
                    {
                        if (i >= elem)
                        {
                            mas[i] = mas[i + 1];
                        }
                    }
                }
                
                for (i = 0; i < mas.Length; i++)
                    Console.Write("{0} ", mas[i]);
            }           
        }


        static int VvodK()      //ввод кол-ва элементов k
        {
            int k;
            Console.WriteLine("Введите K элементов");
            while (!int.TryParse(Console.ReadLine(), out k))
                Console.WriteLine("Ошибка ввода, введите целое число");
            Console.WriteLine("Кол-во элементов: {0}", k);
            return k;
        }
        static int IncludeViborVvoda()      //выбор как вводить элементы k
        {
            int vibor;
            choice:
            Console.WriteLine("Введите добавляемые элементы: 1- ввод с клавиатуры, 2 - случайным образом");
            while (!int.TryParse(Console.ReadLine(), out vibor) || vibor > 2 || vibor < 1
            ) //выбор способа формирования массива
                Console.WriteLine("Ошибка ввода, выберите 1 или 2 способ");
            if (vibor > 2 | vibor <= 0)
            {
                goto choice;
            }
            return vibor;
        }

        static void Include(ref int length, ref int[] mas) //добавление K элементов в начало массива
        {
            int k, i, temp, j;
            k = VvodK();
            Array.Resize(ref mas, length + k);

            switch (IncludeViborVvoda())
            {
                case 1:


                    Console.WriteLine("Введите значения элементов массива:");

                    for (int count = 0; count < k; count++)
                    {
                        temp = mas[length + k - 1];                               //сдвиг вправо
                        for (j = length + k - 1; j > 0; j--) mas[j] = mas[j - 1];
                        mas[0] = temp;
                    }
                    for (i = 0; i < k; i++)
                        while (!int.TryParse(Console.ReadLine(), out mas[i]))
                            Console.WriteLine("Ошибка ввода, введите целое число");

                    Console.Write("\nМассив: ");
                    for (i = 0; i < length + k; i++)
                    {
                        Console.Write("{0} ", mas[i]);
                    }


                    break;
                case 2:

                    Random rand = new Random();


                    for (int count = 0; count < k; count++)
                    {
                        temp = mas[length + k - 1];                               //сдвиг вправо
                        for (j = length + k - 1; j > 0; j--) mas[j] = mas[j - 1];
                        mas[0] = temp;
                    }
                    Console.Write("Случайные добавляемые элементы: ");
                    for (i = 0; i < k; i++) //случайные элементы k записываются в массив
                    {
                        mas[i] = rand.Next(-100, 100);
                        Console.Write("{0} ", mas[i]);
                    }

                    Console.Write("\nМассив: ");
                    for (i = 0; i < length + k; i++)
                    {
                        Console.Write("{0} ", mas[i]);
                    }
                    break;

            }

        }


        static int[] Perestanovka(int length, int[] mas) //перестановка(положительные элементы в начало, отрицательные в конец)
        {
            int i, j, t;
            Console.Write("Массив: ");
            for (i = 0; i < (length/2)+1; i++)
            {
                for (j = 0; j < length - 1; j++)
                {
                    if (mas[j + 1] < 0)
                    {
                        mas[j] = mas[j];
                    }
                    else
                    {
                        if (mas[j] < 0)
                        {
                            t = mas[j];
                            mas[j] = mas[j + 1];
                            mas[j + 1] = t;
                        }
                    }
                }
                Console.Write("{0} ", mas[i]);
            }
            return mas;
        }

        static void Poisk(int length, int[] mas)  //поиск первого четного элемента
        {
            int i, chet, count = 1;
            for (i = 0; i < length; i++)        //цикл для поиска в масиве
            {
                if (mas[i] % 2 == 0)            // если элемент четный, то вывести его и завершить цикл
                {
                    chet = mas[i];
                    Console.WriteLine("Первый четный элемент: {0}", chet);
                    Console.WriteLine("Кол-во сравнений: {0}", count);
                    break;
                }
                else
                {
                    if (mas[i] % 2 > 0)         // если элемент нечетный, пропустить его
                    {
                        mas[i] = mas[i];
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("Четных элементов не найдено");
                    }
                }
            }
        }
        static int[] Sort(int[] mas, int length)       //сортировка массива простым включением
        {
            int i, j, elem;
            for (i = 1; i < length; i++)
            {
                elem = mas[i]; //элемент для вставки
                j = i - 1;
                while (j >= 0 && elem < mas[j]) //поиск подходящего места
                {
                    mas[j + 1] = mas[j]; //сдвиг вправо
                    j--;
                }
                mas[j + 1] = elem; //вставка элемента
            }
            foreach (int x in mas) Console.Write(x + " ");      //перебор элементов массива и вывод
            Console.WriteLine();
            return mas;

        }

        static void Main(string[] args)
        {

            int length = KolvoElem();
            int choice = ViborVvoda();
            int[] mas = new int[length];
            if (choice == 1) VvodMas(length, mas);
            else
                RandomVvodMas(length, mas);

            selection: int v = Select();
            switch (v)
            {
                case 1:
                    DeleteElem(ref length, ref mas);     //удаление элемента с заданным номером
                    goto selection;

                case 2:
                    Include(ref length, ref mas);        //добавление K элементов в начало массива
                    goto selection;
                case 3:
                    Perestanovka(length, mas);           //перестановка(положительные элементы в начало, отрицательные в конец)
                    goto selection;
                case 4:
                    Poisk(length, mas);                 //поиск первого четного элемента  
                    goto selection;
                case 5:
                    Sort(mas, length);                   //сортировка массива простым включением
                    goto selection;
                case 6:
                    break;


            }


            Console.WriteLine("\nНажмите Enter, чтобы выйти из программы...");
            Console.ReadLine();
        }

    }
}



