using UnityEngine;

namespace audio;

public abstract class AudioPlayer : MonoBehaviour
{
    protected Liszt<AudioSource> _sources { get; set; }
    
}