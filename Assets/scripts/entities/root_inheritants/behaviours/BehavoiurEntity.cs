
/* This behaviour class is meant as a base for other entities. It is the highest form of base.
 *
 * It has some attributes, that all entities posses.
 *
 * Also adapts the MonoBehaviour from UnityEngine, which allows for game actions such as Update().
 */

namespace entities
{
    // Author Laust Eberhardt Bonnesen
    public abstract class BehaviourEntity : BehaviourMind {
        
        // Primary attributes
        protected string _plural { get; set; } public string Plural { get{return _plural;} set{_plural = value;} }

        // Interacting attributes
        protected double _wealth { get; set; } public double Wealth { get{return _wealth;} }
        protected double _taxPercentage { get; set; } public double TaxPercentage 
        { 
            get{return _taxPercentage;}
            set{_taxPercentage += value;}
        } 

        public BehaviourEntity(string title, string plural, string description) : base(title, description) { _plural = plural; }
        public BehaviourEntity(string title, string plural, string description,
                                float faithEffect, float loyaltyEffect, float happinessEffect,
                                double incomeEffect, double taxPercentage)
                                : base(title, description, faithEffect, loyaltyEffect, happinessEffect, incomeEffect)
        {
            _plural = plural;
            _taxPercentage = taxPercentage;
        }
    }
}
