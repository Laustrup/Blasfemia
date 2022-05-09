using commandments;
using creatures.sub_creatures.enums;
using religions;
using tools;

namespace creatures.sub_creatures
{
    // Follower
    public abstract class Follower : Creature {

        // Interacting attributes
        protected float _faith { get; set; } public float Faith {get{return _faith;} set{_faith=value;}} 
        protected float _loyalty { get; set; } public float Loyalty {get{return _loyalty;} set{_loyalty = value;}}
        protected float _happiness { get; set; } public float Happiness {get{return _happiness;} set{_happiness = value;}}
        
        protected double _wealth { get; set; } public double Wealth {get{return _wealth;}} 
        protected double _income { get; set; } public double Income {set{_income = value;}}
        
        protected int _age { get; set; }
        protected AgeState _ageState { get; set; } public AgeState AgeState {get{return _ageState;}}
        
        // Liszts of entities
        protected Liszt<Commandment> _commandments { get; set; }

        public Follower(string title, string plural, string description, Religion religion)
            : base(title,plural,description,religion) 
        {
            _faith = 100;
            _loyalty = 100;
            _happiness = 100;
            _wealth = 0;
            _income = 0;
            _age = 0;
            _ageState = AgeState.Baby;
        }

        public double AddIncomeToWealth() 
        {
            _wealth += _income;
            return _wealth;
        }

        public Liszt<Commandment> AddCommandment(Commandment commandment)
        {
            _commandments.Add(commandment);
            return _commandments;
        }

    }
}
