using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            int number = int.Parse(Console.ReadLine()); //Явно преобразуем введенный пользователем текст в Число
            if (number % 2 == 0) //Проверям делится ли число на 2 без остатка
            {
                Console.WriteLine($"Число {number} четное"); //Выводи сообщение о том что число четное
            }
            else //Выполняется если не выполнено предыдущие условие
            {
                Console.WriteLine($"Число {number} нечетное");
            }
            Console.ReadKey();
        }
    }
}
