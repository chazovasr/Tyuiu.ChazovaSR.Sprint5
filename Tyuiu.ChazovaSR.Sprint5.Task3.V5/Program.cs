using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ChazovaSR.Sprint5.Task3.V5.Lib;
namespace Tyuiu.ChazovaSR.Sprint5.Task3.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Чазова С.Р | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема:    Потоковый метод записи данных в бинарный файл                  *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнила: Чазова Софья Романовна | ИСТНб-23-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дано выражение F(x) = 2x^3 + 0.5x^2 - 3.5x+5, вычислить его значение    *");
            Console.WriteLine("* при x = 2, результат сохранить в бинарный файл OutPutFileTask3.bin и    *");
            Console.WriteLine("* вывести на консоль. Округлить до трёх знаков после запятой.             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("X =  " +x);



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("  Файл: " + res);
            Console.WriteLine("  Создан. ");
            Console.ReadKey();
        }
    }
}
