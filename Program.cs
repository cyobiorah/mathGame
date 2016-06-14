using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webClientTrial
{
    class Program
    {
        static void Main(string[] args)
        {

            //simulating the 6 sided dice roller

            //double raw, big, bigger;
            //int die;
            //Random generator = new Random();

            //raw = generator.NextDouble();
            //Console.WriteLine("raw: {0}", raw);

            //big = raw * 20;
            //Console.WriteLine("big: {0}", big);

            //bigger = big + 1;
            //Console.WriteLine("bigger: {0}", bigger);

            //die = (int)big;
            //Console.WriteLine("die: {0}", die);

            //die = (int) (generator.NextDouble() * 20) + 1;
            //Console.WriteLine("another die: {0}", die);

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Please press the enter key to quit!");
            //Console.ReadLine();


            //creating a simple math game
            
            int a, b, c, guess, score;
            score = 0;
            Random roller = new Random(); //this creates a random number generator
            Console.WriteLine("Welcome to the Math game! I will give you some simple problems to solve.");

            //addition

            a = (int)(roller.NextDouble() * 10) + 1;
            b = (int)(roller.NextDouble() * 10) + 1;
            c = a + b;

            Console.WriteLine("What is {0} + {1}? ", a, b);
            guess = Convert.ToInt32(Console.ReadLine());

            if (guess == c)
            {
                score++;
            }

            //subtraction

            a = (int)(roller.NextDouble() * 10) + 1;
            b = (int)(roller.NextDouble() * 10) + 1;
            c = a + b;

            Console.WriteLine("What is {0} - {1}", c, a);
            guess = Convert.ToInt32(Console.ReadLine());

            if (guess == b)
            {
                score++;
            }

            
            //multiplication

            a = (int)(roller.NextDouble() * 10 + 1);
            b = (int)(roller.NextDouble() * 10 + 1);
            c = a * b;

            Console.WriteLine("What is {0} * {1}", a, b);
            guess = Convert.ToInt32(Console.ReadLine());

            if (guess == c)
            {
                score++;
            }
            

            //division

            a = (int)(roller.NextDouble() * 10 + 1);
            b = (int)(roller.NextDouble() * 10 + 1);
            c = a * b;

            Console.WriteLine("What is {0} / {1}", c, a);
            guess = Convert.ToInt32(Console.ReadLine());

            if (guess == b)
            {
                score++;
            }

            Console.WriteLine("Score: {0} out of 4", score);
            switch (score)
            {
                case 4:
                    Console.WriteLine("You are a genius!");
                    break;
                case 3:
                    Console.WriteLine("You are pretty smart!");
                    break;
                case 2:
                    Console.WriteLine("You could do better!");
                    break;
                case 1:
                    Console.WriteLine("You could make use of more practice!");
                    break;
                case 0:
                    Console.WriteLine("Maybe you were better off in gym classes!");
                    break;
                default:
                    Console.WriteLine("Hey! Something went wrong here!");
                    break;
            } //end switch

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please press the Enter key to quit!");
            Console.ReadLine();

        } //end main
    } //end class
} //end namespace