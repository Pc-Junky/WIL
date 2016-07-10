using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = null;
            string UI = null;
            int exit = 0;
            while (exit == 0)
            {
                Console.WriteLine("Please enter your name");
                name = Console.ReadLine();
                if (name.Equals("Grant")|| name.Equals("grant"))
                {
                    Console.WriteLine("You are a poes");
                }
                else if(name.Equals("Nikheel") || name.Equals("nikheel"))
                {
                    Console.WriteLine("You are a Madhir creater");
                }
                Console.WriteLine("Do you want to exit? Yes or No");
                UI = Console.ReadLine();
                if (UI.Equals("Yes")|| UI.Equals("yes"))
                {
                    Environment.Exit(0);
                }
                
            }
        }
    }
}
