using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ChazovaSR.Sprint5.Task1.V2.Lib;
namespace Tyuiu.ChazovaSR.Sprint5.Task1.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Чазова С.Р | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема:   Класс File. Запись набора данных в текстовый файл               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнила: Чазова Софья Романовна | ИСТНб-23-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Написать программу на C#, которая выводит таблицу значений функций:     *");
            Console.WriteLine("* F(x) = 2x - 3 / cos(x) - 2x + 5x - 6, (произвести табулирование), f(x)  *");
            Console.WriteLine("* на заданном диапазоне [-5;5] с шагом 1.Произвести проверку деления на 0 *");
            Console.WriteLine("* При делении на ноль вернуть значение 0. Результат сохранить в текстовый *");
            Console.WriteLine("* файл OutPutFileTask1.txt и вывести на консоль в таблицу.                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("startValue =  " + startValue);
            Console.WriteLine("stopValue =  " + stopValue);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            string res = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("  Файл: " + res);
            Console.WriteLine("  Создан. ");
            Console.ReadKey();
        }
    }
}
