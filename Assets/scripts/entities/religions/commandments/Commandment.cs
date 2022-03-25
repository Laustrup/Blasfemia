using entities/BehaviourEntity;

namespace commandments;

public class Commandment : BehaviourEntity {

    private float faithEffect {get;}
    private float loyaltyEffect {get;}
    private float happinessEffect {get;}
    private double incomeEffect {get;}

    public Commandment(string title, string description,
                        float faithEffect, float loyaltyEffect,
                        float happinessEffect, double incomeEffect) : base(title,description) {
        this.faithEffect = faithEffect;
        this.loyaltyEffect = loyaltyEffect;
        this.happinessEffect = happinessEffect;
        this.incomeEffect = incomeEffect;
    }

}