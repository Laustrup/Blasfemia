namespace entities.creatures;

public class God : BehaviourEntity {

    protected bool _isImmortal {get;} public bool IsImmortal {get{return _isImmortal;}}
    protected bool _isEvil {get; set; } public bool IsEvil {get{return _isEvil;}set{_isEvil = value;}}

    public God(string title, string description, bool isImmortal, bool isEvil) : base(title, description)
    {
        _isImmortal = isImmortal;
        _isEvil = isEvil;
    }
}