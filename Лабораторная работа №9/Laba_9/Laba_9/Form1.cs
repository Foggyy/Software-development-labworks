using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Laba_9
{
    public partial class Form1 : Form
    {
        List<Driver> Elements = new List<Driver>();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Открыть файл
        /// </summary>
        private void OpenFile()
        {
            string path = @"D:\Программирование\Лабораторная работа №9\Files";
            Stream Mystream = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((Mystream = openFileDialog1.OpenFile()) != null)
                {
                    StreamReader myReader = new StreamReader(Mystream);
                    string[] str;
                    int num = 0;
                    try
                    {
                        string[] str1 = myReader.ReadToEnd().Split('\n');
                        num = str1.Count();
                        dataGridView1.RowCount = num;

                        for (int i = 0; i < num; i++)
                        {
                            str = str1[i].Split('^');
                            for (int j = 0; j < dataGridView1.ColumnCount; j++)
                            {
                                try
                                {
                                    dataGridView1.Rows[i].Cells[j].Value = str[j];
                                }
                                catch
                                {

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        myReader.Close();
                    }
                }
            }



        }

        /// <summary>
        /// Сохранить файл
        /// </summary>
        private void SaveFile()
        {
            Stream Mystream;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((Mystream = saveFileDialog1.OpenFile()) != null)
                {
                    StreamWriter myStreamWriter = new StreamWriter(Mystream);
                    try
                    {
                        for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                        {
                            for (int j = 0; j < dataGridView1.ColumnCount; j++)
                            {
                                myStreamWriter.Write(dataGridView1.Rows[i].Cells[j].Value.ToString() + "^");
                            }
                            myStreamWriter.WriteLine();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        myStreamWriter.Close();
                    }
                    Mystream.Close();
                }
                

            }
        }

        /// <summary>
        /// Обновляем таблицу после выполнения действий
        /// </summary>
        private void DataGridRecreation()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < Elements.Count; i++)
            {
                dataGridView1.Rows.Insert(Elements.IndexOf(Elements[i]), Elements.IndexOf(Elements[i]), Elements[i].Name, Elements[i].SecondName, Elements[i].MiddleName,
                    Elements[i].BusCondition, Elements[i].BusNumber, Elements[i].RouteNumber);
            }
        }

       


        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AboutProgramtoolStripButton1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Ввод значений элемента списка
        /// </summary>
        /// <param name="Element"></param>
        private void InputElement( ref Driver Element)
        {
            Element.Name = textBoxName.Text;                                    //Имя
            Element.SecondName = textBoxSecondName.Text;                        //Фамилия
            Element.MiddleName = textBoxMiddleName.Text;                        //Отчество
            Element.BusCondition = textBoxBusCondition.Text;                    //Состояние автобуса (в парке, на маршруте)
            Element.BusNumber = Convert.ToInt32(textBoxBusNumber.Text);         //Номер автобуса
            Element.RouteNumber = Convert.ToInt32(textBoxPathNumber.Text);      //Номер маршрута            
        }

        /// <summary>
        /// Добавление в список
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                try
                {
                    Driver Element = new Driver();
                    InputElement(ref Element);                                                          //ввод значений элемента
                    Regex check = new Regex(@"^[А-Я]{1}[а-я]{1,50}$");                                  //проверка правильности ввода ФИО
                    Regex checkСondition = new Regex(@"^[В]{1}[ ]{1}[парке]{5}$");                      //проверка ввода состояния автобуса
                    Regex checkCondition2 = new Regex(@"^[На]{2}[ ]{1}[маршруте]{8}$");             
                    if (!(check.IsMatch(Element.Name)) || !(check.IsMatch(Element.SecondName)) ||
                        !(check.IsMatch(Element.MiddleName)))
                    {
                        MessageBox.Show("Ошибка ввода ФИО.\nПример правильного ввода: Алексей Сергеевич Болгов");
                        return;
                    }
                    //if (!(checkСondition.IsMatch(Element.BusCondition)) || !(checkCondition2.IsMatch(Element.BusCondition)))
                    //{
                    //    MessageBox.Show("Ошибка ввода состояния автобуса.\nВозможные состояния автобуса: В парке, На маршруте");
                    //    return;
                    //}
                    Elements.Add(Element);                                                              //добавление в конец списка
                    dataGridView1.Rows.Add(Elements.IndexOf(Element), Element.Name, Element.SecondName, //добавление в конец таблицы
                        Element.MiddleName,
                        Element.BusCondition, Element.BusNumber, Element.RouteNumber);
                    DataGridRecreation();                                                               //обновляем таблицу
                }
                catch (FormatException)
                {
                    MessageBox.Show("Введите целое число");
                }
            }

            if (comboBox1.SelectedIndex == 1)
            {
                try
                {
                    Driver Element = new Driver();
                    InputElement(ref Element);                                                          //ввод значений элемента
                    Regex check = new Regex(@"^[А-Я]{1}[а-я]{1,50}$");                                  //проверка правильности ввода ФИО
                    Regex checkСondition = new Regex(@"^[В]{1}[ ]{1}[парке]{5}$");                      //проверка ввода состояния автобуса
                    Regex checkCondition2 = new Regex(@"^[На]{2}[ ]{1}[маршруте]{8}$");
                    if (!(check.IsMatch(Element.Name)) || !(check.IsMatch(Element.SecondName)) ||
                        !(check.IsMatch(Element.MiddleName)))
                    {
                        MessageBox.Show("Ошибка ввода ФИО.\nПример правильного ввода: Алексей Сергеевич Болгов");
                        return;
                    }
                    //if (!(checkСondition.IsMatch(Element.BusCondition)) || !(checkCondition2.IsMatch(Element.BusCondition)))
                    //{
                    //    MessageBox.Show("Ошибка ввода состояния автобуса.\nВозможные состояния автобуса: В парке, На маршруте");
                    //    return;
                    //}
                    Elements.Insert(0, Element);                                                                    //добавление в начало списка
                    dataGridView1.Rows.Insert(Elements.IndexOf(Element), Elements.IndexOf(Element), Element.Name,   //добавление в начало таблицы
                        Element.SecondName, Element.MiddleName,
                        Element.BusCondition, Element.BusNumber, Element.RouteNumber);
                    DataGridRecreation();                                                                           //обновляем таблицу
                }
                catch (FormatException)
                {
                    MessageBox.Show("Введите целое число");
                }
            }
            if (comboBox1.SelectedIndex == 2)
            {
                try
                {
                    Driver Element = new Driver();
                    InputElement(ref Element);                                                          //ввод значений элемента
                    Regex check = new Regex(@"^[А-Я]{1}[а-я]{1,50}$");                                  //проверка правильности ввода ФИО
                    Regex checkСondition = new Regex(@"^[В]{1}[ ]{1}[парке]{5}$");                      //проверка ввода состояния автобуса
                    Regex checkCondition2 = new Regex(@"^[На]{2}[ ]{1}[маршруте]{8}$");
                    if (!(check.IsMatch(Element.Name)) || !(check.IsMatch(Element.SecondName)) ||
                        !(check.IsMatch(Element.MiddleName)))
                    {
                        MessageBox.Show("Ошибка ввода ФИО.\nПример правильного ввода: Алексей Сергеевич Болгов");
                        return;
                    }
                    //if (!(checkСondition.IsMatch(Element.BusCondition)) || !(checkCondition2.IsMatch(Element.BusCondition)))
                    //{
                    //    MessageBox.Show("Ошибка ввода состояния автобуса.\nВозможные состояния автобуса: В парке, На маршруте");
                    //    return;
                    //}
                    int position = Convert.ToInt32(textBoxPosition.Text);                                             //получаем номер введенной позиции
                    Elements.Insert(position, Element);                                                               //добавление в список на указанную позицию
                    dataGridView1.Rows.Insert(position, Elements.IndexOf(Element), Element.Name, Element.SecondName,  //добавление в таблицу на указанную позицию
                        Element.MiddleName,
                        Element.BusCondition, Element.BusNumber, Element.RouteNumber);
                    DataGridRecreation();                                                                             //обновляем таблицу
                }
                catch (FormatException)
                {
                    MessageBox.Show("Введите целое число");
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Позиции не существует");
                }
            }
            
                           
        }
        
        /// <summary>
        /// Удаление
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)        //удаление с заданного номера
            {
                int index;
                try
                {
                    index = Convert.ToInt32(textBoxDelete.Text);   //получаем введенный номер
                    dataGridView1.Rows.RemoveAt(index);            //удаляем строку с введенным номером их таблицы
                    Elements.RemoveAt(index);                      //удаляем элемент с полученным индексом из списка
                    DataGridRecreation();                          //обновляем таблицу
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Строки не существует");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Введите число");
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Список пуст");
                }
                

            }
            if (comboBox2.SelectedIndex == 1)       //удаление по фамилии
            {
                FindAndDeleteSecondName();
            }
            if (comboBox2.SelectedIndex == 2)       //удаление по номеру маршрута
            {
                FindAndDeleteRouteNumber();
            }
            if (comboBox2.SelectedIndex == 3)       //удаление по номеру автобуса
            {
                FindBusNumber();
            }
            
        }

        /// <summary>
        /// Удаление по фамилии
        /// </summary>
        private void FindAndDeleteSecondName()
        {
            try
            {
                int indx = Elements.FindIndex(FindSecondName);  //получаем индекс элемента
                Elements.RemoveAt(indx);                        //удаляем элемент с полученным индексом из списка
                dataGridView1.Rows.RemoveAt(indx);              //удаляем строку с полученным индексом их таблицы
                DataGridRecreation();                           //обновляем таблицу
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("В списке нет такой фамилии");
            }
        }

        /// <summary>
        /// Поиск наличия фамилии в списке
        /// </summary>
        /// <param name="Element"></param>
        /// <returns></returns>
        private bool FindSecondName(Driver Element)
        {


            if (Element.SecondName == textBoxDelete.Text)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        /// <summary>
        /// Удаление по номеру маршрута
        /// </summary>
        private void FindAndDeleteRouteNumber()
        {
            try
            {
                int indx = Elements.FindIndex(FindRouteNumber);  //получаем индекс элемента
                Elements.RemoveAt(indx);                         //удаляем элемент с полученным индексом из списка
                dataGridView1.Rows.RemoveAt(indx);               //удаляем строку с полученным индексом их таблицы
                DataGridRecreation();                            //обновляем таблицу
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("В списке нет такого маршрута");
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите число");
            }
        }

        /// <summary>
        /// Поиск наличия номера маршрута в списке
        /// </summary>
        /// <param name="Element"></param>
        /// <returns></returns>
        private bool FindRouteNumber(Driver Element)
        {


            if (Element.RouteNumber == Convert.ToInt32(textBoxDelete.Text))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// Удаление по номеру автобуса
        /// </summary>
        private void FindBusNumber()
        {
            try
            {
                int indx = Elements.FindIndex(FindBusNumber);  //получаем индекс элемента
                Elements.RemoveAt(indx);                       //удаляем элемент с полученным индексом из списка
                dataGridView1.Rows.RemoveAt(indx);             //удаляем строку с полученным индексом их таблицы
                DataGridRecreation();                          //обновляем таблицу
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("В списке нет такого номера автобуса");
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите число");
            }
        }

        /// <summary>
        /// Поиск наличия номера автобуса в списке
        /// </summary>
        /// <param name="Element"></param>
        /// <returns></returns>
        private bool FindBusNumber(Driver Element)
        {


            if (Element.BusNumber == Convert.ToInt32(textBoxDelete.Text))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void FindDriversInRoute()
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex == 2)
                textBoxPosition.Visible = true;
            else
            {
                textBoxPosition.Visible = false;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxDelete.Visible = true;
        }
    }
}
