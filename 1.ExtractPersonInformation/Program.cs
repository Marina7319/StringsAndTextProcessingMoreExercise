using System;
using System.Linq;
using System.Collections.Generic;
namespace ExtractPersonInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<string> nameUser = new List<string>();
            List<string> ageUser = new List<string>();
            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                int firstIndexName = input.IndexOf('@');
                int secondIndexName = input.IndexOf('|');
                int firstIndexAge = input.IndexOf('#');
                int secondIndexAge = input.IndexOf('*');
                string name = "";
                for (int x = firstIndexName + 1; x < secondIndexName; x++)
                {
                    name += input[x];
                }
                nameUser.Add(name);
                string age = "";
                for (int y = firstIndexAge + 1; y < secondIndexAge; y++)
                {
                    age += input[y];
                }
                ageUser.Add(age);
            }
            for (int currNum = 0; currNum < N; currNum++)
            {
                Console.WriteLine($"{nameUser[currNum]} is {ageUser[currNum]} years old.");
            }
        }
    }
}
