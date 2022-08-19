using System;

namespace HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string titleOfArticle = Console.ReadLine();
            string contentOfArticle = Console.ReadLine();
            Console.WriteLine($"<h1>   \n {titleOfArticle} \n</h1>");
            Console.WriteLine($"<article>   \n {contentOfArticle} \n</article>");
            string input = Console.ReadLine();
            while (input != "end of comments")
            {
                string comment = input;
                Console.WriteLine($"<div>   \n {comment} \n</div>");
                input = Console.ReadLine();
            }
        }
    }
}
