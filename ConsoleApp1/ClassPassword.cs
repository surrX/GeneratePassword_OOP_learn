using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PasswordSettings
    {
        public int Lengths { get; set; } = 8;
        public bool UseLetters { get; set; } = true;
        public bool UseDigits { get; set; } = false;
        public bool UseSymbols { get; set; } = false;
    }

        public class PasswordGenerator
        {
            private const string Letters = "abcdefghijklmnopqrstuvwxyz" +
                                           "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            private const string Digits = "0123456789";
            private const string Symbols = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";

            private readonly Random _rnd = new Random();

            public string Generate(PasswordSettings settings)
            {
                // 1. Собираем алфавит из включённых категорий
                string alphabet = "";
                if (settings.UseLetters) alphabet += Letters;
                if (settings.UseDigits) alphabet += Digits;
                if (settings.UseSymbols) alphabet += Symbols;

                // 2. Проверка: если ничего не выбрано — вернуть сообщение
                if (alphabet.Length == 0)
                {
                    return "Ошибка: не выбрано ни одной категории символов";
                }

                // 3. Собираем пароль
                string password = "";
                for (int i = 0; i < settings.Lengths; i++)
                {
                    int index = _rnd.Next(alphabet.Length);
                    password += alphabet[index];
                }

                return password;
            }
        }
    }

