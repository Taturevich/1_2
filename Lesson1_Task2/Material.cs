using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_Task2
{
    class Material
    {
        public readonly string name; // название материала
        public readonly int density; // плотность материала

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Material()
        {
            name = "steel";
            density = 7850;
        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="name"></param>
        /// <param name="density"></param>
        public Material(string name, int density)
        {
            this.name = name;
            this.density = density;
        }

        /// <summary>
        /// Вывод информации в csv формате
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return name+";"+density+";\n";
        }

    }
}
