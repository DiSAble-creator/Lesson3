using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Простое числоо — натуральное число, имеющее ровно два различных натуральных делителя.\n" +
                                "Число имеющее более 2 натуральных делителей не является простым.\n");

            Console.Write("Ввети цело число: ");
            int number = int.Parse(Console.ReadLine());

            int i = 2;               //Счетчк
            bool isSimple = true;    // Логическая переменная содержащая информауию является число натуральным или нет
            int countDevider = 2;    // Счетчки делителей

            while (i < number)          //Код в теле цикла будет выполнятся до тех пор, пока переменная i будет меньше проверяемого числа
            {           
                if (number % i == 0)    //Проверям делиться ли введенное число на счетчик итераций без остатка
                {
                    isSimple = false;   //Если число делиться без остатка, то переменной isSimple присваиваем значение false
                    countDevider++;     //прибавляем 1 к сетчику делителей

                }
                i++;
            }

            if (isSimple)
            {
                Console.WriteLine($"Число {number} простое так как имеет 2 натуральных делителя");
            }
            else
            {
                Console.WriteLine($"Число {number} не является простым, так как имеет {countDevider} натуральынх делителя/ей");
            }

            Console.ReadKey();
        }
    }
}
