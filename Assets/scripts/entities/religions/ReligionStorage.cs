using religions.enums;
using religions.sub_religions;
using scripts;
using tools;

/* This storage is made to be a collection of all existing Religions.
 *
 * The purpose of this class is to be able to get a default religion, by higher performance.
 */

namespace religions
{
    // Author Laust Eberhardt Bonnesen
    public static class ReligionStorage
    {

        public static Liszt<Religion> Religions = new Liszt<Religion>(new Religion[]
        {
            new Denose(ReligionType.Mysticism,null),
            new Juchis(ReligionType.Faithful,null),
            new Somevetemajusaurne(ReligionType.Mythical,null)
        });

        public static Religion GetDenose() { return Religions.Get(AttributeBoard.CreateToString("Denose","")); }
        public static Religion GetJuchis() { return Religions.Get(AttributeBoard.CreateToString("Juchis","")); }
        public static Religion GetSomevetemajusaurne() { return Religions.Get(AttributeBoard.CreateToString("Somevetemajusaurne","")); }
        
        public static Religion Get(string toString) { return Religions.Get(toString); }
    }
}