using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thing wire = new Thing("wire",0.03);
            Console.WriteLine(wire);
            //Заменяем материал
            Material copper = new Material("copper",8500);
            wire.Material=copper;
            Console.WriteLine("Новая масса предмета:"+wire.GetMass());
            Console.ReadKey();
        }
    }
}
