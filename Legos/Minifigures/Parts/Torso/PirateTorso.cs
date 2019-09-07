using System;
using System.Collections.Generic;
using System.Text;

namespace Legos.Minifigures.Parts
{
    class PirateTorso : Torso
    {
    
        public override bool ChestHair => true;

        public PirateTorso(HandType handType)
        {
            HandType = handType;
            Shirt = "Froofy with ruffles";
        }

        public override void Flex()
        {
            Console.WriteLine("The pirate torso flexed swashedbuckingly."); 
        }

        public override void Fight()
        {
            Console.WriteLine("The pirate torso waves a sword to start a fight.");
        }

    }

enum HandType
{
    Regular,
    Hook,
    None
}

}
