using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Threading;

namespace Laba_8
{
    /// <summary>
    /// Объявление класса, для заполнения хэш-таблицы
    /// </summary>
    class Subject
    {
        /// <summary>
        /// Объявление переменных
        /// </summary>
        public string Name;
        public string group;
        public int rating;
        public int count=0;
        public string datarozhdenia;
        public Subject next;


        /// <summary>
        /// Вычисление Хэш-кода опредленного элемента, используется метод остатков от деления
        /// </summary>
        /// <param name="Table"></param>
        /// <returns></returns>
        public int HashFunc(Subject[] Table)
        {
            int key=0;
            char[] b = new char[Name.Length];
            for (int i = 0; i < Name.Length; i++)
                b[i] = Name[i];

            for (int i = 0; i < Name.Length; i++)
            {
                b[i] = Convert.ToChar(b[i]);
                key = b[i]+key;
            }
            return key % Table.Length;
        }



        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="r"></param>
        public Subject(Random rand)
        {
            
            string[] MasName = { "Василий", "Евгений", "Александр", "Пётр", "Анатолий", "Антон", "Дмитрий", "Владимир", "Никита", "Сергей", "Владимир", "Даниил", "Николай", "Глеб", "Степан", "Максим", "Владислав", "Ярослав", "Лев", "Денис", "Артём" };         //массив имен
            string[] MasSecondname = { "Петров", "Скоробогатько", "Туляев", "Ильин", "Троицкий", "Болгов", "Арсентьев", "Иванов", "Голубев", "Сабанцев", "Носов", "Арзамасов", "Власов", "Токмянин", "Эйстрих" };                                           //массив фамилий
            string[] MasThirdname = { "Сергеевич", "Алексеевич", "Тимурович", "Владимирович", "Андреевич", "Даниилович", "Васильевич", "Казимирович", "Евгеньевич", "Петрович", "Борисович" };                                                    //массив отчеств                                                                                                                                                  //генерация рейтинга
            string[] MasGroup = {"P-14", "P-15", "P-16", "A-17", "A-15", "A-16", "M-14", "M-15", "M-16","И-15","И-16","И-17","И-14","А-14","А-17"};
            
            Name = MasSecondname[rand.Next(0, MasSecondname.Length-1)] + " " +        //случайный выбор ФИО
                   MasName[rand.Next(0, MasName.Length-1)] + " " +
                   MasThirdname[rand.Next(0, MasThirdname.Length-1)];
            rating = rand.Next(1, 10);                                              //случайный выбор рейтинга
            group = MasGroup[rand.Next(0, MasGroup.Length-1)];                        //случайный выбор группы            

            next = null;
        }       


        /// <summary>
        /// Метод для добавления элементов в хэш-таблицу
        /// </summary>
        /// <param name="Table"></param>
        public void Dobavlenie(Subject[] Table)
        {
            int key;
            Subject Element = this;
            key = HashFunc(Table);

            Subject CheckElem = Table[key];
            if (CheckElem == null)
            {
                Table[key] = Element;
                return;
            }

            while (CheckElem.next != null)
                CheckElem = CheckElem.next;
            CheckElem.next = Element;
            count++;
        }

        /// <summary>
        /// Вывод элемента
        /// </summary>
        /// <returns></returns>
        public override string ToString()                         
        {
            
            return "ФИО:"+Name + "\nРейтинг: " + rating + "\nГруппа: " + group;
        }
    }


    /// <summary>
    /// Основной класс
    /// </summary>
    class Program
    {

        /// <summary>
        /// Главное меню
        /// </summary>
        static void Menu()
        {           
            int choice;
            bool ok = true;
            int Kollizii=0;
            Subject[] Table = new Subject[100];            
            Table = HashTable(Table);
            
            

            while (ok == true)
            {
                Console.WriteLine();
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1.Вывод таблицы");
                Console.WriteLine("2.Добавление");
                Console.WriteLine("3.Удаление");
                Console.WriteLine("4.Поиск элемента по ключу");
                Console.WriteLine("5.Подсчет количества коллизий");
                Console.WriteLine("6.Выход");
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice>6)
                    Console.WriteLine("Ошибка ввода. Введите целое число (1-5)");

                switch (choice)
                {
                    case 1:
                        ShowMas(Table);
                        break;
                    case 2:
                        Table=AddElement(Table);
                        break;
                    case 3:
                        DeleteElement(ref Table);
                        break;
                    case 4:
                        Poisk(Table);
                        break;
                    case 5:
                        for (int i =0;i<Table.Length;i++)
                        Kollizii=Table[i].count;
                        Console.WriteLine("Кол-во коллизий: ", + Kollizii);
                        break;
                    case 6:
                        Console.WriteLine("Нажмите Enter, чтобы выйти из программы...");
                        ok = false;
                        break;
                }
            }
            
        }

        /// <summary>
        /// Метод для создания Хэш-таблицы, выбор кол-ва элементов
        /// </summary>
        /// <returns></returns>
        static Subject[] HashTable(Subject[] Table)
        {
            Console.WriteLine("Укажите размер (кол-во элементов) хэш-таблицы: 1 - 40, 2 - 75, 3 - 90");
            int choice;
            int i;
                  
            Random rand = new Random();
            
            
            while(!int.TryParse(Console.ReadLine(), out choice) || choice<1 || choice>3)
                Console.WriteLine("Ошибка ввода, выберите пункт меню (1-4).");

            switch (choice)
            {
                case 1:
                   
                    for (i = 0; i < 40; i++)
                    {                                         
                        Subject Element = new Subject(rand);
                        Element.Dobavlenie(Table);
                        

                    }                    
                    break;

                case 2:
                                       
                    for (i = 0; i < 75; i++)
                    {
                        Subject Element = new Subject(rand);
                        Element.Dobavlenie(Table);
                    }
                    break;

                case 3:
                                       
                    for (i = 0; i < 90; i++)
                    {
                        Subject Element = new Subject(rand);
                        Element.Dobavlenie(Table);
                    }
                    break;
              
            }
            return Table;

        }

