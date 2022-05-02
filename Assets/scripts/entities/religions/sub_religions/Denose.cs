using commandments;
using tools;

namespace religions.sub_religions;

/* Inspired by the Assa religion, mostly in focus of scandinavia.
 *
 * Named after the Scandinavian countries first to letters.
 */

// Author Laust Eberhardt Bonnesen
public class Denose : Religion
{
    
    public Denose() : base("Denose", "Denoses",
        "") { InitialCommandments(); }
    
    private Liszt<Commandment> InitialCommandments()
    {
        //_commandments.Add();
        return _commandments;
    }
    
}