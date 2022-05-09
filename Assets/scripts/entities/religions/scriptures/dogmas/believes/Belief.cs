using commandments;
using commandments.enums;
using entities;
using tools;

namespace believes
{
    public class Belief : BehaviourMind
    {
        private Liszt<BeliefEffect> _beliefEffects { get; }

        public Belief(string title, string description, Liszt<BeliefEffect> effects) 
            : base(title, description) { _beliefEffects = effects; }

        public Commandment Act(Commandment commandment)
        {
            for (int i = 1; i < _beliefEffects.Size; i++)
            {
                if (commandment.Type == _beliefEffects.Get(i).CommandmentType)
                {
                    commandment = ChangeInteractingAttributes(commandment,_beliefEffects.Get(i));
                    break;
                }
            }
            return commandment;
        }

        public Commandment ChangeInteractingAttributes(Commandment commandment, BeliefEffect beliefEffect)
        {
            commandment.IncreaseFaith(beliefEffect.Faith);
            commandment.IncreaseLoyalty(beliefEffect.Loyalty);
            commandment.IncreaseHappiness(beliefEffect.Happiness);
            commandment.IncreaseIncome(beliefEffect.Income);
            return commandment;
        }

        public class BeliefEffect : BehaviourMind
        {
            public CommandmentType CommandmentType { get; }

            public BeliefEffect(string title, string description, CommandmentType commandmentType,
                float faithEffect, float loyaltyEffect, float happinessEffect,
                float incomeEffect) : base(title, description, faithEffect, loyaltyEffect, happinessEffect,
                incomeEffect) { CommandmentType = commandmentType; }
        }
    }
}