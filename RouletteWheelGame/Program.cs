using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteWheelGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            string[] color = { "Red", "Black", "Green" };
            Random rand = new Random();
            
            int attempts = 0;
            string guess;
            
            Console.WriteLine(" This a Roulette Wheel Game, Welcome lucky player!\n");
            Console.WriteLine(" To Bet and win, your choice must match the ball location in the wheel\n");
            Console.WriteLine(" Make your choice by typing any of the following letters below:\n ");

            Console.WriteLine(" a.Evens/Odds   b.Blacks/Reds   c.1 to 18/19 to 36" );
            Console.WriteLine(" d.1st 12       e.2nd 12        f.3rd 12         g.colums:first, second or third " );
            Console.WriteLine(" h.street rows  i.double rows   j.Split          k.corner ");
            guess = (Console.ReadLine());
            guess.ToLower();

            bool[] conditions = { guess == "a", guess == "b", guess == "c", guess == "d", guess == "e", guess == "f",
                guess == "g", guess == "h", guess == "i", guess == "j", guess == "k" };
            int check = Array.IndexOf(conditions, true);

            if(check == -1)
            {
                Console.WriteLine("You did not enter the correct input value");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                
                int roll = rand.Next(0, 37);
                string randColor = color[rand.Next(color.Length)];
                bool even = roll % 2 == 0;
                if ((((guess == "a") && (even == true))) || (((guess == "b") && (even == false))) || 
                    ((guess == "e") && (randColor =="Red") || (guess =="f") && (randColor == "Black")))
                {
                    Console.WriteLine( "The roulette rolled: " + randColor + " " + roll);
                    Console.WriteLine(" You won!");
                    Console.WriteLine(" Press enter to continue");
                    attempts += 1;
                    Console.ReadKey();
                }
                else if ((guess == "c") && ((roll > 0 ) && (roll < 19)))
                {
                    Console.WriteLine("The roulette rolled: " + randColor + " " + roll);
                    Console.WriteLine(" You won!");
                    attempts += 1;
                    Console.ReadKey();
                }
                else if ((guess == "d") && ((roll > 18) && (roll < 37)))
                {
                    Console.WriteLine("The roulette rolled: " + randColor + " " + roll);
                    Console.WriteLine(" You won!");
                    attempts += 1;
                    Console.ReadKey();
                }
                else if ((guess == "g") && (roll > 0 && roll < 13) || (guess == "h") 
                          && (roll > 12 && roll < 25) || (guess == "i") && ( roll > 24 && roll < 37))
                {
                    Console.WriteLine("The roulette rolled: " + randColor + " " + roll);
                    Console.WriteLine(" You won!");
                    attempts += 1;
                    Console.ReadKey();
                }
                else 
                {
                    Console.WriteLine("The roulette rolled: " + randColor + " " + roll);
                    Console.WriteLine(" You lost!");
                    attempts += 1;
                    Console.ReadKey();

                }


            }

            

        }
       
    }
    

}
