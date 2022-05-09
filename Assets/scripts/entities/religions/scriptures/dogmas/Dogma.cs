using believes;
using entities;
using tools;

/* A principle or statement of ideas, or a group of such principles or statements,
 * especially when considered to be authoritative or accepted uncritically.
 *
 * By other words, this is a collection of believes, which inflicts the commandments.
 *
 * It is the superclass to all the sub_dogmas.
 */

namespace dogmas
{
    // Author Laust Eberhardt Bonnesen
    public abstract class Dogma : BehaviourMind
    {
        protected Liszt<Belief> _believes { get; set; } public Liszt<Belief> Believes { get; set; }
        
        public Dogma(string title, string description, Liszt<Belief> believes) : base(title, description) {_believes = believes;}
        public Dogma(string title, string description) : base(title, description) { }
    }
}