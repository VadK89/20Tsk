using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Tsk
{
    /*В приложении объявить тип делегата, который ссылается на метод. Требования к сигнатуре метода следующие:
          - метод получает входным параметром переменную типа double;
          - метод возвращает значение типа double, которое является результатом вычисления.
 
         Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
         -длину окружности по формуле D = 2 * π* R;
         -площадь круга по формуле S = π* R²;
         -объем шара. Формула V = 4/3 * π * R³.   
     */
    class Program
    {
        //Задаем делегат
        delegate double NewDelegate(double Rad);
        static void Main(string[] args)
        {
            //Задаем радиус
            Console.WriteLine("Введите значение радиуса");
            double rad = Convert.ToDouble(Console.ReadLine());
            //Вызываем метод через делегат  для поиска длины окружности с заданным радиусом
            NewDelegate newDelegate = new NewDelegate(Length);
            double cl = newDelegate(rad);
            Console.WriteLine("Длина окружностис радиусом {0}: {1:f3} ", rad, cl);
            //Вызываем метод через делегат для поиска площади окружности с заданным радиусом
            NewDelegate newDelegate1 = new NewDelegate(Area);
            double ca = newDelegate1(rad);
            Console.WriteLine("Площадь окружности с радиусом {0}: {1:f3} ", rad, ca);
            //Вызываем метод через делегат для поиска объема сферы с заданным радиусом
            NewDelegate newDelegate2 = new NewDelegate(Volume);
            double vol = newDelegate2(rad);
            Console.WriteLine("Объем сферы с радиусом {0}: {1:f3} ", rad, vol);                
            Console.ReadKey();
        }
        //Метод для поиска длины окружности
        static double Length(double Rad)
        {
            double D = 2 * Math.PI * Rad;
            return D;
        }
        //Метод для поиска площади окружности
        static double Area(double Rad)
        {
            double S = Math.PI * Math.Pow(Rad, 2);
            return S;
        }
        //Метод для поиска объема сферы
        static double Volume(double Rad)
        {
            double V = 4 * (Math.PI * Math.Pow(Rad, 3)) / 3;
            return V;
        }
    }
}
