using tools;



namespace believes.sub_believes
{
    // Author Laust Eberhardt Bonnesen
    public static class BelieveStorage
    {
        public static Liszt<Belief> Believes = new Liszt<Belief>(new Belief[]
        {
            
        });
        
        public static Belief Get(string toString) {return Believes.Get(toString);}
    }
}