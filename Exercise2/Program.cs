using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Приветсвую тебя, игрок!!!\nСколько у тебя карт на руках?\nВведите количество карт: ");
            int counter = int.Parse(Console.ReadLine()); //Явно преобразуем введенный пользователем текст в Число
            Console.WriteLine();
            Console.WriteLine("Номиналы карт:\nВалет = J\nДама = Q\nКороль = K\nТуз = T");
            for (int i = 0; i < counter; )
            {
                start: //Метка для перехода в случае некроктно введных значений
                Console.Write("Введи номинал карты: ");
                string card = Console.ReadLine(); // Пользователь вводит номинал карты
                switch (card)
                {
                    case "2":
                        sum += 2;
                        break;
                    case "3":
                        sum += 3;
                        break;
                    case "4":
                        sum += 4;
                        break;
                    case "5":
                        sum += 5;
                        break;
                    case "6":
                        sum += 6;
                        break;
                    case "7":
                        sum += 7;
                        break;
                    case "8":
                        sum += 8;
                        break;
                    case "9":
                        sum += 9;
                        break;
                    case "10":
                    case "J":
                    case "Q":
                    case "K":
                    case "T":
                        sum += 10;
                        break;
                    default:
                        Console.WriteLine("Введено некорректное значение");
                        goto start; //При введении некорректных значений переходим на метку start
                }
                i++;
            }
            Console.WriteLine($"\nСумма твоих карт:{sum}"); //Выводим сумму карт игрока
            Console.ReadLine();
        }
    }
}
