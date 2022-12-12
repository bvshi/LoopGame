using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopGame
{
    class RoomObject
    {
        public string Name;
        public string Description;

        public RoomObject(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"You are checking the {Name}.");
            Console.WriteLine(Description);
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
        }
    }
}
