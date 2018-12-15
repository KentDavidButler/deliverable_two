using System;

namespace Deliverable_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            String againResponse; 
            int activity, people;
            Random rando = new Random();
            bool again = true;

            while (again)
            {

                Console.WriteLine("Welcome to the What-to-Do App");
                Console.WriteLine("Please choose an activity catagory:");
                Console.WriteLine("1) Action");
                Console.WriteLine("2) Chilling");
                Console.WriteLine("3) Danger");
                Console.WriteLine("4) Good Food");
                Console.WriteLine("5) Learning");
                Console.WriteLine("6) Random Selection");
                Console.WriteLine("");
                activity = Int32.Parse(Console.ReadLine());
                if (activity == 6)
                {
                    activity = rando.Next(1, 6);
                    Console.WriteLine("You chose randome, let me pick something for you.");
                }

                Console.WriteLine("How many people will be joining you?");
                people = Int32.Parse(Console.ReadLine());

                switch (activity)
                {
                    case 1:
                        Console.Write("Okay if you’re in the mood for action, then you should go stock car racing and");
                        break;
                    case 2:
                        Console.Write("Okay if you’re in the mood for chilling, then you should go hicking and");
                        break;
                    case 3:
                        Console.Write("Okay if you’re in the mood for danger, then you should go sky diving and");
                        break;
                    case 4:
                        Console.Write("Okay if you’re in the mood for good food, then you should go to Taco Bell and");
                        break;
                    case 5:
                        Console.Write("Okay if you’re in the mood for learning, then you should go to Grand Circus Boot Camp and");
                        break;
                    default:
                        Console.Write("Okay if you’re in the mood for **ERROR**, then you should go to **ERROR** ERROR **ERROR** and");
                        break;
                }

                if (people == 0)
                {
                    Console.WriteLine(" travel by sneakers.");
                }
                else if (people > 0 && people < 5)
                {
                    Console.WriteLine(" travel by sedan.");
                }
                else if (people > 4 && people < 11)
                {
                    Console.WriteLine(" travel by VW Buss.");
                }
                else
                {
                    Console.WriteLine(" travel by charter buss.");
                }

                Console.WriteLine("Would you like to try again?");
                Console.WriteLine("Type 'y' for Yes and 'n' for No");
                againResponse = Console.ReadLine();

                if(againResponse.Equals("y") || againResponse.Equals("Y"))
                {
                    again = true;
                }
                else
                {
                    again = false;
                }
            }   
            Console.WriteLine("Thank you, Goodbye!");
            Console.Read();
        }
    }
}
