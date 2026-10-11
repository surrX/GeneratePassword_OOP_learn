using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            PasswordSettings Settings = new PasswordSettings();
            while (true)
            {
                Console.WriteLine("----- Генератор паролей 3.0 -----");
                Console.WriteLine("(2)Выбрать длинну пароля");
                Console.WriteLine("(3)Использовать цифры");
                Console.WriteLine("(4)Использовать буквы");
                Console.WriteLine("(5)Использовать символы");
                Console.WriteLine("(6)Генерировать");
                Console.WriteLine("UseDigits = " + Settings.UseDigits);
                Console.WriteLine("UseLetters = " + Settings.UseLetters);
                Console.WriteLine("UseSymbols = " + Settings.UseSymbols);
                Console.WriteLine("----- Генератор паролей 3.0 -----");

                bool Num = int.TryParse(Console.ReadLine(), out int user_names);

                if (Num)
                {
                    switch (user_names)
                    {
                        case 0:
                            return;
                        case 2:         
                            bool length = int.TryParse(Console.ReadLine(), out int len_array);                                          /// на все ушло 3-4 часа
                            if (length)
                            {
                                Settings.Lengths = len_array;
                                Console.WriteLine("Ваша длина загружена");
                                break;
                            }
                            else
                            {
                                break;
                            }                                
                        case 3:
                            Settings.UseDigits = !Settings.UseDigits;
                            break;
                        case 4:
                            Settings.UseLetters = !Settings.UseLetters;
                            break;
                        case 5:
                            Settings.UseSymbols = !Settings.UseSymbols;
                            break;
                        case 6:
                            var generator = new PasswordGenerator();
                            string password = generator.Generate(Settings);
                            Console.WriteLine("Ваш пароль: " + password);
                            break;

                        default:
                            Console.WriteLine("Неизвестное число");
                            break;
                    }
                }
            }     
        }
    }
}
