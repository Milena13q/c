using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пожалуйста 3 целых числа: "); //Печать текста и переход на след. строку
            Console.Write("a= "); //Вывод текста без перехода на след. строку
            int a = Convert.ToInt16(Console.ReadLine()); //Преобразованная строка в int16
            Console.Write("b= "); //Вывод текста без перехода на след. строку
            int b = Convert.ToInt16(Console.ReadLine()); //Преобразованная строка в int16
            Console.Write("c= "); //Вывод текста без перехода на след. строку
            int c = Convert.ToInt16(Console.ReadLine()); //Преобразованная строка в int16
            int sum = a + b + c; //Сумма чисел
            Console.WriteLine("{0}+{1}+{2} = {3}", a, b, c, sum); //Печать текста в прямом порядке и сумма трех чисел
            Console.ReadLine(); //Чтение текста, введенного в строке пользователем
        }
    }
}
