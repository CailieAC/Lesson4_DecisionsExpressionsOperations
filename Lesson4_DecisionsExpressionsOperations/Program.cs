using System;

namespace Lesson4_DecisionsExpressionsOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2, or 3: ");
            string userValue = Console.ReadLine();

            string message = "Sorry, we didn't understand.";

            if (userValue == "1")
                message = "You won a new car!";
            else if (userValue == "2")
                message = "You won a new boat!";
            else if (userValue == "3")
                message = "You won a new cat!";
            else
                message += " You lose.";

            Console.WriteLine(message);
            Console.ReadLine();
            */

            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2, or 3: ");
            string userValue = Console.ReadLine();

            //This approach works for if/else (two options):
            string message = (userValue == "1") ? "boat" : "strand of lint";
            
            //Console.Write("You won a ");
            //Console.Write(message);
            //Console.Write(".");
            //Below placeholder {0} is replaced by the variable, after
            Console.WriteLine("You entered: {0}, therefore you won a {1}.", userValue, message);
            Console.ReadLine();

        }
    }
}
