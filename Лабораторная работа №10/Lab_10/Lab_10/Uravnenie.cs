using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{

    //использовать свойства в функции, значения должны быть больше 0
    //НЕ передавать объект Uravnenie в функции


    class Uravnenie
    {
        private double a;
        private double b;
        private double c;
        private static int count;


        /// <summary>
        /// Присваиваем значение переменной a
        /// </summary>
        public double Var1
        {
            get { return a; }
            set {   if (value > 0)
                    a = value;
                else
                    Console.WriteLine("Ошибка ввода, введите значение больше 0");


                }
        }

        /// <summary>
        /// Присваиваем значение переменной b
        /// </summary>
        public double Var2
        {
            get { return b; }
            set {
                if (value > 0)
                    b = value;
                else
                {
                    Console.WriteLine("Ошибка ввода, введите значение больше 0");                   
                }
                    
                    
            }
        }

        /// <summary>
        /// Присваиваем значение переменной c
        /// </summary>
        public double Var3
        {
            get { return c; }
            set {               
                    if (value > 0)
                        c = value;
                    else
                        Console.WriteLine("Ошибка ввода, введите значение больше 0");                                                  
                }
        }
     

        /// <summary>
        /// Подсчет кол-ва созданных объектов
        /// </summary>
        public int CountObjects
        {
            get { return count; }
            set { count = value; }
        }


        /// <summary>
        /// Коснтруктор без параметров
        /// </summary>
        public Uravnenie()
        {
            count++;
            a = 0;
            b = 0;
            c = 0;
        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="C"></param>
        public Uravnenie(double a, double b, double c)
        {
            count++;
            this.a = a;
            this.b = b;
            this.c = c;
        }
       
        /// <summary>
        /// Вывод переменных
        /// </summary>
        public void Show()
        {
            Console.WriteLine("Значения коэффициентов: a = {0} , b = {1} , c = {2}",a,b,c);
        }

        /// <summary>
        /// Метод для ввода коэффициентов
        /// </summary>
        /// <param name="SquareEquation"></param>
        public void Input()
        {
            //Ввод значений с клавиатуры

            Console.WriteLine("Введите значение коэффициента a:");
            do
            {
                try
                {
                    Var1 = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)                                       //проверка на ввод числа
                {
                    Console.WriteLine("Ошибка ввода, введите число");
                }
            } while (Var1<1);

            Console.WriteLine("Введите значение коэффициента b:");
            do
            {
                try
                {
                    Var2 = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка ввода, введите число");
                }
            } while (Var2 < 1);
            
            Console.WriteLine("Введите значение коэффициента c:");
            do
            {
                try
                {
                    Var3 = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка ввода, введите число");
                };
            } while (Var3 < 1);

        }

        /// <summary>
        /// Случайные значения коэффициентов
        /// </summary>
        /// <param name="SquareEquation"></param>
        public void InputRand()
        {
            Random rand = new Random();
            //Ввод коэффициентов
            do
            {
                Var1 = rand.Next(1, 100);
                Var2 = rand.Next(1, 100);
                Var3 = rand.Next(1, 100);
            } while (a==0 || b==0 || c==0);            
        }

        /// <summary>
        /// Метод класса для 1 части
        /// </summary>
        /// <param name="SquareEquation"></param>
        public void Equation(ref double x1, ref double x2)
        {
            double D;
            double sqrtD;
            x1 = 0;                        
            //Вычисляем дискриминант
            D = Math.Pow(b, 2) - 4 * a * c;

            //Находим единственный корень
            if (D == 0)
            {
                Console.WriteLine("\nДискриминант равен 0 \n");
                x1 = (b * -1) / (2 * a);
                Console.WriteLine("Корень уравнения = {0}", x1);
            }
            //Корней нет
            else if (D < 0)
            {
                Console.WriteLine("Дискриминант меньше 0, уравнение не имеет корней");
                x1 = 0;
            }
            //Находим корни уравнения
            else
            {
                //Корень дискриминанта
                sqrtD = Math.Sqrt(D);
                x1 = ((b * -1) - sqrtD) / (2 * a);
                x2 = ((b * -1) + sqrtD) / (2 * a);

                Console.WriteLine("\nПервый корень уравнения = {0}", x1);
                Console.WriteLine("Второй корень уравнения = {0}", x2);
            }
        }

        /// <summary>
        /// Статическая функция для 1 части
        /// </summary>
        /// <param name="SquareEquation"></param>
        /// <param name="x1"></param>
        /// <param name="x2"></param>
        public static void EquationStatic(Uravnenie SquareEquation, ref double x1, ref double x2)
        {
            double D;
            double sqrtD;
            double a, b, c;
            a = SquareEquation.a;
            b = SquareEquation.b;
            c = SquareEquation.c;
            
            //Вычисляем дискриминант
            D = Math.Pow(b, 2) - 4 * a * c;

            //Находим единственный корень
            if (D == 0)
            {
                Console.WriteLine("\nДискриминант равен 0 \n");
                x1 = (b * -1) / (2 * a);
                Console.WriteLine("Корень уравнения = {0}", x1);              
            }
            //Корней нет
            else if (D < 0)
            {
                Console.WriteLine("Дискриминант меньше 0, уравнение не имеет корней");
                x1 = 0;
            }
            //Находим корни уравнения
            else
            {
                //Корень дискриминанта
                sqrtD = Math.Sqrt(D);
                x1 = ((b * -1) - sqrtD) / (2 * a);
                x2 = ((b * -1) + sqrtD) / (2 * a);
                Console.WriteLine("\nПервый корень уравнения = {0}", x1);
                Console.WriteLine("Второй корень уравнения = {0}", x2);
            }
        }

        /// <summary>
        /// Неявное преобразование
        /// </summary>
        /// <param name="SquareEquation"></param>
        public static implicit operator double(Uravnenie SquareEquation)
        {
            double x1 = 0;
            double x2 = 0;
            SquareEquation.Equation(ref x1, ref x2);
            return x1;
        }

        /// <summary>
        /// Явное преобразование
        /// </summary>
        /// <param name = "SquareEquation" ></ param >
        public static explicit operator bool(Uravnenie SquareEquation)
        {
            bool result;
            double x1 = 0;
            double x2 = 0;
            SquareEquation.Equation(ref x1, ref x2);
            result = Convert.ToBoolean(x1);
            return result;
        }

        /// <summary>
        /// Метод для демонстрации операций приведения типа
        /// </summary>
        /// <param name="SquareEquation"></param>
        public void TypeCastingCheck(Uravnenie SquareEquation)
        {         
            Console.WriteLine("\n_____________________________________________");
            Console.WriteLine("Операции приведения типа:");
            bool result = (bool)SquareEquation;
            double x = SquareEquation;
            Console.WriteLine("double(неявная), Реузльтат = {0}", x);
            Console.WriteLine("bool(явная), Результат = {0}", result);
            Console.WriteLine("_______________________________________________");
        }


        /// <summary>
        /// Перегруженная операция ==
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public static bool operator == (Uravnenie t1, Uravnenie t2)
        {
            bool result = false;
            if (t1.Var1 == t2.Var1 && t1.Var2 == t2.Var2 && t1.Var3 == t2.Var3)
                result = true;

                return result;
        }

        /// <summary>
        /// Перегруженная операция !=
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public static bool operator !=(Uravnenie t1, Uravnenie t2)
        {
            bool result = false;
            if (t1.Var1 != t2.Var1 && t1.Var2 != t2.Var2 || t1.Var3 != t2.Var3)
            {
                result = true;
            }
            return result;
        }

       

        /// <summary>
        /// Перегруженная унарная операция, увеличивает коэффициенты на 1
        /// </summary>
        /// <param name="SquareEquation"></param>
        public static Uravnenie operator ++(Uravnenie SquareEquation)
        {
            SquareEquation.a++;
            SquareEquation.b++;
            SquareEquation.c++;

            return SquareEquation;
        }

        /// <summary>
        /// Перегруженная унарная операция, уменьшает коэффициенты на 1
        /// </summary>
        /// <param name="SquareEquation"></param>
        public static Uravnenie operator --(Uravnenie SquareEquation)
        {
            SquareEquation.a--;
            SquareEquation.b--;
            SquareEquation.c--;
            return SquareEquation;
        }

        /// <summary>
        /// Вывод коэффициентов
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Значения коэффициентов: a = " + a + ", b = " + b + ", c = " + c;
        }
    }
}
