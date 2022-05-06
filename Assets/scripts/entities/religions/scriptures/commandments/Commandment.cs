/* An Commandment is what manipulates the interacting attributes of a community.
 *
 * It is part of a chosen religion.
 */

using entities;

namespace commandments.sub_commandments
{
    // Author Laust Eberhardt Bonnesen
    public abstract class Commandment : BehaviourEntity {

        protected float _faithEffect {get;}
        protected float _loyaltyEffect {get;}
        protected float _happinessEffect {get;}
        protected double _incomeEffect {get;}

        public Commandment(string title, string plural, string description,
                            float faithEffect, float loyaltyEffect,
                            float happinessEffect, double incomeEffect) : base(title,plural,description) {
            _faithEffect = faithEffect;
            _loyaltyEffect = loyaltyEffect;
            _happinessEffect = happinessEffect;
            _incomeEffect = incomeEffect;
        }
    }
}