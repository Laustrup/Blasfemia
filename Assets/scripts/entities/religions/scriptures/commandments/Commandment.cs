using commandments.enums;
using believes;
using dogmas;
using entities;

/* An Commandment is what manipulates the interacting attributes of a community.
 *
 * It is part of a chosen religion.
 */

namespace commandments
{
    // Author Laust Eberhardt Bonnesen
    public abstract class Commandment : BehaviourMind {

        protected CommandmentType _type { get; } public CommandmentType Type { get{return _type;} }

        public Commandment(string title, string description, CommandmentType type,
                            float faith, float loyalty, float happiness, double income) : base(title,description,
                                                    faith,loyalty,happiness,income) { _type = type; }

        public void InflictDogma(Dogma dogma)
        {
            for (int i = 1; i <= dogma.Believes.Size; i++) { AffectInteractingAttributes(dogma.Believes.Get(i)); }
        }

        private void AffectInteractingAttributes(Belief belief)
        {
            _faith += belief.Faith;
            _loyalty += belief.Loyalty;
            _happiness += belief.Happiness;
            _income += belief.Income;
        }
    }
}