using Legos.Minifigures.Parts;

namespace Legos.Minifigures
{
    class Minifigure
    {
        readonly Head _head;
        readonly Torso _torso;
        readonly LegBase _legs;

        public Minifigure(Head head, Torso torso, LegBase legs)
        {
            _head = head;
            _torso = torso;
            _legs = legs;
        }
        
        public void Battle()
        {
            _head.Talk();
            _torso.Flex();
            _torso.Fight();
            _legs.Kick();
        }
    }
}
