using System;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Выберите программу, которую вы хотите запустить");
            Console.WriteLine("1. Угадай число");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("4. Закрыть программу");

            int vibor;
            if (int.TryParse(Console.ReadLine(), out vibor))
            {
                switch (vibor)
                {
                    case 1:
                        ugadaichislo();
                        break;
                    case 2:
                        umnogenie();
                        break;
                    case 3:
                        deliteli();
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Ошибка: Неверный выбор.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ошибка: Неверный ввод.");
            }
        }
    }

    static void ugadaichislo()
    {
        Random random = new Random();
        int chislo = random.Next(0, 101);

        Console.WriteLine("Угадай число от 0 до 100!");

        while (true)
        {
            int dogadka;
            if (int.TryParse(Console.ReadLine(), out dogadka))
            {
                if (dogadka == chislo)
                {
                    Console.WriteLine($"Угадал!");
                    break;
                }
                else if (dogadka < chislo)
                {
                    Console.WriteLine("Надо больше");
                }
                else
                {
                    Console.WriteLine("Надо меньше");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: Неверный ввод.");
            }
        }
    }

    static void umnogenie()
    {
        int[,] tabliza = new int[9, 9];

        Console.WriteLine("Таблица умножения:");
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                tabliza[i - 1, j - 1] = i * j;
                Console.Write($"{tabliza[i - 1, j - 1],3} ");
            }
            Console.WriteLine();
        }
    }

    static void deliteli()
    {
        if (int.TryParse(Console.ReadLine(), out int chislo))
        {
            for (int i = 1; i <= chislo; i++)
            {
                if (chislo % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        else
        {
            Console.WriteLine("Ошибка: Неверный ввод.");
        }
    }
}
