using services;
using creatures;
using tools;

namespace services.sub_services;

/* This is where all the logic of a community is written
 */

// Author Laust Eberhardt Bonnesen
public class CommunityService : Service {

    // Methods for calculating interacting attributes
    public float calculateFaith(Liszt<Follower> followers) 
    {
        float totalFaith = 0;
        for (int i = 0; i < followers.Size;i++) { totalFaith += followers.Get(i).Faith; }
        return (followers.Size/totalFaith)*100;
    }
    public float calculateLoyalty(Liszt<Follower> followers) 
    {
        float totalLoyalty = 0;
        for (int i = 0; i < followers.Size;i++) { totalLoyalty += followers.Get(i).Loyalty; }
        return (followers.Size/totalLoyalty)*100;
    }
    public float calculateHappiness(Liszt<Follower> followers) 
    {
        float totalHappiness = 0;
        for (int i = 0; i < followers.Size;i++) { totalHappiness += followers.Get(i).Happiness; }
        return (followers.Size/totalHappiness)*100;
    }
    public double calculateIncome(Liszt<Follower> followers, double taxPercentage) 
    {
        double income = 0;
        for (int i = 0; i < followers.Size;i++) { income += followers.Get(i).Wealth*taxPercentage; }
        return income;
    }
}