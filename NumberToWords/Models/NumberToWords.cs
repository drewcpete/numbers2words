using System.Collections.Generic;
using System.Linq;

namespace NumberToWords
{
    public class NumberConvert
    {
        public static string Number  {get; set;}
        public static string NumberString {get; set;}
        public static char[] NumberCharArray {get; set;}
         
        public NumberConvert(string input)
        {
            Number = input;
            NumberString = Number.ToString();
            NumberCharArray = NumberString.ToCharArray();
            
        }
        public static Dictionary<char, string> Ones = new Dictionary<char, string> {{'1', "one"}, {'2', "two"}, {'3', "three"}, {'4', "four"}, {'5', "five"}, {'6', "six"}, {'7', "seven"}, {'8', "eight"}, {'9', "nine"}};

        public static Dictionary<string, string> Teens = new Dictionary<string, string> {{"11", "eleven"}, {"12", "twelve"}, {"13", "thirteen"}, {"14", "fourteen"}, {"15", "fifteen"}, {"16", "sixteen"}, {"17", "seventeen"}, {"18", "eighteen"}, {"19", "nineteen"}};

        public static Dictionary<char, string> Tens = new Dictionary<char, string> {{'2', "twenty"}, {'3', "thirty"}, {'4', "fourty"}, {'5', "fifty"}, {'6', "sixty"}, {'7', "seventy"}, {'8', "eighty"}, {'9', "ninety"}};
        public static string ConvertOnesToWords(char[] input)
        {
            
            string numberWord = "";
            foreach (char digit in input)
            {
                if(input.Length == 1)
                {
                    numberWord = Ones[digit];
                }
                if (input.Length == 2)
                {
                    if (input[0] == input [1])
                    {
                        numberWord = Tens[digit];
                        numberWord += Ones[digit];
                        break;
                    }
                    if(input[0]==digit)
                    {
                        numberWord = Tens[digit];
                    }
                    if(input[1]==digit)
                    {
                        numberWord += Ones[digit];
                    }
                }
        
            }
            return numberWord; 
        }

    }
}