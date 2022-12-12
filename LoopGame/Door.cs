using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopGame
{
    class Door
    {
        private string Code;

        public Door(string code)
        {
          Code = code;
        }

        public bool Escape()
        {
            Console.WriteLine("You walk into the door and it's locked. You need a special password.");
            Console.WriteLine("Please enter the password:");

            string escapeAttempt = Console.ReadLine().ToLower().Trim();
            if (escapeAttempt == Code)
            {
                Console.WriteLine("The password is correct! You have escaped the room.");
                Console.WriteLine("press any key to continue");
                Console.ReadKey(true);
                return true;
            }
            else
            {
                Console.WriteLine("The password is incorrect. Please try again.");
            }
            Console.WriteLine("press any key to continue");
            Console.ReadKey(true);
            return false;
        }
    }
}
