using entities;
using religions;

namespace buildings
{
    public class Building : BehaviourEntity
    {
        private Religion _religion { get; } public Religion Religion {get{return _religion;}}
        
        public Building(string title, string plural, string description, Religion religion) : base(title,plural, description)
        {
            _religion = religion;
        }
    }
}

