using System;
using System.Collections;
using System.Collections.Generic;
using entities;

using UnityEngine;

namespace scripts;

public class Game
{

    private List<Community> communities = new List<Community>();
    private Community.Calendar worldAge {get;}
    
    public List<Community> Add_Community(Community community)
    {
        communities.Add(community);
        if (communities.Count==1)
        {
            worldAge = community.Get_Calendar();
            worldAge.Set_Title("World age");
        }
    }

    public void End_Of_Day() {
        for (int i = 0; i < communities.Count;i++)
        {
            communities[i].endOfDay();
        }
        worldAge.next();
    }
}