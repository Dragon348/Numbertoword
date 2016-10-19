using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbertoword
{
    class NumberTranslater
    {
        private WordDictionary numberDictionary = new WordDictionary();
        public string getDigit(char number,int kind, int numberCase)   // Преобразование цифры в пропись
        {
            return numberDictionary.digitToString(Convert.ToInt32(number) - 48, kind, numberCase);
        }
        public string getTwoDigit(string number, int kind, int numberCase) // Преобразование двузначного числа в пропись
        {   if (Convert.ToInt32(number) == 0) return "";
            else if ((Convert.ToInt32(number) < 20) &&((Convert.ToInt32(number) > 10))) return numberDictionary.beforeTwentyToString(Convert.ToInt32(number[1] - 48), numberCase);
            else if (Convert.ToInt32(number[1]) - 48 == 0) return numberDictionary.twoDigit(Convert.ToInt32(number), numberCase);
            else if (Convert.ToInt32(number[0]) - 48 == 0) return getDigit(number[1], kind, numberCase);
            else return numberDictionary.twoDigit((Convert.ToInt32(number[0]) - 48) * 10, numberCase) + " " + numberDictionary.digitToString(number[1] - 48, kind, numberCase);
        }
        public string getHundred(string number, int kind, int numberCase) // Преобразование сотенного разряда в пропись
        {
            if ((Convert.ToInt32(number[0]) - 48 != 0)) return numberDictionary.hundredToString(Convert.ToInt32(number[0]) - 48, numberCase) + " " + getTwoDigit(number.Substring(1, 2), kind, numberCase);
            else return getTwoDigit(number.Substring(1, 2), kind, numberCase);
        }
        public string numberToTextBeforeHundred(string number, int kind, int numberCase) //Получение прописи числа до 1000
        {
            switch (number.Length)
            {
                case 1:
                    return getDigit(number[0], kind, numberCase);
                case 2:
                    return getTwoDigit(number, kind, numberCase);
                default:
                    if ((Convert.ToInt32(number)<10) && ((Convert.ToInt32(number) > 0))) return getDigit(number[2], kind, numberCase);
                    else return getHundred(number, kind, numberCase);
            }
        }
        public string numberToText(string number, int kind, int numberCase) // функция перевода числа в пропись
        {
            /* функция переводит число до миллиона в пропись с учётом рода и падежа. Для того, увеличение допустимый интервал чисел на n-ную степень 1000 производится путём добавиления  словаря 
            наименования степени тысячи с учётом падежа и обработки этого словаря.
            */
            if (number.Length <= 6)
            {
                string result = "";
                if (Convert.ToInt32(number) == 0) return "ноль";
                if (number.Length <= 3) result = numberToTextBeforeHundred(number, kind, numberCase);
                else
                {
                    result = numberToTextBeforeHundred(number.Substring(number.Length - 3, 3), kind, numberCase);
                    number = number.Remove(number.Length - 3);
                    if (Convert.ToInt32(number) != 0)
                    result = numberToTextBeforeHundred(number, 2, numberCase) + " " + numberDictionary.thousandsToString(Convert.ToInt32(number[number.Length - 1] - 48), numberCase) + " " + result;
                }
                return result;
            }
            else return "Введённое число должно быть менее 1000000";
        }
    }
}
