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
        public string getDigit(char number,int kind, int numberCase)
        {
            return numberDictionary.digitToString(Convert.ToInt32(number) - 48, kind, numberCase);
        }
        public string getTwoDigit(string number, int kind, int numberCase)
        {   if (Convert.ToInt32(number) == 0) return "";
            else if ((Convert.ToInt32(number) < 20) &&((Convert.ToInt32(number) >= 10))) return numberDictionary.beforeTwentyToString(Convert.ToInt32(number[number.Length - 1] - 48), numberCase);
            else if (number[number.Length - 1] == 0) return numberDictionary.twoDigit(Convert.ToInt32(number), numberCase);
            else return numberDictionary.twoDigit((Convert.ToInt32(number[0]) - 48) * 10, numberCase) + " " + numberDictionary.digitToString(number[number.Length - 1] - 48, kind, numberCase);
        }
        public string getHundred(string number, int kind, int numberCase)
        {
            return numberDictionary.hundredToString(Convert.ToInt32(number[0]) - 48, numberCase) +" "+ getTwoDigit(number.Substring(1,2), kind, numberCase);
        }
        public string numberToTextBeforeHundred(string number, int kind, int numberCase)
        {
            switch (number.Length)
            {
                case 1:
                    return getDigit(number[0], kind, numberCase);
                case 2:
                    return getTwoDigit(number, kind, numberCase);
                default:
                    return getHundred(number, kind, numberCase);
            }
        }
        public string numberToText(string number, int kind, int numberCase)
        {
            string result = "";
            if (number.Length <= 3) result = numberToTextBeforeHundred(number, kind, numberCase);
            else
            {
                result = numberToTextBeforeHundred(number.Substring(number.Length - 3, 3), kind, numberCase);
                number = number.Remove(number.Length - 3);
                result = numberToText(number, 2, numberCase) + " " + numberDictionary.thousandsToString(Convert.ToInt32(number[number.Length - 1] - 48), numberCase) + " " + result;
            }
            return result;
        }
    }
}
