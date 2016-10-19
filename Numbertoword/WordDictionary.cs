using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Numbertoword;
using System.Collections;

namespace Numbertoword
{
    class WordDictionary
    {
        private Dictionary<int, Dictionary<int, string>> digits = new Dictionary<int, Dictionary<int, string>>
                {
                        {
                        0,
                        new Dictionary <int, string> { {1, "ноль"}, {2, "нуля"}, {3, "нулю"}, {4, "ноль"}, {5, "нулём"}, {6, "нуле"}}

                        },
                        {
                        3,
                        new Dictionary <int, string> { {1, "три"}, {2, "трёх"}, {3, "трём"}, {4, "три"}, {5, "тремя"}, {6, "трёх"}}

                        },
                        {

                        4,
                        new Dictionary <int, string> { {1, "четыре"}, {2, "четырёх"}, {3, "четырём"}, {4, "четыре"}, {5, "четыремя"}, {6, "четырёх"}}

                        },
                        {

                        5,
                        new Dictionary <int, string> { {1, "пять"}, {2, "пяти"}, {3, "пяти"}, {4, "пять"}, {5, "пятью"}, {6, "пяти"}}

                        },
                        {

                        6,
                        new Dictionary <int, string> { {1, "шесть"}, {2, "шести"}, {3, "шести"}, {4, "шесть"}, {5, "шестью"}, {6, "шести"}}

                        },
                        {

                        7,
                        new Dictionary <int, string> { {1, "семь"}, {2, "семи"}, {3, "семи"}, {4, "семь"}, {5, "семью"}, {6, "семи"}}

                        },
                        {

                        8,
                        new Dictionary <int, string> { {1, "восемь"}, {2, "восьми"}, {3, "восьми"}, {4, "восемь"}, {5, "восьмью"}, {6, "восьми"}}

                        },
                        {

                        9,
                        new Dictionary <int, string> { {1, "девять"}, {2, "девяти"}, {3, "девяти"}, {4, "девять"}, {5, "девятью"}, {6, "девяти"}}

                         },
                        {

                        10,
                        new Dictionary <int, string> { {1, "десять"}, {2, "десяти"}, {3, "десяти"}, {4, "десять"}, {5, "десятью"}, {6, "десяти"}}

                         },
                         {

                        20,
                        new Dictionary <int, string> { {1, "двадцать"}, {2, "двадцати"}, {3, "двадцати"}, {4, "двадцать"}, {5, "двадцатью"}, {6, "двадцати"}}

                        },
                        {

                        30,
                        new Dictionary <int, string> { {1, "тридцать"}, {2, "тридцати"}, {3, "тридцати"}, {4, "тридцать"}, {5, "тридцатью"}, {6, "тридцати"}}

                        },
                        {

                        40,
                        new Dictionary <int, string> { {1, "сорок"}, {2, "сорока"}, {3, "сорока"}, {4, "сорок"}, {5, "сорока"}, {6, "сорока"}}

                        },
                        {

                        50,
                        new Dictionary <int, string> { {1, "пятьдесят"}, {2, "пятидесяти"}, {3, "пятидесяти"}, {4, "пятьдесят"}, {5, "пятидесятью"}, {6, "пятидесяти"}}

                        },
                        {

                        60,
                        new Dictionary <int, string> { {1, "шестьдесят"}, {2, "шестидесяти"}, {3, "шестидесяти"}, {4, "шестьдесят"}, {5, "шестидесятью"}, {6, "шестидесяти"}}

                        },
                        {

                        70,
                        new Dictionary <int, string> { {1, "семьдесят"}, {2, "семидесяти"}, {3, "семидесяти"}, {4, "семьдесят"}, {5, "семидесятью"}, {6, "семидесяти"}}

                        },
                        {

                        80,
                        new Dictionary <int, string> { {1, "восемьдесят"}, {2, "восьмидесяти"}, {3, "восьмидесяти"}, {4, "восемьдесят"}, {5, "восьмидесятью"}, {6, "восьмидесяти"}}

                        },
                        {

                        90,
                        new Dictionary <int, string> { {1, "девяносто"}, {2, "девяноста"}, {3, "девяноста"}, {4, "девяносто"}, {5, "девяноста"}, {6, "девяноста"}}
                        }
                };
        private Dictionary<int, Dictionary<int, string>> one = new Dictionary<int, Dictionary<int, string>>
                {
                    {
                        1,
                        new Dictionary <int, string> { {1, "один"}, {2, "одного"}, {3, "одному"}, {4, "один"}, {5, "одним"}, {6, "одном"}}

                },
                {

                        2,
                        new Dictionary <int, string> { {1, "одна"}, {2, "одной"}, {3, "одной"}, {4, "одна"}, {5, "одной"}, {6, "одной"}}

                },
                {

                        3,
                        new Dictionary <int, string> { {1, "одно"}, {2, "одного"}, {3, "одному"}, {4, "одон"}, {5, "одним"}, {6, "одном"}}
                    }
                };
        private Dictionary<int, Dictionary<int, string>> two = new Dictionary<int, Dictionary<int, string>>
                {
                    {
                        1,
                        new Dictionary <int, string> { {1, "два"}, {2, "двух"}, {3, "двум"}, {4, "два"}, {5, "двумя"}, {6, "двух"}}

                },
                {

                        2,
                        new Dictionary <int, string> { {1, "две"}, {2, "двух"}, {3, "двум"}, {4, "две"}, {5, "двумя"}, {6, "двух"}}

                },
                {

                        3,
                        new Dictionary <int, string> { {1, "два"}, {2, "двух"}, {3, "двум"}, {4, "два"}, {5, "двумя"}, {6, "двух"}}
                    }
                };
        private Dictionary<int, string> dec = new Dictionary<int, string> { { 1, "надцать" }, { 2, "надцати" }, { 3, "надцати" }, { 4, "надцать" }, { 5, "надцатью" }, { 6, "надцати" } };
        private Dictionary<int, string> hundreds59 = new Dictionary<int, string> { { 1, "сот" }, { 2, "сот" }, { 3, "стам" }, { 4, "сот" }, { 5, "стами" }, { 6, "стах" } };
        private Dictionary<int, string> hundreds1 = new Dictionary<int, string> { { 1, "сто" }, { 2, "ста" }, { 3, "ста" }, { 4, "сот" }, { 5, "ста" }, { 6, "ста" } };
        private Dictionary<int, string> hundreds200 = new Dictionary<int, string> { { 1, "двести" }, { 2, "двухсот" }, { 3, "двумстам" }, { 4, "двести" }, { 5, "двумястами" }, { 6, "двухстах" } };
        private Dictionary<int, string> hundreds34 = new Dictionary<int, string> { { 1, "ста" }, { 2, "сот" }, { 3, "стам" }, { 4, "ста" }, { 5, "стами" }, { 6, "стах" } };
        private static Dictionary<int, string> thousandsOver5 = new Dictionary<int, string> { { 1, "тысяч" }, { 2, "тысяч" }, { 3, "тысячам" }, { 4, "тысяч" }, { 5, "тысячами" }, { 6, "тысячах" } };
        private static Dictionary<int, string> thousands1 = new Dictionary<int, string> { { 1, "тысяча" }, { 2, "тысячи" }, { 3, "тысяче" }, { 4, "тысяча" }, { 5, "тысячей" }, { 6, "тысяче" } };
        private static Dictionary<int, string> thousands24 = new Dictionary<int, string> { { 1, "тысячи" }, { 2, "тысяч" }, { 3, "тысячам" }, { 4, "тысячи" }, { 5, "тысячами" }, { 6, "тысячах" } };
        private static Dictionary<int, Dictionary<int, string>> thousands = new Dictionary<int, Dictionary<int, string>> { { 0, thousandsOver5 }, { 1, thousands1 }, { 2, thousands24 }, { 3, thousands24 }, { 4, thousands24 }, { 5, thousandsOver5 }, { 6, thousandsOver5 }, { 7, thousandsOver5 }, { 8, thousandsOver5 }, { 9, thousandsOver5 }, };


