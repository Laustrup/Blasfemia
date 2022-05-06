using commandments;
using commandments.sub_commandments;
using tools.Liszt;

/* Inspired by the Abraham religion, mostly in focus of the west.
 *
 * Named after the Abraham religions first two letters.
 */

namespace religions.sub_religions
{
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
}

