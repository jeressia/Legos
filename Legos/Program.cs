using Legos.Minifigures;
using Legos.Minifigures.Parts;
using System;

namespace Legos
{
    class Program
    {
        static void Main(string[] args)
        {
            var minifigure = new Minifigure();
            minifigure.Head = new YodaHead
            {
                EyeColor = "Brown",
                HairColor = "Blue",
                HasNose = false,
                MouthIsOpen = true,
                NumberOfEyes = 3
            };

            var fatHead = new FatHead();

            fatHead.Talk();
            minifigure.Head.Talk();
        }
    }
}
