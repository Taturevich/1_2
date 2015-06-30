using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_Task2
{
    class Thing
    {
        string name; // название предмета
        double volume; // объем предмета
        Material material = new Material();

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Thing()
        {
            name = "Некий_предмет";
            volume = 0.06;
        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        public Thing(string name, double volume)
        {
            this.name = name;
            this.volume = volume;
        }

        /// <summary>
        /// Метод получения массы предмета
        /// </summary>
        /// <returns></returns>
        public double GetMass()
        {
            return volume * material.GetDensity;
        }

        /// <summary>
        /// Вывод сведений в csv формате
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return name+";"+material.GetName+";"+material.GetDensity+";"+volume+";"+GetMass()+";";
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Volume
        {
            get { return volume; }
            set { volume = value; }
        }
        public Material Material
        {
            get { return material; }
            set { material = value; }
        }
    }
}
