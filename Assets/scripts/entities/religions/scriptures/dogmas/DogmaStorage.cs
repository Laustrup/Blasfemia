using dogmas.sub_dogmas;
using tools;

/* This storage is made to be a collection of all existing Dogmas.
 *
 * The purpose of this class is to be able to get a default dogma, by higher performance.
 */

namespace dogmas
{
    // Author Laust Eberhardt Bonnesen
    public static class DogmaStorage
    {
        
        
        public static Liszt<Dogma> dogmas = new Liszt<Dogma>(new Dogma[]
        {
            new Charity()
        });

        public static Dogma GetCharity() { return dogmas.Get( "Charity" + "\n\n\t" + "Love thy neighbour <3" + "\n\n"); }
        
        public static Dogma Get(string toString) { return dogmas.Get(toString); }
    }
}