        /// <summary>
        /// Вывод хэш-таблицы
        /// </summary>
        /// <param name="Table"></param>
        static void ShowMas(Subject[] Table)
        {
            int count=0;
            int i;
            if (Table == null)
            {
                Console.WriteLine("Таблица пуста.");
                return;
            }            
            for (i = 0; i < Table.Length; i++)
            {
                Subject Element = Table[i];
                
                if (Element != null)
                {
                    while (Element != null)
                    {                        
                        Console.WriteLine("\nПозиция в массиве:"+Element.HashFunc(Table));
                        Console.WriteLine(Element);
                        Element = Element.next;
                        count++;
                    }
                }
                
            }
        }


        /// <summary>
        /// Дополнительное добавление элементов в таблицу, после ее создания
        /// </summary>
        /// <param name="Table"></param>
        /// <returns></returns>
        static Subject[] AddElement(Subject[] Table)
        {
            int key=0;
            int value;
            Random rand = new Random();
            Console.WriteLine("Сколько элементов вы хотите добавить?");
            
            while(!int.TryParse(Console.ReadLine(),out value)||value<1)
                Console.WriteLine("Ошибка ввода, введите целое значение больше 0");
            Console.Write("\nДобавленные элементы: \n");

            for (int i = 0; i < value; i++)
            {
                Subject Element = new Subject(rand);
                
                Console.WriteLine(Element);
                Element.Dobavlenie(Table);
                Console.WriteLine();
            }

            
            return Table;
        }


        /// <summary>
        /// Удаление элементов в созданной таблице
        /// </summary>
        /// <param name="Table"></param>
        /// <returns></returns>
        static void DeleteElement(ref Subject[] Table)
        {
            Console.WriteLine("Введите ФИО человека: ");
            string FIO = Console.ReadLine();
            Regex check = new Regex(@"[\d]");
            Match match = check.Match(FIO);
            while (match.Success)
            {
                Console.WriteLine("Ошибка ввода, обнаружен ввод запрещенных символов, попробуйте снова");
                FIO = Console.ReadLine();
                match = check.Match(FIO);
            }

            int HashElem;
            HashElem = HashCode(FIO, Table);
            Subject Element = Table[HashElem];
            Subject PreviousElem = Table[HashElem];

            if (Element == null)
            {
                Console.WriteLine("Человек не найден или ФИО введено неверно");
                return;

            }
            if (Element.Name == FIO)
            {               
                Table[HashElem] = null;
                return;
            }

            while (Element != null && Element.Name != FIO)
            {
                PreviousElem = Element; Element = Element.next;
                
            }

            if (Element == null)
                Console.WriteLine("Человек не найден или ФИО введено неверно");
            else
            {
                PreviousElem.next = Element.next; 
                
            }

            
        }

        /// <summary>
        /// Поиск элемента по ФИО
        /// </summary>
        /// <param name="Table"></param>
        static void Poisk(Subject[] Table) 
        {
            Console.WriteLine("Введите ФИО человека");
            string FIO = Console.ReadLine();

            int ElemHashCode = HashCode(FIO, Table);

            Subject Element = Table[ElemHashCode];

            if (Element == null)
            {
                Console.WriteLine("Человек не найден или ФИО введено неверно");
                return;
            }


            while (Element.next != null && Element.Name != FIO)
            {
                
                Element = Element.next;
                

            }

            if (Element == null)
                Console.WriteLine("Человек не найден или ФИО введено неверно");
            else if (Element.Name == FIO)
            {
                Console.WriteLine("\nЧеловек найден: ");
                Console.WriteLine(Element);
            }                
            else                
                Console.WriteLine("Человек не найден или ФИО введено неверно");
                
        }

        /// <summary>
        /// Считаем кол-во коллизий
        /// </summary>
        /// <param name="Table"></param>
        //static void Kolizii(Subject[] Table) 
        //{
        //    int count = 0;            
        //    for (int i = 0; i < Table.Length; i++)
        //    {
        //        if (Table[i] != null)
        //        {
        //            if (Table[i].next != null)
        //                count++;
        //        }
        //    }
        //    Console.WriteLine("\nКол-во коллизий = " + count);

        //}

        /// <summary>
        /// Еще один метод для вычисления хэш-кода, для удобства был перенесен и в основной класс
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Table"></param>
        /// <returns></returns>
        static int HashCode(string FIO, Subject[] Table)
        {
            int key = 0;
            char[] b = new char[FIO.Length];
            for (int i = 0; i < FIO.Length; i++)
                b[i] = FIO[i];

            for (int i = 0; i < FIO.Length; i++)
            {
                b[i] = Convert.ToChar(b[i]);
                key = b[i] + key;
            }
            return key % Table.Length;
        }



        /// <summary>
        /// Главная функция, вызывает главное меню
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Menu();
            Console.ReadLine();
        }

    }       
    
}
