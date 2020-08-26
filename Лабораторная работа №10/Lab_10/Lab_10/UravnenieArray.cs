using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_10
{
    class UravnenieArray
    {
        private Uravnenie[] EquationMas;
        private int size;
        private int count;

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public UravnenieArray()
        {
            count++;
            EquationMas = new Uravnenie[0];
            size = 0;
        }

        /// <summary>
        /// Конструктор для ввода значений с клавиатуры
        /// </summary>
        /// <param name="size"></param>
        public UravnenieArray(int size)
        {
            count++;
            this.size = size;
            EquationMas = new Uravnenie[size];
            for (int i = 0; i < size; i++)
            {
                Uravnenie Element = new Uravnenie();
                Element.Input();
                EquationMas[i] = Element;
            }


        }

        /// <summary>
        /// Конструктор с ДСЧ
        /// </summary>
        /// <param name="Element"></param>
        /// <param name="size"></param>
        public UravnenieArray(Uravnenie Element, int size)
        {
            count++;
            this.size = size;
            
            EquationMas = new Uravnenie[size];

            for (int i = 0; i < size; i++)
            {
                Element = new Uravnenie();
                Thread.Sleep(20);
                Element.InputRand();
                EquationMas[i] = Element;
            }


        }

        /// <summary>
        /// Индексатор массива
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Uravnenie this[int index]
        {
            set { EquationMas[index] = value; }
            get { return EquationMas[index]; }
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
        /// Получение размера массива
        /// </summary>
        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <summary>
        /// Вывод массива
        /// </summary>
        public void Show()
        {
            int i;
            Console.WriteLine("Массив:");

            for (i = 0; i < size; i++)
            {
                Console.WriteLine(EquationMas[i].ToString());
            }
            

        }

        /// <summary>
        /// Поиск уравнения с самым большим по абсолютному значению корнем
        /// </summary>
        public void FindMax()
        {
            double x = 0;
            double x1 = Double.MinValue;
            double x2 = Double.MinValue;
            Uravnenie Supp = new Uravnenie();
            Console.WriteLine("\n\nНаходим уравнение с самым большим по абсолютному значению корнем:");
            for (int i = 0; i < size; i++)
            {
                Console.Write("\n{0}) ",i+1);
                Console.Write("Уравнение: {0}x^2 + {1}x + {2} = 0 ", EquationMas[i].Var1, EquationMas[i].Var2, EquationMas[i].Var3);

                EquationMas[i].Equation(ref x1, ref x2);     //находим корни уравнения
                if (x1 > x)
                {
                    Supp = EquationMas[i];
                    x = x1;
                }
                else if (x2>x)
                {
                    Supp = EquationMas[i];
                    x = x2;
                }
            }

            if (x == 0)
                Console.WriteLine("\nКорней с абсолютным значением нет ни в одном из уравнений");
            else
            {
                Console.Write("\nУравнение с самым большим по абсолютному значению корнем:");
                Console.WriteLine("{0}x^2 + {1}x + {2} = 0", Supp.Var1, Supp.Var2, Supp.Var3);
                Console.WriteLine("Значение корня: {0}", x);
            }            
        }


        
    }
}
