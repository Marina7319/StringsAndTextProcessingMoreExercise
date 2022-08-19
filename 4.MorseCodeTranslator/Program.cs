using System;
using System.Text;
using System.Collections.Generic;
namespace MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, char> morseCode = new Dictionary<string, char>();
            morseCode.Add(".-", 'A');
            morseCode.Add("-...", 'B');
            morseCode.Add("-.-.", 'C');
            morseCode.Add("-..", 'D');
            morseCode.Add(".", 'E');
            morseCode.Add("..-.", 'F');
            morseCode.Add("--.", 'G');
            morseCode.Add("....", 'H');
            morseCode.Add("..", 'I');
            morseCode.Add(".---", 'J');
            morseCode.Add("-.-", 'K');
            morseCode.Add(".-..", 'L');
            morseCode.Add("--", 'M');
            morseCode.Add("-.", 'N');
            morseCode.Add("---", 'O');
            morseCode.Add(".--.", 'P');
            morseCode.Add("--.-", 'Q');
            morseCode.Add(".-.", 'R');
            morseCode.Add("...", 'S');
            morseCode.Add("-", 'T');
            morseCode.Add("..-", 'U');
            morseCode.Add("...-", 'V');
            morseCode.Add(".--", 'W');
            morseCode.Add("-..-", 'X');
            morseCode.Add("-.--", 'Y');
            morseCode.Add("--..", 'Z');
            var morseMessage = Console.ReadLine().Split(" ");
            StringBuilder sb = new StringBuilder();
            foreach (var word in morseMessage)
            {
                if (word == "|")
                {
                    sb.Append(" ");
                }
                else
                {
                    foreach (var morseCodes in morseCode)
                    {
                        if (word == morseCodes.Key)
                        {
                            sb.Append(morseCodes.Value);
                        }
                    }
                }
            }
            Console.WriteLine(sb);
        }
    }
}
