using commandments;
using entities;
using tools;

namespace religions;

/* A religion is a set of commandments, that will interact with the rules of a community
 */

// Author Laust Eberhardt Bonnesen
public abstract class Religion : BehaviourEntity {

    protected Liszt<Commandment> _commandments { get; set; } public Liszt<Commandment> Commandments { get{return _commandments;} }

    public Religion(string title, string description) : base(title,description) { _commandments = new Liszt<Commandment>(); }

}