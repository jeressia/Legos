using System;
using System.Collections.Generic;
using System.Text;

namespace Legos.Minifigures.Parts
{
    class LegBase
    {
        public int NumberOfLegs { get; set; }
        public PantLength PantLength { get; set; }
        public bool Barefoot { get; set; }
        public int VerticalLeap { get; set; }

        public void Kick()
        {
            UseLegs("kick");
        }

        public void Dance()
        {
            UseLegs("dance");
        }
        public void Walk()
        {
            UseLegs("walk");
        }

        private void UseLegs(string activity)
        {
            var shoesOrBarefoot = Barefoot ? "without shoes" : "with shoes";

            if (NumberOfLegs <= 0)
            {
                Console.WriteLine("No legs, can't {activity}");
                return;
            }

            Console.WriteLine($"The {NumberOfLegs} legs {activity} {shoesOrBarefoot} while wearing {PantLength}");
        }
    }

    enum PantLength
    {
        Shorts,
        Pants,
        Capris,
        None
    }
}
