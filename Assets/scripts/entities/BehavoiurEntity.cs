using System;
using System.Collections;

using UnityEngine;

namespace entities;

public class BehaviourEntity : MonoBehaviour {

    protected string title, description {get;}

    public BehaviourEntity(string title, string description) {
        this.title = title;
        this.description = description;
    }
}