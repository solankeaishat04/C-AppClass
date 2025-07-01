using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace C_AppClass
{
    internal class Assignment1
    {
        static void Main( string[] args)
        {
            Random random = new Random();
            int correct =random.Next(1,100);
            List<int> guesses = new List<int>();
            int guess = 0;
            Console.WriteLine("Guess a number between 1 and 100");

            while (guess != correct)
            {
                Console.WriteLine("Your guess: ");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("please anter a number. ");
                    continue;
                }
                guesses.Add(guess);
                if (guess < correct)
                    Console.WriteLine("Too low!");
                else if (guess > correct)
                    Console.WriteLine("Too high!");
                else
                {
                    Console.WriteLine("You got it");
                    Console.WriteLine("Your guesses; "+ string.Join(",", guesses));
                }
            }
        }

    }
}
