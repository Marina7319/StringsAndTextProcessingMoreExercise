using System;

namespace AsciiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstCharacter = char.Parse(Console.ReadLine());
            char secondCharacter = char.Parse(Console.ReadLine()); 
            string charactersInput = Console.ReadLine();
            int firstChar = (int)firstCharacter;
            int secondChar = (int)secondCharacter;
            int biggerNum = Math.Max(firstChar,secondChar);
            int smallerNum = Math.Min(firstChar, secondChar);       
            int sum = 0;
            for (int i = 0; i < charactersInput.Length; i++)
            {
                int result = (int)charactersInput[i];
                if (result > smallerNum && result < biggerNum)
                {
                    sum += result;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
