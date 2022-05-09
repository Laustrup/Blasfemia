using believes;
using tools;

/* This dogma, which is inspired by the Christian values of peace and love
 * 
 */

namespace dogmas.sub_dogmas
{
    // Author Laust Eberhardt Bonnesen
    public class Charity : Dogma
    {
        private Liszt<Belief> _believes { get; set; } public Liszt<Belief> Believes { get{return _believes;}}

        public Charity() : base("Charity", "Love thy neighbour <3") { SetInitialBelieves(); }

        private Liszt<Belief> SetInitialBelieves()
        {
            return new Liszt<Belief>(
                
                );
        }
        
    }
}

