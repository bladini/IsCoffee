using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resurstillf
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            string message;
            while (!done)
            {
                Console.WriteLine("Write a message: ");
                message = Console.ReadLine();
                if (FunExamples.ContainsCoffee(message))
                {
                    Console.WriteLine("You've got the coffee!");
                } 
                else if(message == "q")
                {
                    done = true;
                }
                else
                {
                    Console.WriteLine("No coffee today!");
                }
            }
            Console.WriteLine("Bye, bye!");
        }
    }
}
