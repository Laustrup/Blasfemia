using commandments;
using entities;
using tools.Liszt;

/* A religion is a set of commandments, that will interact with the rules of a community
 */

namespace religions
{
    // Author Laust Eberhardt Bonnesen
    public abstract class Religion : BehaviourEntity {

        protected Liszt<Commandment> _commandments { get; set; } public Liszt<Commandment> Commandments { get{return _commandments;} }

        public Religion(string title, string plural, string description) : base(title,plural,description) { _commandments = new Liszt<Commandment>(); }
        
        public Liszt<Commandment> AddCommandment(Commandment commandment)
        {
            _commandments.Add(commandment);
            return _commandments;
        }
        
        public Liszt<Commandment> AddCommandments(Commandment[] commandments)
        {
            _commandments.Add(commandments);
            return _commandments;
        }

    }
}


