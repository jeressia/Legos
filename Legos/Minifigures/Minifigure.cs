using Legos.Minifigures.Parts;

namespace Legos.Minifigures
{
    class Minifigure
    {
        public Head Head { get; }

        public Torso Torso { get; }

        public Minifigure(Head head, Torso torso)
        {
            Head = head;
            Torso = torso;
        }
        
        public void Battle()
        {
            Head.Talk();
            Torso.Flex();
            Torso.Fight();
        }
    }
}
