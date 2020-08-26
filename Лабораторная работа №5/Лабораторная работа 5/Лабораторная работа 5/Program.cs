using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_5
{

    class Program
    {
        static int KolvoElem()          //длина массива
        {
            int length;
            Console.WriteLine("Введите длину массива");
            while (!int.TryParse(Console.ReadLine(), out length) || length < 1) //ввод длины массива
                Console.WriteLine("Ошибка ввода, введите целое число больше 0");

            return length;

        }

        static int KolvoElem(int lengthStroka)      //кол-во строк в двумерном массиве
        {
            Console.WriteLine("Введите кол-во строк:");
            while (!int.TryParse(Console.ReadLine(), out lengthStroka) || lengthStroka < 1)
                Console.WriteLine("Ошибка ввода, введите целое число больше 0");
            return lengthStroka;
        }
        static int KolvoElemStolb(int lengthStolb)  //кол-во столбцов в двумерном массиве
        {
            Console.WriteLine("Введите кол-во столбцов:");
            while (!int.TryParse(Console.ReadLine(), out lengthStolb) || lengthStolb < 1)
                Console.WriteLine("Ошибка ввода, введите целое число больше 0");
            return lengthStolb;
        }

        static void VivodMas(int[] mas)
        {
            int i;
            if (mas.Length == 0)    //сообщение о пустом массиве
            {
                Console.WriteLine("Массив пуст");
            }
            else
            {
                Console.WriteLine();
                Console.Write("Массив: ");
                for (i = 0; i < mas.Length; i++)
                    Console.Write("{0} ", mas[i]); //вывод массива
            }
        }
        static void VivodMas(int lengthStroka, int lengthStolb, int[,] DoubleMas)
        {
            int i, j;

            for (i = 0; i < lengthStroka; i++)
            { if (DoubleMas[0, 0] == 0)
                {
                    Console.WriteLine("Массив пуст");
                    break;
                }

                for (j = 0; j < lengthStolb; j++)
                {
                    Console.Write(DoubleMas[i, j] + " "); //вывод массива         
                }
                Console.WriteLine();
            }
        }
        static void VivodMas2 (int lengthStroka, int lengthStolb2, int[,] DoubleMas2)
        {
         
            for (int i = 0; i < lengthStroka; i++)
            {
                if (DoubleMas2[0,0] == 0)
                {
                    Console.WriteLine("Массив еще не был изменен");
                    break;
                }
                for (int j = 0; j < lengthStolb2; j++)
                {
                    Console.Write(" {0}", DoubleMas2[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void VivodRaggedMas(int[][]RaggedMas)
        {
           if (RaggedMas.GetLength(0)==0)
                Console.WriteLine("Массив пуст");
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



        static void VvodMas(int length, int[] mas)      //заполнение массива(ввод с клавиатуры)

        {
            Console.WriteLine("Введите значения элементов массива:");
            int i;
            for (i = 0; i < length; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out mas[i]))
                    Console.WriteLine("Ошибка ввода, введите целое число");
            }
        }
        static void VvodMas(int lengthStroka, int lengthStolb, int[,] DoubleMas)      //заполнение двумерного массива(ввод с клавиатуры)
        {
            Console.WriteLine("Введите значения элементов массива:");
            int i, j;
            for (i = 0; i < lengthStroka; i++)
            {
                for (j = 0; j < lengthStolb; j++)
                {
                    while (!int.TryParse(Console.ReadLine(), out DoubleMas[i, j]))
                        Console.WriteLine("Ошибка ввода, введите целое число");
                }
            }
        }

        static int[][] VvodRaggedMas(int lengthStroka, int lengthStolb)
        {
            
            int [][]RaggedMas = new int[lengthStroka][];
            for (int i = 0; i < lengthStroka; i++)
            {
                lengthStolb = KolvoElemStolb(lengthStolb);
                RaggedMas[i] = new int[lengthStolb];
                Console.WriteLine("Введите значения элементов в данных столбцах:");
                for (int j = 0; j < lengthStolb; j++)
                {
                    while (!int.TryParse(Console.ReadLine(), out RaggedMas[i][j]))
                        Console.WriteLine("Ошибка ввода, введите целое число");
                }

            }
            return RaggedMas;
        }

        static void RandomVvodMas(int length, int[] mas)        //заполнение массива(ввод с помощью ДСЧ)
        {
            int i;
            Random rand = new Random();
            {
                for (i = 0; i < length; i++)
                {
                    mas[i] = rand.Next(-100, 100);
                }
            }
        }

        static void RandomVvodMas(int lengthStroka, int lengthStolb, int[,] DoubleMas) //заполнение двумерного массива(ввод с помощью ДСЧ)
        {
            int i, j;
            Random rand = new Random();
            for (i = 0; i < lengthStroka; i++)
            {
                for (j = 0; j < lengthStolb; j++)
                {
                    DoubleMas[i, j] = rand.Next(1, 10);
                }
            }
        }

        static int[][] RandomVvodRaggedMas(int lengthStroka,int lengthStolb)
        {
            Random rand = new Random();

            int[][] RaggedMas = new int[lengthStroka][];
            for (int i = 0; i < lengthStroka; i++)
            {
                lengthStolb = KolvoElemStolb(lengthStolb);
                RaggedMas[i] = new int[lengthStolb];
                for (int j = 0; j < lengthStolb; j++)
                {
                    RaggedMas[i][j] = rand.Next(1, 10);
                }

            }
            return RaggedMas;
        }
      
        public static int[,] AddColoms (int lengthStroka, int lengthStolb, ref int lengthStolb2, int[,]DoubleMas)   //добавление столбцов после четных столбцов
        {
            int i, j, LengthCount = 0;
            Random random = new Random(); 

            for (i = 0; i < 1; i++)      //высчитываем кол-во нечетных столбцов
            {
                for (j = 0; j < lengthStolb; j++)
                {
                    if (j % 2 == 0)
                        LengthCount++;
                }               
            }
            Console.WriteLine("Кол-во четных столбцов: {0}",LengthCount);

            lengthStolb2 = lengthStolb + LengthCount;                   //длина исходного массива + длина для новых столбцов
            int[,] DoubleMas2 = new int[lengthStroka, lengthStolb2];    //массив для добавления столбцов
            int k = 0;                                                    //счетчик столбцов исходного массива

            for (i = 0; i < lengthStroka; i++)
            {
                for (j = 0; j < lengthStolb2; j++)
                {
                    if (k % 2 == 0)                           //если столбец четный,то
                    {
                        DoubleMas2[i, j] = DoubleMas[i, k];             //вставка исходного столбца                
                        k++;                                            //переход на следующий столбец исходного массива
                        j++;                                            //переход на новый столбец
                        
                        DoubleMas2[i, j] = random.Next(1, 10);          //формирование элементов для нового столбца                                         
                    }
                    else
                    {
                        DoubleMas2[i,j] = DoubleMas[i,k];               //если столбец нечетный, присваиваются значения из исходного массива
                        k++;                                            //переход на следующий столбец исходного массива
                    }                   
                }
                k = 0;                                         //обнуление счетчика столбцов исходного массива
            }
            return DoubleMas2;
        }
       

        static int[][] AddStringsInRagArray(int[][] RaggedMas,int lengthStroka, int lengthStolb)//Добавить строки в рваный массив
        {
            int K, i, j, N;
            Random rand = new Random();

            Console.WriteLine("Введите кол-во добавляемых строк:");
            while (!int.TryParse(Console.ReadLine(), out K) || K < 1) //ввод кол-ва строк исходного рваного массива
                Console.WriteLine("Ошибка ввода, введите целое число больше 0");
            
            Console.WriteLine("С какой строки начать добавление (введите номер)?");
            while (!int.TryParse(Console.ReadLine(), out N) || N < 0 || N > lengthStroka)
                Console.WriteLine("Ошибка ввода, введите N входящее в рамки массива");

            int[][] RaggedMas2 = new int[K][]; //создание 2 массива для добавления K строк

            //цикл для строк с новой длиной   
           
            Console.WriteLine("Введите кол-во столбцов:");
            for (i = 0; i < K; i++) //ввод значений рваного массива(случайным образом)
            {
                while (!int.TryParse(Console.ReadLine(), out lengthStolb) || lengthStolb < 1
                ) //ввод кол-ва столбцов исходного рваного массива
                    Console.Write("\nОшибка ввода");

                RaggedMas2[i] = new int[lengthStolb]; //длина столбцов

                for (j = 0; j < lengthStolb; j++)
                {
                    RaggedMas2[i][j] = rand.Next(0, 10);
                }

            }

            Console.WriteLine();
            Console.WriteLine("Добавленные строки:");
            for (i = 0; i < K; i++) //вывод массива
            {
                for (j = 0; j < RaggedMas2[i].Length; j++)
                    Console.Write("{0} ", RaggedMas2[i][j]);

                Console.WriteLine();
            }


            int[][] ChangedMas = new int[RaggedMas.Length + RaggedMas2.Length][];  //объявление третьего массива
            for (i = 0; i < ChangedMas.Length; i++)    //перебор элементов до конца 3 массива
            {
                int[] add;                          //объявление одномерного массива для добавления строк
                if (i < N) add = RaggedMas[i];      //если индекс строки меньше номера N, то присвоить строку исходного массива
                else
                {
                    if (i < N + RaggedMas2.Length)  //если индекс строки меньше номера N+добавленные строки,то
                        add = RaggedMas2[i - N];    
                    else
                        add = RaggedMas[i - RaggedMas2.Length];
                }
                ChangedMas[i] = add;   //перенос строки в 3 массив
            }
           
            return ChangedMas;
        }

        static void VivodRaggedMas2(int [][] ChangedMas)
        {
            int i,j;
            
            {
                Console.WriteLine();
                if (ChangedMas.GetLength(0) == 0)
                    Console.WriteLine("Массив еще не был изменен");
                else
                {


                    Console.WriteLine("Массив:");
                    for (i = 0; i < ChangedMas.GetLength(0); i++) //вывод массива
                    {
                        for (j = 0; j < ChangedMas[i].Length; j++)
                            Console.Write("{0} ", ChangedMas[i][j]);

                        Console.WriteLine();
                    }
                }
            }

        }
        



        static void Main(string[] args)
        {
            int choiceArray, choiceOneMas, choiceInMas,choiceDoubleMas,choiceRaggedMas;
            int i;
ArrayVibor: Console.WriteLine("1. Работа с одномерными массивами");
            Console.WriteLine("2. Работа с двумерными массивами");
            Console.WriteLine("3. Работа с рваными массивами");
            Console.WriteLine("4. Выход");
            while (!int.TryParse(Console.ReadLine(), out choiceArray) || choiceArray < 1 || choiceArray > 4) // выбор пункта меню
                Console.WriteLine("Ошибка ввода, выберите какой-либо из пунктов меню (1-4).");
            switch (choiceArray)
            {
                case 1:                 //одномерный массив
                    int length = 0;
                    int[] mas = new int[length]; // одномерный массив
            OneMas: Console.WriteLine();
                    Console.WriteLine("1. Создать массив");
                    Console.WriteLine("2. Напечатать массив");
                    Console.WriteLine("3. Удалить N элементов начиная с номера K");
                    Console.WriteLine("4. Назад");
                    while (!int.TryParse(Console.ReadLine(), out choiceOneMas) || choiceOneMas < 1 || choiceOneMas > 4) // выбор пункта меню
                        Console.WriteLine("Ошибка ввода, выберите какой-либо из пунктов меню (1-4).");
                    switch (choiceOneMas)
                    {
                        case 1:
                            length = KolvoElem();
                            Array.Resize(ref mas, length);
                            Console.WriteLine("1. Создать массив вручную");
                            Console.WriteLine("2. Создать массив с помощью ДСЧ");
                            Console.WriteLine("3. Назад");
                            while (!int.TryParse(Console.ReadLine(), out choiceInMas) || choiceInMas < 1 || choiceInMas > 3) // выбор пункта меню
                                Console.WriteLine("Ошибка ввода, выберите какой-либо из пунктов меню (1-4).");
                            switch (choiceInMas)
                            {
                                case 1:
                                    VvodMas(length, mas);   //ввод массива с клавиатуры
                                    goto OneMas;


                                case 2:
                                    RandomVvodMas(length, mas);   //ввод массива с помощью ДСЧ
                                    goto OneMas;
                                    

                                case 3:
                                    goto OneMas;    //возвращение назад в меню

                            }
                            break;

                        case 2:
                            VivodMas(mas);
                            goto OneMas;
                        case 3:
                            int K, N;
                            if (mas.Length == 0)
                            {
                                Console.WriteLine("Массив пуст");
                                goto OneMas;
                            }
                            Console.WriteLine("Выберите, сколько элементов массива необходимо удалить");
                            while (!int.TryParse(Console.ReadLine(), out N) || N < 1 || N > mas.Length)
                                Console.WriteLine("Ошибка ввода, выберите кол-во элементов, входящее в рамки данного массива");
                            Console.WriteLine("Выберите с какой позиции нужно удалять данные элементы(счет элементов идет с 0)");
                            while (!int.TryParse(Console.ReadLine(), out K) || K < 0 || K > mas.Length-1)
                                Console.WriteLine("Ошибка ввода, выберите позицию, входящюю в рамки данного массива");

                            if (K>mas.Length-N)
                            {
                                Console.WriteLine("Ошибка ввода, нельзя удалить больше элементов чем находится с данной позиции");
                            }
                            else
                            { for (i = K; i < mas.Length; i++)
                            {                                
                                if (i == mas.Length - N)
                                        Array.Resize(ref mas, mas.Length - N);                  //удаление элементов k с n позиции                                                  
                                else
                                {                                    
                                        mas[i] = mas[i + N];                                   
                                }                                
                            }}                           
                            goto OneMas;


                        case 4:
                            goto ArrayVibor;                                                               
                    }
                    break;

                case 2:                 //двумерный массив
                    int lengthStroka=0;
                    int lengthStolb=0;
                    int lengthStolb2 = 1;                 
                    lengthStroka = KolvoElem(lengthStroka);
                    lengthStolb = KolvoElemStolb(lengthStolb);
                                      
                    int [,] DoubleMas = new int[lengthStroka, lengthStolb]; // двумерный массив (матрица)
                    int[,] DoubleMas2 = new int[lengthStroka,lengthStolb2]; // измененный двумерный массив(после добавления столбцов)(матрица)
         SecondMas: Console.WriteLine();
                    Console.WriteLine("1. Создать массив");
                    Console.WriteLine("2. Напечатать массив");
                    Console.WriteLine("3. Напечатать измененный массив(после добавления столбцов)");
                    Console.WriteLine("4. Добавить столбцы после каждого четного столбца матрицы");
                    Console.WriteLine("5. Назад(для изменения длины массива, вернитесь назад и снова выберите 2 пункт)");

                    while (!int.TryParse(Console.ReadLine(), out choiceDoubleMas) || choiceDoubleMas < 1 || choiceDoubleMas > 5)
                        Console.WriteLine("Ошибка ввода, выберите какой-либо из пунктов меню (1-5).");
                    switch(choiceDoubleMas)
                    {
                        case 1:                                                       
                            Console.WriteLine("1. Создать массив вручную");
                            Console.WriteLine("2. Создать массив с помощью ДСЧ");
                            Console.WriteLine("3. Назад");
                            while (!int.TryParse(Console.ReadLine(), out choiceInMas) || choiceInMas < 1 || choiceInMas > 3) // выбор пункта меню
                                Console.WriteLine("Ошибка ввода, выберите какой-либо из пунктов меню (1-3).");
                            switch (choiceInMas)
                            {
                                case 1:
                                    VvodMas(lengthStroka, lengthStolb, DoubleMas);
                                    goto SecondMas;
                                case 2:
                                    RandomVvodMas(lengthStroka, lengthStolb, DoubleMas);
                                    goto SecondMas;
                                case 3:                                   
                                    goto SecondMas;
                            }
                            break;
                        case 2:                          
                            VivodMas(lengthStroka, lengthStolb, DoubleMas);
                            goto SecondMas;
                        case 3:
                            VivodMas2(lengthStroka, lengthStolb2, DoubleMas2);
                            goto SecondMas;
                        case 4:
                            DoubleMas2=AddColoms(lengthStroka, lengthStolb, ref lengthStolb2, DoubleMas);
                            goto SecondMas;
                        case 5:
                            goto ArrayVibor;
                        
                    }
                    break;

                case 3:             //рваный массив                 
                    lengthStroka = 0;
                    lengthStolb = 0;
                    lengthStroka = KolvoElem(lengthStroka);
                    int[][] RaggedMas = new int[0][];   //исходный рваный массив                  
                    int[][] ChangedMas = new int[0][];  //исходный рваный массив с добавленными строками                                                                                         
                   
             Back:  Console.WriteLine();
                    Console.WriteLine("1. Создать массив");
                    Console.WriteLine("2. Напечатать массив");
                    Console.WriteLine("3. Напечатать измененный массив(после добавления строк)");
                    Console.WriteLine("4. Добавить K строк, начиная с номера N");
                    Console.WriteLine("5. Назад(для изменения длины массива, вернитесь назад и снова выберите 2 пункт)");
                    while (!int.TryParse(Console.ReadLine(), out choiceRaggedMas) || choiceRaggedMas < 1 || choiceRaggedMas > 5)
                        Console.WriteLine("Ошибка ввода, выберите какой-либо из пунктов меню (1-5).");
                    switch(choiceRaggedMas)
                    {
                        case 1:
                            Console.WriteLine("1. Создать массив вручную");
                            Console.WriteLine("2. Создать массив с помощью ДСЧ");
                            Console.WriteLine("3. Назад");
                            while (!int.TryParse(Console.ReadLine(), out choiceInMas) || choiceInMas < 1 || choiceInMas > 3) // выбор пункта меню
                                Console.WriteLine("Ошибка ввода, выберите какой-либо из пунктов меню (1-3).");
                            switch(choiceInMas)
                            {
                                case 1:
                                    RaggedMas=VvodRaggedMas(lengthStroka, lengthStolb);
                                    goto Back;

                                case 2:
                                    RaggedMas=RandomVvodRaggedMas(lengthStroka, lengthStolb);
                                    goto Back;

                                case 3:
                                    
                                    goto Back;
                            }
                            break;

                        case 2:
                            VivodRaggedMas(RaggedMas);
                            goto Back; 
                        case 3:
                            VivodRaggedMas2(ChangedMas);
                            goto Back;
                            
                        case 4:                                                      
                            ChangedMas=AddStringsInRagArray(RaggedMas, lengthStroka, lengthStolb);
                            goto Back;

                        case 5:
                            goto ArrayVibor;
                        

                    }
                    break;
            }
            Console.WriteLine("Нажмите Enter, чтобы выйти из программы...");
            Console.ReadLine();
        }
        
        
      }
                              
     }
 

