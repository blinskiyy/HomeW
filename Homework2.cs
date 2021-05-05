using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homew2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Решко Владислав
            //Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h);
            //где m — масса тела в килограммах, h — рост в метрах.


            Console.WriteLine("Вес");
            double m = Double.Parse(Console.ReadLine());

            Console.WriteLine("Рост");
            double h = Double.Parse(Console.ReadLine());

            double i = m / (h * h);

            Console.WriteLine("ИМТ:" + i.ToString());

        }
    }
}
