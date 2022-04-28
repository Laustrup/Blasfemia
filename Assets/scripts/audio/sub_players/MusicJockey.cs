using UnityEngine;

namespace audio.sub_players;

// Author Laust Eberhardt Bonnesen
public class MusicJockey : DJ
{
    void Start()
    {
        LoadSounds();
    }
    private void LoadSounds() { _clips.Add(Resources.Load<AudioClip>("Cutetrocuted")); }
    
    
}