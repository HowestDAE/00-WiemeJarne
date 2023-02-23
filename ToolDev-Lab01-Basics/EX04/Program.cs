using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            string word = "";
            List<string> sentenceList = new List<string>(); //the sentence but each string is a word or another char no whitespaces
            string strBetweenSpaces = ""; //the same as word but also with other chars not only with letters except no whitespaces

            int amountOfDigitChars = 0;
            int amountOfLetterChars = 0;
            int amountOfPunctionChars = 0;
            int amountOfSymbolChars = 0;

            for (int index = 0; index < sentence.Length; ++index)
            {
                char nextChar = Convert.ToChar(sentence.Substring(index, 1));

                if (char.IsPunctuation(nextChar))
                {
                    ++amountOfPunctionChars;
                    sentenceList.Add(strBetweenSpaces);
                    sentenceList.Add(Convert.ToString(nextChar));
                    strBetweenSpaces = "";
                }

                if (!char.IsWhiteSpace(nextChar) && !char.IsPunctuation(nextChar))
                {
                    strBetweenSpaces += nextChar;
                }
                
                if (char.IsLetter(nextChar))
                {
                    word += nextChar;
                    ++amountOfLetterChars;
                }

                if(char.IsDigit(nextChar))
                {
                    ++amountOfDigitChars;
                }

                if(char.IsSymbol(nextChar))
                {
                    ++amountOfSymbolChars;
                }

                if (char.IsWhiteSpace(nextChar) || index == (sentence.Length - 1)) //when a space is found or when the loop is at the last char of the string
                {
                    sentenceList.Add(strBetweenSpaces);
                    strBetweenSpaces = "";

                    if(word.Length != 0)
                    {
                        Console.WriteLine($"word: '{word}' at {index - word.Length} lenght {word.Length}");
                        word = "";
                    }
                }
            }

            Console.WriteLine(" "); //prints a blank line
            Console.WriteLine("New sentence:");
            StringBuilder sb = new StringBuilder();
            foreach(string strWord in sentenceList)
            {
                char[] charArray = strWord.ToCharArray();
                Array.Reverse(charArray);
                sb.Append(charArray);
                sb.Append(' ');
            }
            Console.WriteLine(sb.ToString());
            Console.WriteLine(" ");

            Console.WriteLine($"{amountOfDigitChars} digit characters");
            Console.WriteLine($"{amountOfLetterChars} letter characters");
            Console.WriteLine($"{amountOfPunctionChars} punctuation characters");
            Console.WriteLine($"{amountOfSymbolChars} symbol characters");

            Console.ReadLine(); ////to make the console not close automatically
        }
    }
}
