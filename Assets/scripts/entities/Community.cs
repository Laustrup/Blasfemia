using creatures.sub_creatures;
using buildings;
using commandments;
using religions;
using services;
using tools;

/* Community is functioning as a team of either a god or gods, which determines whether it's mono-/polytheism.
 * 
 * The community has its own calendar, which differs from the games main calendar and is created from the time
 * that it takes to create its community.
 *
 * There's a _communityService, that is responsive for all logic actions.
 */

namespace entities
{
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

        public Community(string title, string plural, string description,
                        Religion religion, Liszt<God> gods,
                        double taxPercentage) : base(title,plural,description,
                                                    0,0,0,0,taxPercentage) 
        {
            _religion = religion;
            _gods = gods;

            if (gods.Size==1) {_religion.IsMonotheism=true;}
            else if (gods.Size>1) {_religion.IsMonotheism=false;}

            _followers = new Liszt<Follower>();
            _buildings = new Liszt<Building>();

            _wealth = 0;
            _taxPercentage = taxPercentage;
        }
        
        public Liszt<Follower> Add_Follower(Follower follower) { _followers.Add(follower); return _followers; }
        public Liszt<God> Add_God(God god) { _gods.Add(god); return _gods; }
        public void Update()
        {
            Liszt<Commandment> commandments = Religion.Scripture.Commandments;
            for (int i = 1; i <= commandments.Size; i++)
            {
                IncreaseFaith(commandments.Get(i).Faith);
                IncreaseLoyalty(commandments.Get(i).Loyalty);
                IncreaseHappiness(commandments.Get(i).Happiness);
                IncreaseIncome(commandments.Get(i).Income);
            }
            _wealth += CalculateTaxAmount();
        }

        private double CalculateTaxAmount()
        {
            double taxAmount = 0;
            for (int i = 1; i <= _followers.Size; i++)
            {
                Follower follower = _followers.Get(i);
                taxAmount += follower.Wealth * follower.TaxPercentage;
            }
            return taxAmount;
        }
    }
}
