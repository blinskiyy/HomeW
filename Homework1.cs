using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homew1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Решко Владислав
            //Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).
            //В результате вся информация выводится в одну строчку:
            //а) используя склеивание;
            //б) используя форматированный вывод;
            //в) используя вывод со знаком $.


            Console.WriteLine("Пожалуйста, заполните анкету.");

            Console.WriteLine("Имя:");
            int aka = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Фамилия:");
            int bar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Возраст:");
            int cat = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Рост:");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Вес:");
            int eah = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" " + aka + " " + bar + ": " + cat + " лет, " + day + " см., " + eah + " кг.");
            Console.WriteLine($" {aka} {bar}: {cat} лет, {day} см., {eah} кг.");
            Console.WriteLine(" {0} {1}: {2} лет, {3} см., {4} кг.", aka, bar, cat, day, eah);


        }
    }
}
