using creatures;
using buildings;
using religions;
using subservices;
using tools;

namespace entities;

/* Community is functioning as a team of either a god or gods, which determines whether it's mono-/polytheism.
 * 
 * The community has its own calendar, which differs from the games main calendar and is created from the time
 * that it takes to create its community.
 *
 * There's a _communityService, that is responsive for all logic actions.
 */

// Author Laust Eberhardt Bonnesen
public class Community : BehaviourEntity 
{

    // Single entity attributes
    private Religion _religion {get;} public Religion Religion { get{return _religion;}}
    private Calendar _calendar { get; } public Calendar Calendar { get { return _calendar; } }
    private CommunityService _communityService = new CommunityService();
    
    // Liszts of entities
    private Liszt<Follower> _followers {get; set; } public Liszt<Follower> Followers { get{return _followers;} set{_followers = value;}}
    private Liszt<Building> _buildings {get; set; } public Liszt<Building> Buildings { get{return _buildings;} set{_buildings = value;}}
    private Liszt<God> _gods {get; set; } public Liszt<God> Gods { get{return _gods;} set{_gods=value;}}

    // Boolean attributes
    private bool _isMonotheism {get; set; } public bool IsMonotheism { get{return _isMonotheism;} set{_isMonotheism = value;}}

    // Interacting attributes
    private float _faith { get; set; } public int Faith {get{return (int) _faith;}}
    private float _loyalty { get; set; } public int Loyalty {get{return (int) _loyalty;}}
    private float _happiness { get; set; } public int Happiness {get{return (int) _happiness;}}

    private double _wealth {get; set;} public int Wealth {get{return (int) _wealth;}}
    private double _income {get; set;}
    private double _taxPercentage {get; set;} public double TaxPercentage {set{_taxPercentage += value;}} 


    public Community(string title, string description,
                    Religion religion, Liszt<God> gods,
                    double taxPercentage) : base(title,description) 
    {
        _religion = religion;
        _gods = gods;

        if (gods.Size==1) {_isMonotheism=true;}
        else if (gods.Size>1) {_isMonotheism=false;}

        _followers = new Liszt<Follower>();
        _buildings = new Liszt<Building>();

        _wealth = 0;
        _taxPercentage = taxPercentage;
    }
    
    public Liszt<Follower> Add_Follower(Follower follower) { _followers.Add(follower); return _followers; }
    public Liszt<God> Add_God(God god) { _gods.Add(god); return _gods; }
    public void Update() 
    {
        commandmentEffectFollowers();
        _faith = _communityService.calculateFaith(_followers);
        _loyalty = _communityService.calculateLoyalty(_followers);
        _happiness = _communityService.calculateHappiness(_followers);
        _income = _communityService.calculateIncome(_followers, _taxPercentage);
    }

    private void commandmentEffectFollowers() { for (int i = 1; i < _followers.Size; i++) { _followers.Get(i); } }

    private double payTaxes() 
    {
        _wealth += _income;
        return _wealth;
    }
}