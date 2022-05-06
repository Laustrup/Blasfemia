using commandments.sub_commandments;
using entities;
using religions.enums;
using religions.scriptures;
using tools;

/* A religion is a set of commandments, that will interact with the rules of a community
 */

namespace religions
{
    // Author Laust Eberhardt Bonnesen
    public abstract class Religion : BehaviourEntity {
        
        protected ReligionType _type { get; set; } public ReligionType Type { get{return _type;} }
        protected Scripture _scripture { get; set; } public Scripture Scripture { get{return _scripture;} }

        public Religion(string title, string plural, string description, ReligionType type, Scripture scripture) : base(title, plural, description)
        {
            _type = type;
            _scripture = scripture;
        }
    }
}


