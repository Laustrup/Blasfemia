using commandments;
using dogmas;
using entities;
using tools;

/* This is the collection and logic for a religion's dogmas and commandments
 *
 */

namespace religions.scriptures
{
    // Author Laust Eberhardt Bonnesen
    public class Scripture : BehaviourMind
    {
        
        /* The dogmas will be interfering with each commandments, depending on it's type.
         *
         * The commandments are the set of rules that followers of the community follows, therefore
         * it has an influence on the interacting attributes.
         */
        protected Liszt<Dogma> _dogmas { get; set; } public Liszt<Dogma> Dogmas { get{return _dogmas;} }
        protected Liszt<Commandment> _commandments { get; set; } public Liszt<Commandment> Commandments { get{return _commandments;} }

        public Scripture(string title, string description, 
                        Liszt<Dogma> dogmas, Liszt<Commandment> commandments) : base(title, description)
        {
            _dogmas = dogmas;
            _commandments = commandments;
        }

        public Liszt<Commandment> InflictDogmas()
        {
            ResetCommandments();
            for (int i = 1; i <= _commandments.Size; i++)
            {
                for (int j = 1; j <= _dogmas.Size; j++) {_commandments.Get(i).InflictDogma(_dogmas.Get(j));}
            }
            return _commandments;
        }
        private Liszt<Commandment> ResetCommandments()
        {
            Liszt<Commandment> reset = new Liszt<Commandment>();
            for (int i = 1; i <= _commandments.Size;i++) { reset.Add(CommandmentStorage.Get(_commandments.Get(i).ToString())); }
            _commandments = reset;
            return reset;
        }
    }
}