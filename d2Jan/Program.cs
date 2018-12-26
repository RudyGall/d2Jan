using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d2Jan
{
    class Program
    {
        static void Main(string[] args)
        {
            char doAgain;
            int activity, people;
            bool runP = true;
            while (runP == true)
            {
                Console.WriteLine("Hello user, welcome to a last minute deliverable!");
                Console.WriteLine("What type of activity are you in the mood for? (Choose 1-4)");
                Console.WriteLine("1) Action");
                Console.WriteLine("2) Chilling");
                Console.WriteLine("3) Danger");
                Console.WriteLine("4) Good Food");
                activity = Int32.Parse(Console.ReadLine());
                Console.WriteLine("You chose {0}, lets figure out how you will get there!", activity);
                Console.WriteLine("\nHow many people will be accompanying you on your journey? (Choose 0-1000)");
                people = Int32.Parse(Console.ReadLine());
                switch (activity)
                {
                    case 1:
                        Console.Write("If you want action with {0} people, you should go stock car racing and", people);
                        break;
                    case 2:
                        Console.Write("If you want to chill with {0} people, you should go hiking and", people);
                        break;
                    case 3:
                        Console.Write("If you’re in the mood for danger with {0} people, you should go skydiving and", people);
                        break;
                    case 4:
                        Console.Write("If you want good food with {0} people, you should go to Taco Bell and", people);
                        break;
                }
                if (people == 0)
                {
                    Console.WriteLine(" travel in sneakers.");
                }
                else if (people > 0 && people < 5)
                {
                    Console.WriteLine(" travel in a sedan.");
                }
                else if (people > 4 && people < 11)
                {
                    Console.WriteLine(" travel in a Volkswagen Bus.");
                }
                else if (people > 11)
                {
                    Console.WriteLine(" travel in an airplane.");
                }
                Console.WriteLine("\nWould you like to try again? (y or n)");
                doAgain = Convert.ToChar(Console.ReadLine().ToLower());
                if (doAgain == 'n')
                {
                    Console.WriteLine("Thank you, Goodbye!");
                    Console.ReadLine();
                    runP = false;
                }
                else if (doAgain == 'y')
                {
                    runP = true;
                }
                else
                    Console.WriteLine("Invalid entry, try again");
            }
        }
    }
}