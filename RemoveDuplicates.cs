using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge
{
    public class RemoveDuplicates
    {
        public static List<int> GetUniqueList(List<int> input)
        {
            return input.Distinct().ToList();
        }

        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
            List<int> uniqueNumbers = GetUniqueList(numbers);

            Console.WriteLine("Unique Numbers: " + string.Join(", ", uniqueNumbers));
        }
    }
}
