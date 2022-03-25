using services/Service;
using creatures;

namespace subservices;

public class CommunityService : Service {

    public int calculateFaith(List<Follower> followers) {
        float totalFaith = 0;
        for (int i = 0; i < followers.size();i++) {
            totalFaith += followers.get(i).getFaith();
        }
        return (followers.size()/totalFaith)*100;
    }

    public int calculateLoyalty(List<Follower> followers) {
        float totalLoyalty = 0;
        for (int i = 0; i < followers.size();i++) {
            totalLoyalty += followers.get(i).getLoyalty();
        }
        return (followers.size()/totalLoyalty)*100;
    }

    public int calculateHappiness(List<Follower> followers) {
        float totalHappiness = 0;
        for (int i = 0; i < followers.size();i++) {
            totalHappiness += followers.get(i).getHappiness();
        }
        return (followers.size()/totalHappiness)*100;
    }

    public double calculateIncome(List<Follower> followers) {
        income = 0;
        for (int i = 0; i < followers.size();i++) {
            income += followers.getWealth()*taxPercentage;
        }
        return income;
    }
}