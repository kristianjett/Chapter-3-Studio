using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to get a character count:");
            string userInput = Console.ReadLine();

            Dictionary<char, int> countFromInput = CountChars.countEachChar(userInput);

            foreach (KeyValuePair<char, int> kvp in countFromInput)
            {
                Console.WriteLine($"{kvp.Key} : {kvp.Value}");
            }

            //countFromInput.Select(i => $"{i.Key} : {i.Value}").ToList().ForEach(Console.WriteLine);
        
        }
    }
}
