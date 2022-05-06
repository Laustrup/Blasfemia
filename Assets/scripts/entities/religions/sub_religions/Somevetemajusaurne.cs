using commandments;
using tools.Liszt;

/* Inspired by the Roman/creek religion, mostly in focus of ancient europe.
 * 
 * Named after the planets in order away of the sun, like the roman gods.
 */

namespace religions.sub_religions
{
    // Author Laust Eberhardt Bonnesen
    public class Somevetemajusaurne : Religion
    {
        public Somevetemajusaurne() : base("Meveeamajusaurne","Meveeamajusaurnes",
                "") { InitialCommandments(); }
            
            private Liszt<Commandment> InitialCommandments()
            {
                //_commandments.Add();
                return _commandments;
            }
    }
}

