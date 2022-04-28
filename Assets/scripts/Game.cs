using entities;
using tools;

/* Contains all the communities of a game as a collection.
 *
 * Has the amount of turns in form of the first created Calendar.
 */

// Author Laust Eberhardt Bonnesen
public class Game
{
    private Liszt<Community> communities { get; set; }
    private Calendar worldAge { get; set; }
    
    public Liszt<Community> AddCommunity(Community community)
    {
        if (communities==null) {communities = new Liszt<Community>();}
        communities.Add(community);
        
        if (communities.Size==1)
        {
            worldAge = community.Calendar;
            worldAge.Title = "World age";
            return communities;
        }
        return communities;
        
    }
}