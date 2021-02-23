using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm thinking of a number in between 0 and 100, what is it?");
            Random r = new Random();

            int winNum = r.Next(0, 100);
            int guess;

            bool win = false;
            while (win == false)
            {
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess > winNum)
                {
                    Console.WriteLine("Too High!");
                }
                else if (guess < winNum)
                {
                    Console.WriteLine("Too Low!");
                }
                else if (guess == winNum) {
                    Console.WriteLine("GG You Won!");
                }
            }
            Console.ReadKey();
        }
    }
}
