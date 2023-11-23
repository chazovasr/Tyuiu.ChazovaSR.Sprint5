using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ChazovaSR.Sprint5.Task5.V17.Lib;
using System.IO;
namespace Tyuiu.ChazovaSR.Sprint5.Task5.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Чазова С.Р | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема:  Чтение набора данных из текстового файла                         *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнила: Чазова Софья Романовна | ИСТНб-23-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дан файл С:/DataSprint5/InPutDataFileTask5V17.txt Создать папку в ручную*");
            Console.WriteLine("* С:/DataSprint5/ и скопировать в неё файл) в котором есть набор значений *");
            Console.WriteLine("* Найти сумму всех простых целых чисел в файле. Полученный результат      *");
            Console.WriteLine("* вывести на консоль. Вещественные значения округлить до 3 знаков.        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V17.txt ";
            Console.WriteLine("Данные находятся в файле:  " + path);



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Сумма всех простых целых чисел в файле = " + res);
            Console.ReadKey();
        }
    }
}
