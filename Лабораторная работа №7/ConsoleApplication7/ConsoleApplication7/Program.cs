using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class LList                     //однонаправленный список
    {
        public string data;         //информационное поле
        public LList next;          //адресное поле (ссылка на следующий элемент)

        public LList()              //конструктор без параметров
        {
            data = "";
            next = null;
        }
        public LList(string d)      //конструктор с параметрами
        {
            data = d;
            next = null;
        }


        public void AddToEnd(string data)  //добавление элементов списка (в конец)
        {
            if (next == null)
            {
                next = new LList(data);
            }
            else
            {
                next.AddToEnd(data);
            }
        }

        public override string ToString()
        {
            return data + " ";
        }

    }

    class TwoWayList                // двунаправленный список
    {
        public int dataTwo;         //информационное поле
        public TwoWayList nextTwo,  //адрес следующего элемента
                          predTwo;  //адрес предыдущего элемента

        public TwoWayList()
        {
            dataTwo = 0;
            nextTwo = null;
            predTwo = null;
        }

        public TwoWayList(int d)
        {
            dataTwo = d;
            nextTwo = null;
            predTwo = null;
        }

        public void AddToEnd(int data)  //добавление элементов списка (в конец)
        {
            if (nextTwo == null)
            {
                nextTwo = new TwoWayList(data);
            }
            else
            {
                nextTwo.AddToEnd(data);
            }
        }

        public override string ToString()
        {
            return dataTwo + " ";
        }

    }

    class Tree//дерево
    {
        public string dataTree;     //данные в дереве
        public Tree left,           //адрес левого поддерева 
                    right;          //адрес правого поддерева

        public Tree()               //конструктор без параметров
        {
            dataTree = null;
            left = null;
            right = null;
        }
        public Tree(string d)       //конструктор с параметрами
        {
            dataTree = d;
            left = null;
            right = null;
        }

        public override string ToString()
        {
            return dataTree + " ";
        }

    }

    class Program
    {
        static void Menu()
        {
            bool ok=true;
            int MainAction;            
            do
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("\n1.Однонаправленный список");
                Console.WriteLine("2.Двунаправленный список");
                Console.WriteLine("3.Бинарное дерево");
                Console.WriteLine("4.Выход");

                while (!int.TryParse(Console.ReadLine(), out MainAction) || MainAction < 1 || MainAction > 4) //выбор пункта меню
                    Console.WriteLine("Ошибка ввода, выберите пункт меню (1-4)\n");
                Console.WriteLine();

                switch (MainAction)
                {
                    case 1:
                        LListMenu();
                        break;

                    case 2:
                        TwoListMenu();
                        break;

                    case 3:
                        TreeMenu();
                        break;

                    case 4:
                        Console.WriteLine("Нажмите Enter, чтобы выйти из программы...");
                        ok = false;
                        break;

                }
            } while (ok != false);
        }

        static void LListMenu()                    //Меню однонаправленного списка
        {
            string data = null;
            LList MyList = new LList(data);        //однонаправленный список
            bool ok = true;                        //переменная для выхода
            int action;                            //переменная для выбора пункта меню

            MyList = VvodElem();  //ввод элементов списка
            
            do
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("\n1.Добавить в список элемент после элемента с заданным информационным полем");
                Console.WriteLine("2.Вывести список на экран");
                Console.WriteLine("3.Назад");

                while (!int.TryParse(Console.ReadLine(), out action) || action < 1 || action > 3)    //выбор пункта меню
                    Console.WriteLine("Ошибка ввода, выберите пункт меню (1-3)\n");
                Console.WriteLine();
                switch (action)
                {
                    case 1:
                           MyList = AddToList(MyList);  //добавление элемента
                           break;

                    case 2:
                           ShowList(MyList);            //вывод списка на экран
                           Console.WriteLine();
                           break;

                    case 3:
                           Console.Clear();
                           ok = false;                  //возвращение назад
                           break;
                }

            } while (ok != false);
        }

        static void TwoListMenu()                       //меню двунаправленного списка
        {
            bool ok=true;
            int action;
            int data = 0;
            TwoWayList MyList = new TwoWayList(data);

            MyList = VvodElemTwoList();

            do
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("\n1.Удалить из списка все элементы с четными информационными полями");
                Console.WriteLine("2.Вывести список на экран");
                Console.WriteLine("3.Назад");

                while (!int.TryParse(Console.ReadLine(), out action) || action < 1 || action > 3)    //выбор пункта меню
                    Console.WriteLine("Ошибка ввода, выберите пункт меню (1-3)\n");
                Console.WriteLine();
                switch (action)
                {
                    case 1:
                        MyList = DeleteEven(MyList);
                        break;

                    case 2:
                        ShowList2(MyList);            //вывод списка на экран
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.Clear();
                        ok = false;                  //возвращение назад
                        break;
                }

            } while (ok != false);

        }

        static void TreeMenu()                       //меню дерева
        {
            bool ok = true;
            string dataTree=null;
            char d;
            Tree myTree = new Tree(dataTree);           
            int l=0;
            int length;
            int count = 0;

            Console.WriteLine("Введите сколько элементов вы хотите добавить в дерево");
            while (!int.TryParse(Console.ReadLine(), out length) || length < 1)
                Console.WriteLine("Ошибка ввода. Введите целое число больше 0");

            string[] masString = new string[length];                                            //объявление массива строк 

            Console.WriteLine("Введите данные:");
            myTree = IdealTree(length, myTree);                                                 //ввод данных в дерево

            
                        Console.WriteLine("Введите символ с которого вы хотите начать отсчет");
                        while (!char.TryParse(Console.ReadLine(), out d))                       //выбор пункта меню
                            Console.WriteLine("Ошибка ввода, введите 1 симовол\n");

                        Console.WriteLine("Идеальное дерево:");
                        FindCount(myTree,ref count, d);                                         //нахождение кол-ва элементов после заданного символа
                        ShowTree(myTree, 0);                                                    //вывод дерева

                        Console.WriteLine("\nКол-во элементов после заданного символа = " + count);
                        count = 0;     
                               
                        Console.WriteLine("\nДерево поиска:");
                        
                        myTree =IdealInSearch(myTree, null, ref masString, ref count);          //преобразование в идеальное дерево
                        ShowTree(myTree, 0);                                                       //вывод дерева

        }

        static LList MakePoint (string data)              //создание элемента однонаправленного списка
        {
            LList Elem = new LList(data);
            return Elem;
        }

        static TwoWayList MakePointTwo (int dataTwo)      //создание элемента двунаправленного списка
        {
            TwoWayList Elem = new TwoWayList(dataTwo);
            return Elem;
        }

        static Tree MakePointTree(string dataTree)        //создание элемента бинарного дерева
        {
            Tree p = new Tree(dataTree);
            return p;
        }

        static LList AddToList(LList MyList)         //однонаправленный список, добавление элемента
        {
            string name = "";
            string elem;

            if (MyList != null)                     //если список не пустой
            {
                Console.WriteLine("Введите информационное поле, после которого необходимо добавить элемент");
                name = Console.ReadLine();
            }
            Console.WriteLine("Введите значение добавляемого элемента:");
            elem = Console.ReadLine();          //ввод значения     
            LList NewElem = MakePoint(elem);    //добавляемый элемент
            if (MyList == null)                    //если список пустой
            {
                MyList = NewElem;
                return MyList;
            }
            
            LList SuppPer = MyList;                                             //переменная для прохода по списку
            
            while (SuppPer != null && SuppPer.data != name)   //идем по списку до элемента который надо найти
            {
                SuppPer = SuppPer.next;                                          //присваиваем переменной значение следующего элемента
            }
            if (SuppPer == null)                                                 //если переменная не нашлась
            {
                Console.WriteLine("\nТакого элемента в списке нет");
                Console.WriteLine();
                
                return MyList;
            }
            
            NewElem.next = SuppPer.next;                                         //внесение нового элемента в список
            SuppPer.next = NewElem;
            return MyList;
        }

        static TwoWayList DeleteEven (TwoWayList MyList)    //двунаправленный список, удаление четных информационных полей
        {                                                   //смысл функции в перезаписи списка без четных информационных полей

            if (MyList == null)                             //проверка на пустой список
            {
                Console.WriteLine("Список пуст.");
                return null;
            }
            TwoWayList SuppPer = MyList;                          //переменная для прохода по списку
            TwoWayList PerPred = SuppPer.predTwo;                 //предыдущий элемент

            while (SuppPer != null && PerPred == null)            //проверка 1 элемента в списке
            {
                if (SuppPer.dataTwo % 2 != 0)                     //если нечетное, то
                {
                    PerPred = MakePointTwo(SuppPer.dataTwo);      //присваивает значение 1 элемента
                }
                SuppPer = SuppPer.nextTwo;                        //переход переменной на следующий элемент списка
            }

            while (SuppPer != null)                               //пока переменная не дошла до конца списка
            {
                if (SuppPer.dataTwo %2 != 0)                      //если информационное поле четное,то
                {
                    TwoWayList k = PerPred;                       //присваивает значение предыдущего элемента                    
                    TwoWayList l = MakePointTwo(SuppPer.dataTwo); //создание и присвоение элемента со значением элемента в вспомогательной переменной
                    PerPred = l;                                  //переменная предыдущего элемента присваивает значение 2-го элемента (который находится в вспомогательной переменной)
                    PerPred.predTwo = k;                          //присваивается значение предыдущему элементу нынешнего списка
                    PerPred.predTwo.nextTwo = PerPred;            //сбор списка
                    PerPred.nextTwo = null;                       //след.элемент равен нулю
                }
                SuppPer = SuppPer.nextTwo;                        //в вспомогательную переменную записывается следующий элемент списка
            }

            if (PerPred != null)                                  //если есть предыдущее значение
                while (PerPred.predTwo != null)
                {
                    PerPred = PerPred.predTwo;
                }

            MyList = PerPred;

            return MyList;

        }

        static LList VvodElem()    //однонаправленный список, ввод элементов списка пользователем
        {
            int length;
            string data;
            Console.WriteLine("Введите сколько элементов вы хотите добавить в список");
            while (!int.TryParse(Console.ReadLine(), out length) || length < 1)
                Console.WriteLine("Ошибка ввода. Введите целое число больше 0");

            Console.WriteLine("Введите элементы списка");
            data = Console.ReadLine();
            LList MyLList = new LList(data);         //ввод первого элемента списка

            for (int i = 0; i < length - 1; i++)
            {
                data = Console.ReadLine();
                MyLList.AddToEnd(data);              //ввод остальных элементов списка
            }
            return MyLList;
        }

        static TwoWayList VvodElemTwoList()    //двунаправленный список, ввод элементов списка пользователем
        {
            int length;
            int dataTwo;
            Console.WriteLine("Введите сколько элементов вы хотите добавить в список");
            while (!int.TryParse(Console.ReadLine(), out length) || length < 1)
                Console.WriteLine("Ошибка ввода. Введите целое число больше 0");

            Console.WriteLine("Введите элементы списка");
            while (!int.TryParse(Console.ReadLine(), out dataTwo))
                Console.WriteLine("Ошибка ввода. Введите целое число.");

            TwoWayList myLList = new TwoWayList(dataTwo);         //ввод первого элемента списка

            for (int i = 0; i < length - 1; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out dataTwo))
                    Console.WriteLine("Ошибка ввода. Введите целое число.");
                myLList.AddToEnd(dataTwo);              //ввод остальных элементов списка
            }
            return myLList;
        }

        static Tree IdealTree(int length, Tree myTree)      //ввод элементов идеального бинарного дерева
        {
            Tree r;
            int nl, nr;
            string dataTree;
           
            if (length == 0)
            { myTree = null;
                return myTree; 
            }
            nl = length / 2;
            nr = length - nl - 1;            
            dataTree = Console.ReadLine();
            r = new Tree(dataTree);
            r.left = IdealTree(nl, r.left);         //ввод левого узла
            r.right = IdealTree(nr, r.right);       //ввод правого узла
            myTree = r;                             //присвоение исходному списку введенных значений
            return myTree;
        }

        static Tree Add(Tree myTree, string dataTree, string[] masString)       //добавление элемента в дерево поиска
        {
            Tree p = myTree;                                    //корень узла
            Tree r = null;
            bool ok = false;                                    //переменная для проверки существования элемента в дереве
            while (p != null && !ok)
            {
                r = p;
                int i = -1;
                i = Array.IndexOf(masString, dataTree);
                if (dataTree == p.dataTree || i != -1)          //если данные равны, или закончились поля
                    ok = true;
                else
                if (dataTree.Length > p.dataTree.Length)        //если длина информационного поля больше чем длина корня
                    p = p.left;                                 //пойти влево
                else
                    p = p.right;                                //пойти вправо
            }
            if (ok)
                return p;
            Tree NewPoint = new Tree(dataTree);                 //новый элемент списка с данными информацинного поля
            if (dataTree.Length > r.dataTree.Length)            //если длина информационного поля больше чем длина 
                r.right = NewPoint;      
            else r.left = NewPoint;
            return NewPoint;
        }


        static Tree IdealInSearch(Tree myTree, Tree HelpTree, ref string[] masString, ref int i)//дерево поиска
        {
            if (myTree != null)
            {
                if (HelpTree == null)                                           //если HelpTree - пустой
                {                                                               //HelpTree - вспомогательное дерево для переноса данных
                    HelpTree = MakePointTree(myTree.dataTree);                  //переносим первый элемент списка
                    masString[i] = myTree.dataTree;                             //строковый массив со значениями информационных полей дерева
                    i++;                                                        //переход на следующий элемент массива
                    IdealInSearch(myTree.left, HelpTree, ref masString, ref i);
                    IdealInSearch(myTree.right, HelpTree, ref masString, ref i);   //обход дерева сверху-вниз
                    return HelpTree;
                }
                else
                {
                    HelpTree = Add(HelpTree, myTree.dataTree, masString);
                    masString[i] = myTree.dataTree;
                    i++;
                    IdealInSearch(myTree.left, HelpTree, ref masString, ref i);
                    IdealInSearch(myTree.right, HelpTree, ref masString, ref i);          //обход сверху-вниз
                    return HelpTree;
                }
            }
            else                                                   
                    return null;                                        //возвращает значение при достижении последнего узла
        }


        static void FindCount(Tree myTree, ref int count, char d)    //обход дерева + поиск кол-ва элементов
        {
            if (myTree != null)
            {
                FindCount(myTree.left,ref count,d);                 //обход дерева     

                if (myTree.dataTree[0]==d)                          //сравниваем первый элемент информацонного поля
                {
                    count++;                                        //добавляем к кол-ву
                }               
                FindCount(myTree.right,ref count, d);               //обход дерева
            }
        }




        static void ShowList(LList MyList)             //вывод однонаправленного списка
        {
            //проверка наличия элементов в списке
            if (MyList == null)
            {
                Console.WriteLine("Список пуст.");
                return;
            }
            LList p = MyList;

            while (p != null)
            {
                Console.Write(p);
                p = p.next;//переход к следующему элементу
            }
            
        }

        static void ShowList2(TwoWayList MyList)        //вывод двунаправленного списка
        {
            
            if (MyList == null)                         //проверка на пустой список
            {
                Console.WriteLine("Список пуст.");
                return;
            }
            TwoWayList p = MyList;
            while (p != null)
            {
                Console.Write(p);
                p = p.nextTwo;                          //переход к следующему элементу
            }
            Console.WriteLine();
        }

        static void ShowTree(Tree myTree, int l)        //вывод бинарного дерева
        {
            if (myTree != null)
            {
                ShowTree(myTree.left, l + 4);

                for (int i = 0; i < l; i++)
                    Console.Write("  ");

                Console.WriteLine(myTree.dataTree);
                ShowTree(myTree.right, l + 4);
            }
        }      


        static void Main(string[] args)
        {
            Menu();
            Console.ReadLine();

        }
    }
}
