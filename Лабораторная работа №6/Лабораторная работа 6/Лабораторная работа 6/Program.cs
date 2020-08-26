using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Лабораторная_работа_6
{
    class Program
    {
        static int Menu()
        {
            int choiceMenu = 0;
            Console.WriteLine("Выберите пункт меню:" +
                              "\n1.Создать массив" +
                              "\n2.Напечатать массив" +
                              "\n3.Удалить из рваного массива первую строку в которой есть не менее 3 цифр" +
                              "\n4.Назад");
            while (!int.TryParse(Console.ReadLine(), out choiceMenu) || choiceMenu < 1 || choiceMenu > 4) // выбор пункта меню
                Console.WriteLine("Ошибка ввода, выберите какой-либо из пунктов меню (1-4).");
            return choiceMenu;
        }

        static int ViborZadachi(int Zadacha)
        {
Console.WriteLine(@"Выберите какую задачу нужно выполнить:
1. Первая задача
2. Вторая задача
3. Выход из программы");
            while (!int.TryParse(Console.ReadLine(), out Zadacha) || Zadacha < 1 || Zadacha>3)
                Console.WriteLine("Ошибка ввода, выберите какой-либо из пунктов меню (1-3).");

            return Zadacha;
        }

        static int KolvoElem(int lengthStroka)      //кол-во строк в рваном массиве
        {
            Console.WriteLine("Введите кол-во строк в рваном массиве:");
            while (!int.TryParse(Console.ReadLine(), out lengthStroka) || lengthStroka < 1)
                Console.WriteLine("Ошибка ввода, введите целое число больше 0");
            return lengthStroka;
        }

        static int KolvoElemStolb(int lengthStolb)  //кол-во столбцов в рваном массиве
        {
            Console.WriteLine("Введите кол-во столбцов для строки:");
            while (!int.TryParse(Console.ReadLine(), out lengthStolb) || lengthStolb < 1)
                Console.WriteLine("Ошибка ввода, введите целое число больше 0");
            return lengthStolb;
        }

        static int ViborVvod()  //выбор способа формирования рваного массива
      {
          int choice=0;
          Console.WriteLine("Выберите способ создания массива:");
Console.WriteLine(@"1. Создать массив вручную;
2. Создать массив с помощью ДСЧ
3. Назад");

          while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3) // выбор пункта меню
              Console.WriteLine("Ошибка ввода, выберите какой-либо из пунктов меню (1-3).");

            return choice;
      }

        static char[][] VvodMas(int choice, int lengthStolb, int lengthStroka)
        {
            lengthStroka = KolvoElem(lengthStroka);
            char[][] RaggedMas = new char[lengthStroka][];

            if (choice == 1)
            {

                for (int i = 0; i < lengthStroka; i++)
                {
                    lengthStolb = KolvoElemStolb(lengthStolb);
                    RaggedMas[i] = new char[lengthStolb];
                    Console.WriteLine("Введите значения элементов в данных столбцах:");
                    for (int j = 0; j < lengthStolb; j++)
                    {
                        while (!char.TryParse(Console.ReadLine(), out RaggedMas[i][j]))
                            Console.WriteLine("Ошибка ввода, введите символ Юникода");
                    }

                }

            }
            else
            {
                Random rand = new Random();
                string str = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ0123456789" +
                             "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ[];',./{}:>?|*-+";
                
                for (int i = 0; i < RaggedMas.Length; i++)
                {
                    lengthStolb = KolvoElemStolb(lengthStolb);
                    RaggedMas[i] = new char[lengthStolb];

                    for (int j=0;j<lengthStolb;j++)
                        RaggedMas[i][j] = str[rand.Next(0, str.Length)];                 
                }
            }
            return RaggedMas;
        }

        static void VivodRaggedMas(char[][] RaggedMas)
        {
            if (RaggedMas.GetLength(0) == 0)
                Console.WriteLine("\nМассив пуст\n");
            else
            {
                Console.WriteLine("Массив:");
                for (int i = 0; i < RaggedMas.GetLength(0); i++)
                {
                    for (int j = 0; j < RaggedMas[i].Length; j++)
                    {
                        Console.Write(RaggedMas[i][j] + "  ");
                    }
                    Console.WriteLine();
                }
            }

        }

        //Удалить из рваного массива первую строку в которой есть не менее 3 цифр

        static char[][] DeleteStroka(char[][]RaggedMas)
        {
            bool check = false;
            int count=0,k=0,count1=0;
            
            if (RaggedMas.GetLength(0) == 0)
                Console.WriteLine("\nМассив пуст\n");
            
            else
            {
                char[][] DeleteMas = new char[RaggedMas.GetLength(0) - 1][]; //массив в который перенесутся строки

                for (int i = 0; i < RaggedMas.GetLength(0); i++)
                {

                    for (int j = 0; j < RaggedMas[i].Length; j++)
                    {

                        if (Char.IsDigit(RaggedMas[i][j]))         //проверка на символ цифры
                        {
                            if (check == false)
                                count++;            //счетчик для нахождения цифр в столбцах

                        }
                    }
                    if (count < 3) //пока не найдено 3 цифры, переписывает строку в новый массив
                    {
                        if(k== RaggedMas.GetLength(0)-1)
                            Console.WriteLine("\nВ массиве нету строк, которые содержат 3 цифры\n");
                        else
                        DeleteMas[k++] = RaggedMas[i];
                    }
                    else
                    {
                        check = true;
                    }

                    count = 0;


                }
                return DeleteMas;
            }
            return RaggedMas;
        }

        static int Menu2()
        {
            int choiceString;
            Console.WriteLine(@"1.Использовать готовую строку 
2.Ввести новую строку 
3.Назад");
            while (!int.TryParse(Console.ReadLine(), out choiceString) || choiceString < 1 || choiceString > 3) // выбор пункта меню
                Console.WriteLine("Ошибка ввода, выберите какой-либо из пунктов меню (1-3).");
            return choiceString;
        }

        static int MenuInMenu2()
        {
            int choiceInMenu;
            Console.WriteLine(@"1.Напечатать строку 
2.Удалить все предложения заканчивающиеся на '!'
3.Назад");
            while (!int.TryParse(Console.ReadLine(), out choiceInMenu) || choiceInMenu < 1 || choiceInMenu > 3) // выбор пункта меню
                Console.WriteLine("Ошибка ввода, выберите какой-либо из пунктов меню (1-3).");
            return choiceInMenu;
        }


        static string Stroka()
        {
            string str = "Здравствуйте! Это исходная строка для проверки работы функции. " +
                         "Как вы можете заметить, в этой строке используются знаки препинания, в данном случае - запятые. " +
                         "Это необходимо, чтобы проверить как работает функция! Вам понравилось?";
            return str;
        }

        static string VvodStroki()
        {
            string stroka;
            Console.WriteLine("Введите строку:");
            stroka = Console.ReadLine();
            return stroka;
        }

        static void VivodMasStrok(string str)
        {
            if (str == "")
                Console.WriteLine("Строка пуста");
            else
                Console.WriteLine(str);
        }

        static void VivodStroki(string stroka)
        {
            if (stroka=="")
                Console.WriteLine("Строка пуста");
            else
            Console.WriteLine(stroka);
        }

        static string UdalenieSetnences(string str)
        {
            str = Regex.Replace(str, "[^.?!]*!", String.Empty); //"[^.?!]*!" - шаблон
                                                                //[^.?!] - любой символ кроме .?!
            return str;
        }



        static void Main(string[] args)
        {
            char[][] RaggedMas = new char[0][];
            int choice, choiceMenu,choiceInMenu,Zadacha=0,lengthStroka=0,lengthStolb=0,choiceString;
            string str;
            string stroka;

   Zadanie: Zadacha = ViborZadachi(Zadacha);                             //выбор выполняемой задачи
            if (Zadacha == 1)
            {
          menu: choiceMenu = Menu();
                switch (choiceMenu)
                {
                    case 1:
                        choice = ViborVvod(); //выбор формирования массива
                        RaggedMas = VvodMas(choice, lengthStolb, lengthStroka); //формирование массива
                        goto menu;
                    case 2:
                        VivodRaggedMas(RaggedMas); //вывод массива
                        goto menu;
                    case 3:
                        RaggedMas = DeleteStroka(RaggedMas); //удаление строки
                        goto menu;
                    case 4:
                        goto Zadanie;      //выбор задачи                    
                }
                

            }
            else
            if (Zadacha==2)
            {
         menu2: choiceString=Menu2();
                if (choiceString == 1)          //готовая строка
                {
                    str = Stroka();
           MenuIn: choiceInMenu=MenuInMenu2();
                    switch (choiceInMenu)
                    {
                        case 1:
                            VivodMasStrok(str);
                            goto MenuIn;
                        case 2:
                            str=UdalenieSetnences(str);
                            goto MenuIn;
                        case 3:
                            goto menu2;
                    }
                }
                else if (choiceString==2)       //ввод строки
                {
                    stroka = VvodStroki();
             MenuIn: choiceInMenu = MenuInMenu2();
                    switch (choiceInMenu)
                    {
                        case 1:
                            VivodStroki(stroka);
                            goto MenuIn;
                        case 2:
                            stroka = UdalenieSetnences(stroka);
                            goto MenuIn;
                        case 3:
                            goto menu2;
                    }
                }
                else                            //назад
                {
                    goto Zadanie;
                }


            }
            else
            {
                Console.WriteLine("Нажмите Enter, чтобы выйти из программы...");
            }
            Console.ReadLine();

        }
    }
}
