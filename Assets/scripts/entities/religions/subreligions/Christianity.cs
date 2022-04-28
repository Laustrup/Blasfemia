using commandments;
using tools;

namespace religions;

// Author Laust Eberhardt Bonnesen
public class Christianity : Religion {

    public Christianity(string title, string description) : base(title, description) { InitialCommandments(); }

    private Liszt<Commandment> InitialCommandments()
    {
        _commandments.Add(new Charity());
        return _commandments;
    }
    
    public Liszt<Commandment> AddCommandment(Commandment commandment)
    {
        _commandments.Add(commandment);
        return _commandments;
    }
    
    public Liszt<Commandment> AddCommandments(Commandment[] commandments)
    {
        _commandments.Add(commandments);
        return _commandments;
    }
}