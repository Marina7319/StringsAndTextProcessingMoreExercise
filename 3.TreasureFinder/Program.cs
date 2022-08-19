using System;
using System.Linq;
using System.Collections.Generic;
namespace TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            List<int> numList = new List<int>();
            string input = Console.ReadLine();
            while (input != "find")
            {
                string command = input;
                int commandLength = command.Length;
                while (commandLength > 0)
                {
                    for (int currentKey = 0; currentKey < numbers.Length; currentKey++)
                    {
                        numList.Add(numbers[currentKey]);
                    }
                    commandLength -= numbers.Length;
                }
                string message = "";
                int decryptedChars = 0;
                for (int i = 0; i < command.Length; i++)
                {
                    decryptedChars = (int)command[i] - numList[i];
                    message += (char)decryptedChars;
                }
                string[] tresure = message.Split("&");
                int startIndex = message.IndexOf("<");
                int endIndex = message.IndexOf(">");
                string cordinatesTresure = "";
                for (int cordinates = startIndex + 1; cordinates < endIndex; cordinates++)
                {
                    cordinatesTresure += message[cordinates];
                }
                Console.WriteLine($"Found {tresure[1]} at {cordinatesTresure}");
                input = Console.ReadLine();
            }
        }
    }
}
