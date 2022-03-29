using System.Collections.Generic;
using entities;

public class Game
{

    private List<Community> communities { get; set; }
    private Calendar worldAge { get; set; }
    
    public List<Community> Add_Community(Community community)
    {
        if (communities==null) {communities = new List<Community>();}
        communities.Add(community);
        
        if (communities.Count==1)
        {
            worldAge = community.Calendar;
            worldAge.Title = "World age";
            return communities;
        }
        return communities;
        
    }

    public void End_Of_Day() {
        for (int i = 0; i < communities.Count;i++)
        {
            communities[i].endOfDay();
        }
        worldAge.Next();
    }
}