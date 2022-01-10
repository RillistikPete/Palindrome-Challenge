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
            string line = Console.ReadLine();
            string reversed = StrRevFunction(line);
            do {
              if (line == StrRevFunction(line))
              {
                Console.WriteLine($"{iterations} {line}: Palindrome");
              }
              else
              {
                long inputNumber = Convert.ToInt64(line);
                Console.WriteLine($"Input: {inputNumber}");
                Console.WriteLine($"Reversed: {StrRevFunction(line)}");
                long addedResult = inputNumber + Convert.ToInt64(StrRevFunction(line));
                Console.WriteLine($"Added result: {addedResult}");
                string nextNumber = addedResult.ToString();
                line = nextNumber;
                iterations++;
              }
            } while (line != StrRevFunction(line));
          Console.WriteLine($"{iterations} {line}");
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
