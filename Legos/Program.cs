using Legos.Minifigures;
using Legos.Minifigures.Parts;
using Legos.Minifigures.Parts.Legs;
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

            var legs = new ZombieLegs();

            var yodaYetiZombie = new Minifigure(head, torso, legs);
            yodaYetiZombie.Battle();

            var fatHead = new FatHead();
            var pirateTorso = new PirateTorso(HandType.Hook);
            var centaurLegs = new CentaurLegs();

            var fatHeadedCentaurPirate = new Minifigure(fatHead, pirateTorso, centaurLegs);
            fatHeadedCentaurPirate.Battle();
        }
    }
}