        public string digitToString(int digit, int kind, int numberCase)// возвращает прописное значение цифры
        {
            switch (digit)
            {
                case 1:
                    return one[kind][numberCase];
                case 2:
                    return two[kind][numberCase];
                default:
                    return digits[digit][numberCase];
            }
        }
        public string hundredToString(int digit,  int numberCase) // возвращает прописное представление сотен
        {
            switch (digit)
            {
                case 1:
                    return hundreds1[numberCase];
                case 2:
                    return hundreds200[numberCase];
                case 3:
                    return digits[digit][numberCase] + hundreds34[numberCase];
                case 4:
                    return digits[digit][numberCase] + hundreds34[numberCase];
                default:
                    return digits[digit][numberCase] + hundreds59[numberCase];
            }
        }
        public string thousandsToString(int digit, int numberCase) // функция возвращаяет прописное представление тысяч
        {
            return thousands[digit][numberCase];
        }
        public string beforeTwentyToString(int digit,  int numberCase)  // функция возвращает пропись чисел от 11 до 20
        {
            switch (digit)
            {
                case 1:
                    return one[1][1] + dec[numberCase];
                case 2:
                    return two[2][1] + dec[numberCase];
                case 3:
                    return digits[3][1] + dec[numberCase];
                default:
                    return digits[digit][1].Substring(0, digits[digit][1].Length - 1) + dec[numberCase];
            }
        }
        public string twoDigit(int digit, int numberCase)
        {
            return digits[digit][numberCase];
        }
    }
}