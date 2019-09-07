using Legos.Minifigures;
using Legos.Minifigures.Parts;
using System;

namespace Legos
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new YodaHead
            {
                EyeColor = "Brown",
                HairColor = "Blue",
                HasNose = false,
                MouthIsOpen = true,
                NumberOfEyes = 3
            };

           var torso = new YetiTorso();

            var minifigure = new Minifigure(head, torso);
            minifigure.Battle();
        }
    }
}
