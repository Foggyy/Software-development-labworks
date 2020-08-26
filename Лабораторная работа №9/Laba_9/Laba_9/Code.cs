using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_9
{
    [Serializable]
    class Driver
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string MiddleName { get; set; }
        public string BusCondition { get; set; }
        public int RouteNumber { get; set; }
        public int BusNumber { get; set; }
        [NonSerialized]
        public int count;
        
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="SecondName"></param>
        /// <param name="MiddleName"></param>
        /// <param name="BusCondition"></param>
        /// <param name="RouteNumber"></param>
        /// <param name="BusNumber"></param>
        public Driver(string Name, string SecondName, string MiddleName, string BusCondition, int RouteNumber, int BusNumber)
        {
            this.Name = Name;
            this.SecondName = SecondName;
            this.MiddleName = MiddleName;
            this.BusCondition = BusCondition;
            this.RouteNumber = RouteNumber;
            this.BusNumber = BusNumber;
        }

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Driver()
        {
            Name = "";
            SecondName = "";
            MiddleName = "";
            BusCondition = "";
            RouteNumber = 0;
            BusNumber = 0;
        }

        /// <summary>
        /// Вывод
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "\nФамилия: " + SecondName + "\nИмя: " + Name + "\nОтчество: " + MiddleName + "\nСостояние автобуса: " + BusCondition +
                   "\nНомер маршрута:" + RouteNumber + "\nНомер автобуса: " + BusNumber;
        }
        
    }


}
