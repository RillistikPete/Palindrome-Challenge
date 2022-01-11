using System;
using System.Linq;
using System.Collections.Generic;

namespace consoleTester
{
    class Program
    {
        static void Main(string[] args)
        {
            int iterations = 0;
            Console.WriteLine("Enter number");
            string input = Console.ReadLine();
            string reversed = StrRevFunction(input);
            do {
              if (input == StrRevFunction(input))
              {
                Console.WriteLine($"{iterations} {input}: Palindrome");
              }
              else
              {
                long inputNumber = Convert.ToInt64(input);
                Console.WriteLine($"Input: {inputNumber}, Reversed: {StrRevFunction(input)}");
                long addedResult = inputNumber + Convert.ToInt64(StrRevFunction(input));
                Console.WriteLine($"Added result: {addedResult}");
                string nextNumber = addedResult.ToString();
                input = nextNumber;
                iterations++;
              }
            } while (input != StrRevFunction(input));
            Console.WriteLine($"{iterations} {input}");
        }

        public static string StrRevFunction(string inputStr) {
          char [] reversed = new char[inputStr.Length];
          int moveup = 0;
          for (var j = (inputStr.Length - 1); j >= 0; j--)
          {
              reversed[moveup++] = inputStr[j];
          }
          return new string(reversed);
        }
    }
}
