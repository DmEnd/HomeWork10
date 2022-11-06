using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.Угол задан с помощью целочисленных значений gradus -градусов, min - угловых минут, sec - угловых секунд.Реализовать 
            * класс, в котором указанные значения представлены в виде свойств.Для свойств предусмотреть проверку корректности данных. 
            *Класс должен содержать конструктор для установки начальных значений, а также метод ToRadians для перевода угла в радианы. 
            *Создать объект на основе разработанного класса. Осуществить использование объекта в программе.
            */
            Console.Write("Введите градусы угла = ");
            int gradus = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите минуты угла = ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите секунды угла = ");
            int sec = Convert.ToInt32(Console.ReadLine());

            //int gradus = 360;
            //int min = -70;
            //int sec = -70;

            Angle angle = new Angle(gradus, min, sec);

            Console.WriteLine("Угол {0}° {1}\" {2}\' в радианах равен {3}", angle.Gradus, angle.Min, angle.Sec, angle.ToRadians());
            Console.ReadKey();
        }
    }
}
    