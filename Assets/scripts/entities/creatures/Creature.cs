using entities;
using religions;

namespace creatures.sub_creatures
{
    public class Creature : BehaviourEntity
    {
        private Religion _religion { get; } public Religion Religion {get{return _religion;}}

        public Creature(string title, string plural, string description, Religion religion) : base(title, plural, description) { _religion = religion; }
    }
}

