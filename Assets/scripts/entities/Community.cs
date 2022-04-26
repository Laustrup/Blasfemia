using System.Collections.Generic;
using creatures;
using buildings;
using entities.creatures;
using religions;
using subservices;

namespace entities;

public class Community : BehaviourEntity {

    private Religion _religion {get;} public Religion Religion { get{return _religion;}}
    
    private List<Follower> _followers {get; set; } public List<Follower> Followers { get{return _followers;} set{_followers = value;}}
    private List<Building> _buildings {get; set; } public List<Building> Buildings { get{return _buildings;} set{_buildings = value;}}
    private List<God> _gods {get; set; } public List<God> Gods { get{return _gods;} set{_gods=value;}}

    private bool _isMonotheism {get; set; } public bool IsMonotheism { get{return _isMonotheism;} set{_isMonotheism = value;}}

    private Calendar _calendar { get; }
    public Calendar Calendar { get { return _calendar; } }

    private float faith {get;}
    private float loyalty {get;}
    private float happiness {get;}

    private double wealth {get; set;}
    private double income {get; set;}
    private double taxPercentage {get; set;}

    private CommunityService communityService = new CommunityService();

    public Community(string title, string description,
                    Religion religion, List<God> gods,
                    double taxPercentage) : base(title,description) {

        this._religion = religion;
        this._gods = gods;

        if (gods.Count==1) {_isMonotheism=true;}
        else if (gods.Count>1) {_isMonotheism=false;}

        _followers = new List<Follower>();
        _buildings = new List<Building>();

        wealth = 0;
        this.taxPercentage = taxPercentage;
        
    }
    
    public List<Follower> Add_Follower(Follower follower) { _followers.Add(follower); return _followers; }
    public List<God> Add_God(God god) { _gods.Add(god); return _gods; }
    public void Update() {

        commandmentEffectFollowers();
        faith = communityService.calculateFaith();
        loyalty = communityService.calculateLoyalty();
        happiness = communityService.calculateHappiness();
        income = communityService.calculateIncome();
    }

    private void commandmentEffectFollowers() {
        for (int i = 0; i < _followers.Count; i++) {
            _followers.get(i).commandmentsEffect(List<Commandments> _religion.getCommandments());
        }
    }

    private double payTaxes() {
        wealth += income;
        return wealth;
    }
    
    public Calendar endOfDay() {
        calendar.next();
        payTaxes();
        return calendar;
    }
    
}