using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface
    {
        public static string GetUserInputFor(string prompt)
        {
            Console.WriteLine(prompt);
            string userInput = Console.ReadLine();
            return userInput;
        }
        public static int GetIntUserInputFor(string prompt)
        {
            Console.WriteLine(prompt);
            int userInput = int.Parse(Console.ReadLine());
            return userInput;
        }

        public static void DisplayInput(string input)
        {
            Console.WriteLine(input);
        }
        public static void DisplayInput(int input)
        {
            Console.WriteLine(input);
        }
    }
}
