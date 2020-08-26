using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Program
    {
       
        /// <summary>
        /// Первая часть лабораторной работы
        /// </summary>
        static void FirstPart()
        {
            bool ok = true;
            int choice;
            double x1 = 0;
            double x2 = 0;

            while (ok != false)
            {

                
                Console.WriteLine("Часть 1.");
                Uravnenie SquareEquation = new Uravnenie();
                SquareEquation.Input();                                                 //ввод значений переменных
                SquareEquation.Show();                                                  //вывод значений переменных

                Console.WriteLine("_____________________________________________");
                Console.WriteLine("\nСтатическая функция:");
                Console.WriteLine("\nФормула квадратного уравнения: ax^2+bx+c=0");
                Console.WriteLine("Наше уравнение: {0}x^2 + {1}x + {2} = 0", SquareEquation.Var1, SquareEquation.Var2, SquareEquation.Var3);
                Uravnenie.EquationStatic(SquareEquation, ref x1, ref x2);                //нахождение корней уравнения (статическая функция)
                Console.WriteLine("_____________________________________________");

                Console.WriteLine("\nМетод класса:");
                Console.WriteLine("\nФормула квадратного уравнения: ax^2+bx+c=0");
                Console.WriteLine("Наше уравнение: {0}x^2 + {1}x + {2} = 0", SquareEquation.Var1, SquareEquation.Var2, SquareEquation.Var3);
                SquareEquation.Equation(ref x1, ref x2);                                //нахождение корней уравнения (метод класса)
                Console.WriteLine("_____________________________________________");

                Console.WriteLine("Кол-во созданных объектов: " + SquareEquation.CountObjects);
                Console.WriteLine("Выберите дальнейшее действие: 1 - Выполнить данную часть еще раз, 2 - Перейти ко второй части");
                while (!int.TryParse(Console.ReadLine(), out choice) || choice<1 || choice>2)
                    Console.WriteLine("Ошибка ввода, выберите 1 или 2 действие");

                if (choice == 1)
                {
                    Console.Clear();
                }
                else
                if (choice == 2)
                {
                    ok = false;
                    Console.Clear();
                    SecondPart(SquareEquation);
                }

            }
        }

        /// <summary>
        /// Выполнение второй части лабораторной работы
        /// </summary>
        /// <param name="SquareEquation"></param>
        static void SecondPart(Uravnenie SquareEquation)
        {
            bool ok = true;
            int choice;
            while (ok == true)
            {


                Console.WriteLine("Часть 2.\n");
                Console.WriteLine(
                    "Выберите действие: 1 - Использовать те же значения коэффициентов, 2 - Ввод новых значений");
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 2)
                    Console.WriteLine("Ошибка ввода, выберите 1 или 2 действие");
                if (choice == 1)
                {
                    SquareEquation.Show();
                }
                else if (choice == 2)
                {
                    SquareEquation = new Uravnenie();
                    SquareEquation.Input();
                    SquareEquation.Show();
                }

                UnarOperations(SquareEquation);             //Унарные операции
                TypecastingOperations(SquareEquation);      //Операции приведения типа
                BinaerOperations(SquareEquation);           //Бинарные операции

                Console.WriteLine("Выберите дальнейшее действие: 1 - Выполнить данную часть еще раз, 2 - Перейти к третьей части");
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 2)
                    Console.WriteLine("Ошибка ввода, выберите 1 или 2 действие");

                if (choice == 1)
                {
                    Console.Clear();
                }
                else
                if (choice == 2)
                {
                    ok = false;
                    Console.Clear();
                    ThirdPart();
                }
            }

        }

        /// <summary>
        /// Унарные операции
        /// </summary>
        /// <param name="SquareEquation"></param>
        static void UnarOperations(Uravnenie SquareEquation)
        {
            Console.WriteLine("_____________________________________________");
            Console.WriteLine("Унарные операции:\n");
            Console.WriteLine("Увеличиваем коэффициенты уравнения на 1");
            SquareEquation++;
            SquareEquation.Show();
            Console.WriteLine("\nУменьшаем коэффициенты уравнения на 1");
            SquareEquation--;
            SquareEquation.Show();
            Console.WriteLine("_____________________________________________");
        }

        /// <summary>
        /// Операции приведения типа
        /// </summary>
        /// <param name="SquareEquation"></param>
        static void TypecastingOperations(Uravnenie SquareEquation)
        {
            SquareEquation.TypeCastingCheck(SquareEquation);
        }


        /// <summary>
        /// Бинарные операции
        /// </summary>
        /// <param name="SquareEquation"></param>
        static void BinaerOperations(Uravnenie SquareEquation)
        {
            Uravnenie t1 = new Uravnenie(2, 6, -8);
            Uravnenie t2 = new Uravnenie(2, 6, -8);
            int check;
            bool result;

            Console.WriteLine("\n_____________________________________________");
            Console.WriteLine("Бинарные операции:\n");

            Console.WriteLine("Выберите действие: 1 - демонстрация бинарных операций с готовыми значениями коэффициентов, 2 - ввод своих значений");
            while (!int.TryParse(Console.ReadLine(), out check) || check < 1 || check > 2)
                Console.WriteLine("Ошибка ввода, выберите 1 или 2 действие");

            //Использование готовых значений
            if (check == 1)
            {
                Console.WriteLine("\nКоэффициенты первого уравнения:");
                t1.Show();
                Console.WriteLine("Коэффициенты второго уравнения");
                t2.Show();

                result = t1 == t2;                                        //Проверка через бинарную операцию ==
                Console.WriteLine("Уравнения равны: {0}", result);


                t1 = new Uravnenie(3, 9, 2);
                t2 = new Uravnenie(7, 1, 3);

                Console.WriteLine("\nКоэффициенты первого уравнения:");
                t1.Show();
                Console.WriteLine("Коэффициенты второго уравнения");
                t2.Show();

                result = t1 != t2;                                      //Проверка через бинарную операцию !=
                Console.WriteLine("Уравнения не равны: {0}", result);
            }

            //Ввод своих значений
            if (check == 2)
            {
                t1 = new Uravnenie();
                t2 = new Uravnenie();
                Console.WriteLine("Ввод значений 1-го уравнения:");
                t1.Input();
                Console.WriteLine("\nВвод значений 2-го уравнения:");
                t2.Input();

                Console.WriteLine("\nКоэффициенты первого уравнения:");
                t1.Show();
                Console.WriteLine("Коэффициенты второго уравнения");
                t2.Show();

                result = t1 == t2;                                      //Проверка через бинарную операцию ==
                Console.WriteLine("\nУравнения равны: {0}", result);

                result = t1 != t2;                                      //Проверка через бинарную операцию !=
                Console.WriteLine("Уравнения не равны: {0}", result);

            }
            Console.WriteLine("_____________________________________________");
        }


        /// <summary>
        /// Третья часть лабораторной работы
        /// </summary>
        static void ThirdPart()
        {
            
            int length;
            int choice;
            Console.WriteLine("Введите длину массива:");
            while(!int.TryParse(Console.ReadLine(), out length) || length<1)
                Console.WriteLine("Ошибка ввода, введите целое число больше 0");

            Console.WriteLine("Выберите способ заполнения массива: 1 - ввод с клавиатуры, 2 - c помощью ДСЧ ");
            while (!int.TryParse(Console.ReadLine(), out choice) || choice <1 || choice>2)
                Console.WriteLine("Ошибка ввода, введите целое число меньше 0");

            UravnenieArray EquationMas = new UravnenieArray();
            Uravnenie SuppElement = new Uravnenie();

            SuppElement.CountObjects = 0;                               //обнуляем счетчик кол-ва объектов
            if (choice == 1)
            {
                EquationMas = new UravnenieArray(length);               //формируем массив вручную
                
                
            }
            else if (choice == 2)
            {
                EquationMas = new UravnenieArray(SuppElement,length);   //формируем массив с помощью ДСЧ
                

            }
            EquationMas.Show();                                         //вывод массива
            int count = SuppElement.CountObjects;                       //находим кол-во созданных объектов в массиве
            Console.WriteLine("Кол-во созданных объектов: {0}",count);  
            EquationMas.FindMax();                                      //поиск уравнения с самым большим по абсолютному значению корнем
            
        }




        /// <summary>
        /// Основная функция
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
                   
            FirstPart();
                       
            Console.ReadLine();
        }
    }
}
