using System;
using System.Collections.Generic;
using System.Linq;
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

        public EscapeRoom()
        {
            Painting = new RoomObject("painting", "There are three dogs on the painting. One of it reminds you of Fazi :(");
            Box = new RoomObject("box", "There is a fidget spinner in the box. At least you won't be bored until you get out of here...");
            Fridge = new RoomObject("fridge", "What an awful smell... Did something die here?");
            Drawer = new RoomObject("drawer", "You've found a note! It says \"Your old friend will help you get out of here...\"");
        }
        public void Start()

        {
            Console.WriteLine("You're waking up in a dark room...");
            Console.WriteLine("(press any key to continue)");
            Console.ReadKey(true);

            
            Painting.DisplayInfo();
            Console.ReadKey(true);
            Box.DisplayInfo();
            Console.ReadKey(true);
            Fridge.DisplayInfo();
            Console.ReadKey(true);
            Drawer.DisplayInfo();
            Console.ReadKey(true);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
