using UnityEngine;

/* This entity is meant as a base for other entities. It is the highest form of base.
 *
 * It has a few attributes, that all entities posses.
 *
 * Also adapts the MonoBehaviour from UnityEngine, which allows for game actions such as Update().
 */

namespace entities
{
    // Author Laust Eberhardt Bonnesen
    public abstract class BehaviourEntity : MonoBehaviour {
        
        protected string _title { get; set; } public string Title { get{return _title;} set{_title = value;}}
        protected string _plural { get; set; } public string Plural {get{return _plural;} set{_plural = value;}}
        protected string _description { get; } public string Description { get{return _description;}}

        public BehaviourEntity(string title, string plural, string description) 
        {
            _title = title;
            _plural = plural;
            _description = description;
        }
    }
}


