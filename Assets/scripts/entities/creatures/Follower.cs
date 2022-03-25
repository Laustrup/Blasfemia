using entities/BehaviourEntity;
using commandments;

namespace creatures;

public class Follower : BehaviourEntity {

    private float faith {get; set;}
    private float loyalty {get; set;}
    private float happiness {get; set;}
    private double wealth {get; set;}
    private double income {get; set;}

    public Follower(string title, string description) : base(title, description) {
        faith = 100;
        loyalty = 100;
        happiness = 100;
        wealth = 0;
        income = 0;
    }

    public double addIncomeToWealth() {
        wealth += income;
        return wealth;
    }

    public abstract void commandmentsEffect(List<Commandments> commandments);
}