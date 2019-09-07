using System;
using System.Collections.Generic;
using System.Text;

namespace Legos.Minifigures.Parts.Legs
{
    class PirateLegs : LegBase
    {
        public PirateLegs()
        {
           NumberOfLegs = 1;
           PantLength = PantLength.Capris;
           VerticalLeap = 2;
           Barefoot = false;
        }
    }

    class ZombieLegs : LegBase
    {
        public ZombieLegs()
        {
            NumberOfLegs = 0;
            PantLength = PantLength.None;
            VerticalLeap = 0;
            Barefoot = true;
        }
    }

    class CentaurLegs : LegBase
    {
        public CentaurLegs()
        {
            NumberOfLegs = 4;
            PantLength = PantLength.None;
            VerticalLeap = 100;
            Barefoot = true;
        }
    }
}
