using commandments;
using tools;

namespace religions.sub_religions;

/* Inspired by the Roman/creek religion, mostly in focus of ancient europe.
 * 
 * Named after the planets in order away of the sun, like the roman gods.
 */

// Author Laust Eberhardt Bonnesen
public class Meveeamajusaurne : Religion
{
    public Meveeamajusaurne() : base("Meveeamajusaurne","Meveeamajusaurnes",
        "") { InitialCommandments(); }
    
    private Liszt<Commandment> InitialCommandments()
    {
        //_commandments.Add();
        return _commandments;
    }
}