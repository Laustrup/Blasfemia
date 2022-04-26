using UnityEngine;

namespace audio.sub_players;

public class MusicPlayer : AudioPlayer
{
    void Start()
    {
        _sources = new Liszt<AudioSource>();
        AddPaths();
    }

    private void AddPaths()
    {
        // List of Paths
        _sources.Add(GetComponent<AudioSource>("Assets/audios/Cutetrocuted.mp3"));
    }
    
    
}