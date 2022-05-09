using scripts;
using tools;
using UnityEngine;

/* This behaviour class is meant as a base for other entities. It is the highest form of base.
 *
 * It has some attributes, that all entities posses.
 *
 * Also adapts the MonoBehaviour from UnityEngine, which allows for game actions such as Update().
 */

namespace entities
{
    // Author Laust Eberhardt Bonnesen
    public abstract class BehaviourEntity : MonoBehaviour {
        
        // Primary attributes
        protected string _title { get; set; } public string Title { get{return _title;} set{_title = value;}}
        protected string _plural { get; set; } public string Plural { get{return _plural;} set{_plural = value;} }
        protected string _description { get; } public string Description { get{return _description;}}
        
        // Interacting attributes
        protected float _faith { get; set; } public float Faith { get{return _faith;} } 
        protected float _loyalty { get; set; } public float Loyalty { get{return _loyalty;} }
        protected float _happiness { get; set; } public float Happiness { get{return _happiness;} }
        protected double _wealth {get; set;} public int Wealth { get{return (int) _wealth;} }
        protected double _income { get; set; } public double Income { get{return _income;} }
        protected double _taxPercentage {get; set;} public double TaxPercentage 
        { 
            get{return _taxPercentage;}
            set{_taxPercentage += value;}
        } 

        public BehaviourEntity(string title, string plural, string description) 
        {
            _title = title;
            _plural = plural;
            _description = description;
        }
        public BehaviourEntity(string title, string plural, string description,
                                float faithEffect, float loyaltyEffect, float happinessEffect,
                                double incomeEffect, double taxPercentage) 
        {
            _title = title;
            _plural = plural;
            _description = description;

            _taxPercentage = taxPercentage;

            SetInteractingAttributes(faithEffect, loyaltyEffect, happinessEffect, 0, incomeEffect);
        }
        
        public bool HasEffectAttributes() {return _faith!=null&&_loyalty!=null&&_happiness!=null&&_income!=null;}
        public Liszt<object> SetInteractingAttributes(float faithEffect, float loyaltyEffect, float happinessEffect,
                                                        double wealth, double incomeEffect)
        {
            _faith = faithEffect;
            _loyalty = loyaltyEffect;
            _happiness = happinessEffect;
            _wealth = wealth;
            _income = incomeEffect;

            return new Liszt<object>(new object[] {_faith,_loyalty,_happiness,_wealth,_income});
        }

        public float IncreaseFaith(float amount)
        {
            _faith += amount;
            return _faith;
        }
        public float IncreaseLoyalty(float amount)
        {
            _loyalty += amount;
            return _loyalty;
        }
        public float IncreaseHappiness(float amount)
        {
            _happiness += amount;
            return _happiness;
        }
        public double IncreaseIncome(float amount)
        {
            _income += amount;
            return _income;
        }
        public double IncreaseIncome(double amount)
        {
            _income += amount;
            return _income;
        }
        
        public override string ToString()
        {
            return AttributeBoard.CreateToString(_title,_description);
        }
    }
}
