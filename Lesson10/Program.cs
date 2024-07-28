using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные угла");
            Console.Write("градусы ");
            int gradus = Convert.ToInt32(Console.ReadLine());
            Console.Write("минуты ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("секунды ");
            int sec = Convert.ToInt32(Console.ReadLine());

            Angle angle = new Angle(gradus, min, sec);
            double angleRadians = angle.ToRadians();
            Console.WriteLine("Значение угла в радианах {0}", angleRadians);
            Console.ReadKey();
        }
    }
}
