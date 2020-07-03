using System;

namespace App32
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] words = input.Split('=');
            foreach (var word in words)
            {
                Console.WriteLine($"{word}");
            }
        }
    }    
}
