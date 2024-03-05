using System;
using System.Collections.Generic;
using ConverterLib11;

namespace ConsoleAP1
{
    public class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение:");
            double num = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Выберите величину:\n " +
                "1. - Сила.\n " +
                "2. - Длина\n " +
                "3. - Мощность\n " +
                "4. - Давление\n " +
                "5. - Скорость. \n " +
                "6. - Время.");

            string phValue = Console.ReadLine();
            Console.Clear();
            switch (phValue)
            {
                case "1":
                    Console.WriteLine("Перевод из:\n " +
                        "1. Ньютон\n " +
                        "2. КилоНьютон\n " +
                        "3. МегаНьютон");

                    string from = Console.ReadLine();
                    Console.Clear();
                    switch (from)
                    {
                        case "1":
                            Console.WriteLine("Перевод в:\n " +
                                "1. КилоНьютон\n " +
                                "2. МегаНьютон");

                            string to = Console.ReadLine();
                            Console.Clear();
                            switch (to)
                            {
                                case "1":
                                    Console.WriteLine($"Результат: {num / 1000}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат: {num / 1000000}");
                                    break;
                            }
                            break;
                        case "2":
                            Console.WriteLine("Перевод в:\n " +
                                "1. Ньютон\n " +
                                "2. МегаНьютон");

                            to = Console.ReadLine();
                            Console.Clear();
                            switch (to)
                            {
                                case "1":
                                    Console.WriteLine($"Результат: {num * 1000}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат: {num / 1000}");
                                    break;
                            }
                            break;
                        case "3":
                            Console.WriteLine("Перевод в:\n " +
                                "1. Ньютон\n " +
                                "2. КилоНьютон");

                            to = Console.ReadLine();
                            Console.Clear();
                            switch (to)
                            {
                                case "1":
                                    Console.WriteLine($"Результат: {num * 1000000}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат: {num * 1000}");
                                    break;
                            }
                            break;

                    }
                    break;
                case "2":
                    Console.WriteLine("Перевод из:\n" +
                        "1. Сантиметры\n" +
                        "2. Метры\n" +
                        "3. КилоМетры");
                    from = Console.ReadLine();
                    Console.Clear();
                    switch (from)
                    {
                        case "1":
                            Console.WriteLine("Перевод в:\n" +
                                "1. Метры\n" +
                                "2. КилоМетры");
                            string to = Console.ReadLine();
                            Console.Clear();
                            switch (to)
                            {
                                case "1":
                                    Console.WriteLine($"Результат: {num / 100}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат: {num / 100000}");
                                    break;
                            }
                            break;
                        case "2":
                            Console.WriteLine("Перевод в:\n" +
                                "1. Сантиметры\n" +
                                "2. КилоМетры");
                            to = Console.ReadLine();
                            Console.Clear();
                            switch (to)
                            {
                                case "1":
                                    Console.WriteLine($"Результат: {num * 100}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат: {num / 1000}");
                                    break;
                            }
                            break;
                        case "3":
                            Console.WriteLine("Перевод в:\n" +
                                "1. Сантиметры\n" +
                                "2. Метры");
                            to = Console.ReadLine();
                            Console.Clear();
                            switch (to)
                            {
                                case "1":
                                    Console.WriteLine($"Результат: {num * 100000}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат: {num * 1000}");
                                    break;
                            }
                            break;
                    }
                    break;
                case "3":
                    Console.WriteLine("Перевод из:\n" +
                        "1. Киловатт\n" +
                        "2. Мегаватт\n" +
                        "3. Ватт");
                    from = Console.ReadLine();
                    Console.Clear();
                    switch (from)
                    {
                        case "1":
                            Console.WriteLine("Перевод в:\n" +
                                "1. Мегаватт\n" +
                                "2. Ватт");
                            string to = Console.ReadLine();
                            Console.Clear();

                            switch (to)
                            {
                                case "1":
                                    Console.WriteLine($"Результат: {num / 1000}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат: {num * 1000}");
                                    break;
                            }
                            break;
                        case "2":
                            Console.WriteLine("Перевод в:\n" +
                                "1. Киловатт\n" +
                                "2. Ватт");
                            to = Console.ReadLine();
                            Console.Clear();

                            switch (to)
                            {
                                case "1":
                                    Console.WriteLine($"Результат: {num * 1000}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат: {num * 1000000}");
                                    break;
                            }
                            break;
                        case "3":
                            Console.WriteLine("Перевод в:\n" +
                                "1. Киловатт\n" +
                                "2. Мегаватт");
                            to = Console.ReadLine();
                            Console.Clear();

                            switch (to)
                            {
                                case "1":
                                    Console.WriteLine($"Результат: {num / 1000}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат: {num / 1000000}");
                                    break;
                            }
                            break;

                    }
                    break;
                case "4":
                    Console.WriteLine("Перевод из:\n" +
                        "1. Бар\n" +
                        "2. Гигапаскаль\n" +
                        "3. Килопаскаль\n" +
                        "4. Паскаль");
                    from = Console.ReadLine();
                    Console.Clear();
                    switch (from)
                    {
                        case "1":
                            Console.WriteLine("Перевод в:\n" +
                                "1. Гигапаскаль\n" +
                                "2. Килопаскаль\n" +
                                "3. Паскаль");
                            string to = Console.ReadLine();
                            Console.Clear();
                            switch (to)
                            {
                                case "1":
                                    Console.WriteLine($"Результат: {num / 10000}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат: {num * 100}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат: {num * 100000}");
                                    break;
                            }
                            break;
                        case "2":
                            Console.WriteLine("Перевод в:\n" +
                                "1. Бар\n" +
                                "2. Килопаскаль\n" +
                                "3. Паскаль");
                            to = Console.ReadLine();
                            Console.Clear();
                            switch (to)
                            {
                                case "1":
                                    Console.WriteLine($"Результат: {num * 10000}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат: {num * 1000000}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат: {num * 1e+9}");
                                    break;
                            }
                            break;
                        case "3":
                            Console.WriteLine("Перевод в:\n" +
                                "1. Бар\n" +
                                "2. Гигапаскаль\n" +
                                "3. Паскаль");
                            to = Console.ReadLine();
                            Console.Clear();
                            switch (to)
                            {
                                case "1":
                                    Console.WriteLine($"Результат: {num / 100}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат: {num / 1e-6}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат: {num * 1000}");
                                    break;
                            }
                            break;
                        case "4":
                            Console.WriteLine("Перевод в:\n" +
                                "1. Бар\n" +
                                "2. Гигапаскаль\n" +
                                "3. Килопаскаль");
                            to = Console.ReadLine();
                            Console.Clear();
                            switch (to)
                            {
                                case "1":
                                    Console.WriteLine($"Результат: {num / 100000}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат: {num / 1e+9}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат: {num / 1000}");
                                    break;
                            }
                            break;
                    }
                    break;
                case "5":
                    Console.WriteLine("Перевод из:\n" +
                        "1. м/с\n" +
                        "2. км/мин\n" +
                        "3. км/ч\n" +
                        "4. миля/ч");
                    from = Console.ReadLine();
                    Console.Clear();
                    switch (from)
                    {
                        case "1":
                            Console.WriteLine("Перевод в:\n" +
                                "1. км/мин\n" +
                                "2. км/ч\n" +
                                "3. миля/ч");
                            string to = Console.ReadLine();
                            switch (to)
                            {
                                case "1":
                                    Console.WriteLine($"Результат: {num / 16,667}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат: {num * 3,6}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат: {num * 2,237}");
                                    break;
                            }
                            break;
                        case "2":
                            Console.WriteLine("Перевод в:\n" +
                                "1. м/с\n" +
                                "2. км/ч\n" +
                                "3. миля/ч");
                            to = Console.ReadLine();
                            switch (to)
                            {
                                case "1":
                                    Console.WriteLine($"Результат: {num * 16,667}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат: {num * 60}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат: {num * 37,282}");
                                    break;
                            }
                            break;
                        case "3":
                            Console.WriteLine("Перевод в:\n" +
                                "1. м/с\n" +
                                "2. км/мин\n" +
                                "3. миля/ч");
                            to = Console.ReadLine();
                            switch (to)
                            {
                                case "1":
                                    Console.WriteLine($"Результат: {num / 3,6}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат: {num / 60}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат: {num / 1,609}");
                                    break;
                            }
                            break;
                        case "4":
                            Console.WriteLine("Перевод в:\n" +
                                "1. м/с\n" +
                                "2. км/мин\n" +
                                "3. км/ч");
                            to = Console.ReadLine();
                            switch (to)
                            {
                                case "1":
                                    Console.WriteLine($"Результат: {num / 2,237}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат: {num / 37,282}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат: {num * 1,609}");
                                    break;
                            }
                            break;
                    }
                    break;
                case "6":
                    Console.WriteLine("Перевод из:\n" +
                        "1. Секунды\n" +
                        "2. Минуты\n" +
                        "3. Часы\n" +
                        "4. Миллисекунды");
                    from = Console.ReadLine();
                    Console.Clear();
                    switch (from)
                    {
                        case "1":
                            Console.WriteLine("Перевод в:\n" +
                                "1. Минуты\n" +
                                "2. Часы\n" +
                                "3. Миллисекунды");
                            string to = Console.ReadLine();
                            Console.Clear();
                            switch (to)
                            {
                                case "1":
                                    Console.WriteLine($"Результат: {num / 60}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат: {num / 3600}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат: {num * 1000}");
                                    break;
                            }
                            break;
                        case "2":
                            Console.WriteLine("Перевод в:\n" +
                                "1. Секунды\n" +
                                "2. Часы\n" +
                                "3. Миллисекунды");
                            to = Console.ReadLine();
                            Console.Clear();
                            switch (to)
                            {
                                case "1":
                                    Console.WriteLine($"Результат: {num * 60}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат: {num / 60}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат: {num * 60000}");
                                    break;
                            }
                            break;
                        case "3":
                            Console.WriteLine("Перевод в:\n" +
                                "1. Секунды\n" +
                                "2. Минуты\n" +
                                "3. Миллисекунды");
                            to = Console.ReadLine();
                            Console.Clear();
                            switch (to)
                            {
                                case "1":
                                    Console.WriteLine($"Результат: {num * 3600}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат: {num * 60}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат: {num * 3.6e+6}");
                                    break;
                            }
                            break;
                        case "4":
                            Console.WriteLine("Перевод в:\n" +
                                "1. Секунды\n" +
                                "2. Минуты\n" +
                                "3. Часы");
                            to = Console.ReadLine();
                            Console.Clear();
                            switch (to)
                            {
                                case "1":
                                    Console.WriteLine($"Результат: {num / 1000}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат: {num / 60000}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат: {num / 3.6e+6}");
                                    break;
                            }
                            break;
                    }
                    break;
            }



        }
    }
}
