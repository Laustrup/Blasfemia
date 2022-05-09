using scripts;
using tools;
using UnityEngine;

/* This behaviour class is meant as a base for other logical classes. It is the highest form of base.
 *
 * It has some attributes, that all logical classes posses.
 *
 * Also adapts the MonoBehaviour from UnityEngine, which allows for game actions such as Update().
 */

namespace entities
{
    // Author Laust Eberhardt Bonnesen
    public class BehaviourMind : MonoBehaviour
    {
        // Primary attributes
        protected string _title { get; set; } public string Title { get{return _title;} set{_title = value;}}
        protected string _description { get; } public string Description { get{return _description;}}
        
        // Interacting attributes
        protected float _faith { get; set; } public float Faith { get{return _faith;} } 
        protected float _loyalty { get; set; } public float Loyalty { get{return _loyalty;} }
        protected float _happiness { get; set; } public float Happiness { get{return _happiness;} }
        protected double _income { get; set; } public double Income { get{return _income;} }

        public BehaviourMind(string title, string description)
        {
            _title = title;
            _description = description;
        }
        
        public BehaviourMind(string title, string description,
                            float faithEffect, float loyaltyEffect, float happinessEffect,
                            double incomeEffect) 
        {
            _title = title;
            _description = description;

            SetInteractingAttributes(faithEffect, loyaltyEffect, happinessEffect, incomeEffect);
        }

        public bool HasEffectAttributes() {return _faith!=null&&_loyalty!=null&&_happiness!=null&&_income!=null;}
        public Liszt<object> SetInteractingAttributes(float faithEffect, float loyaltyEffect, float happinessEffect,
            double incomeEffect)
        {
            _faith = faithEffect;
            _loyalty = loyaltyEffect;
            _happiness = happinessEffect;
            _income = incomeEffect;

            return new Liszt<object>(new object[] {_faith,_loyalty,_happiness,_income});
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
