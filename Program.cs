using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_20
{
    /* В приложении объявить тип делегата, который ссылается на метод.Требования к сигнатуре метода следующие:
 -метод получает входным параметром переменную типа double;
 -метод возвращает значение типа double, которое является результатом вычисления.
 Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
 -длину окружности по формуле D = 2 * π * R;
 -площадь круга по формуле S = π* R²;
 -объем шара.Формула V = 4 / 3 * π * R³.
 Методы должны быть объявлены как статические.*/
    class Program
    {
        delegate void MyDelegate(double r);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = LengthOfCircule; //создаем экземпляр делегата
            myDelegate += SquareOfCircule; //по очереди присваиваем в переменную делегата разные методы
            myDelegate += SphereVolume;
            myDelegate(11);

            Console.ReadKey();
        }

        static void LengthOfCircule(double r)
        {
            double d = 2 * Math.PI * r;
            Console.WriteLine("Длина окружности: " + d);
        }
        static void SquareOfCircule(double r)
        {
            double s = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("Площадь круга: " + s);
        }
        static void SphereVolume(double r)
        {
            double v = 4 / 3 * Math.PI * Math.Pow(r, 3);
            Console.WriteLine("Объем шара: " + v);
        }

    }
}
