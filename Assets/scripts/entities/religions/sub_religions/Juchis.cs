using commandments;
using tools;

namespace religions.sub_religions;

/* Inspired by the Abraham religion, mostly in focus of the west.
 *
 * Named after the Abraham religions first to letters.
 */

// Author Laust Eberhardt Bonnesen
public class Juchis : Religion
{

    public Juchis() : base("Juchis", "Juchisians",
        "") { InitialCommandments(); }

    private Liszt<Commandment> InitialCommandments()
    {
        _commandments.Add(new Charity());
        return _commandments;
    }
}