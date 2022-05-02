using entities;

namespace creatures;

/* A god is a player, that is part of a community
 */

// Author Laust Eberhardt Bonnesen
public abstract class God : BehaviourEntity {

    // Boolean attributes
    protected bool _isImmortal {get;} public bool IsImmortal {get{return _isImmortal;}}
    protected bool _isEvil {get; set; } public bool IsEvil {get{return _isEvil;}set{_isEvil = value;}}

    public God(string title, string description, bool isImmortal, bool isEvil) : base(title,null, description)
    {
        _isImmortal = isImmortal;
        _isEvil = isEvil;
    }
}