using tools;

/* This storage is made to be a collection of all existing Commandments.
 *
 * The purpose of this class is to be able to get a default commandment, by higher performance.
 */

namespace commandments
{
    public static class CommandmentStorage
    {
        public static Liszt<Commandment> commandments = new Liszt<Commandment>(new Commandment[]
            {
                
            });
        
        public static Commandment Get(string toString) { return commandments.Get(toString);}
    }
}