using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LoopGame
{
    public class EscapeRoom
    {
        private RoomObject Painting;
        private RoomObject Box;
        private RoomObject Fridge;
        private RoomObject Drawer;
        private Door LockedDoor;
        private bool HasEscaped;



        public EscapeRoom()
        {
            Painting = new RoomObject("painting", "There's a big dog on the painting, you can see it's name on the collar - \"Bobby\"");
            Box = new RoomObject("box", "You have found a fleshlight!");
            Fridge = new RoomObject("fridge", "What an awful smell... Did something die here?");
            Drawer = new RoomObject("drawer", "You've found a note! It says \"You will find an answer on the painting...\"");
            LockedDoor = new Door("bobby");
            HasEscaped = false;


        }
        public void Start()

        {
            Console.WriteLine("You're waking up in a dark room...");
            Console.WriteLine("(press any key to continue)");
            Console.ReadKey(true);

            while (!HasEscaped)
            {
                string choice = ChooseOption();

                if (choice == "1")
                {
                    Painting.DisplayInfo();
                }
                else if (choice == "2")
                {
                    Box.DisplayInfo();
                }
                else if (choice == "3")
                {
                    Fridge.DisplayInfo();
                }
                else if (choice == "4")
                {
                    Drawer.DisplayInfo();
                }
                else if (choice == "5")
                {
                    bool wasSuccessful= LockedDoor.Escape();
                    HasEscaped = wasSuccessful;

                }
                else
                {
                    Console.WriteLine("Wrong answer, try again");
                }
            }

            Console.WriteLine("Congrats");
        }

        private string ChooseOption()
        {
            Console.WriteLine("What would you like to check?");
            Console.WriteLine("1 - Painting, 2 - Box, 3 - Fridge, 4 - Drawer, 5 - Exit the room");

            string userSelection = Console.ReadLine().Trim();

            return userSelection;
        }



    }
}
