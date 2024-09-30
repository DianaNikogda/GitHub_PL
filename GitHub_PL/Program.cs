using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_PL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выполнение арифметических действий над числами");
            Console.Write("Введите число a ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число b ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Сумма чисел равна " +(a+b));
            Console.WriteLine("Разность чисел равна " + (a-b));
            Console.WriteLine("Для выхода нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
