using tools;
using UnityEngine;

namespace dogmas
{
    public class Dogma : MonoBehaviour
    {
        protected Liszt<Belief> _believes { get; set; } public Liszt<Belief> Believes { get; set; }
        
        public Dogma(Liszt<Belief> believes) {_believes = believes;}
    }
}