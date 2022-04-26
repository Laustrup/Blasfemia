using UnityEngine;

namespace entities;

public class BehaviourEntity : MonoBehaviour {
    
    protected string _title { get; set; } public string Title { get{return _title;} set{_title = value;}}
    
    protected string _description { get; } public string Description { get{return _description;}} 

    public BehaviourEntity(string title, string description) {
        _title = title;
        _description = description;
    }
}