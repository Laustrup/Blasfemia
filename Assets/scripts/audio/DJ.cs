using System.IO;
using audio.enums;
using tools;
using UnityEngine;

/* Will be able to play audio.
 *
 * There are different kinds oj jockeys, like for music and sounds. Which inherits from this class-
 */

namespace audio
{
    // Author Laust Eberhardt Bonnesen
    public abstract class DJ : MonoBehaviour
    {
        protected static Liszt<AudioClip> _clips { get; set; }
        protected static AudioSource _source { get; set; }

        public DJ()
        {
            _clips = new Liszt<AudioClip>();
            _source = GetComponent<AudioSource>();
        }

        // Methods for playing an audioclip.
        public static bool PlayOnce(ClipTitle title)
        {
            AudioClip clip = FindClip(title);
            
            switch (title)
            {
                case ClipTitle.Cutetrocuted: _source.PlayOneShot(clip); return true;
                default: 
                    Printer.Print("The AudioClip " + title + " Does not exist...", new InvalidDataException());
                    return false;
            }
        }

        private static AudioClip FindClip(ClipTitle title) { return _clips.Get(title.ToString()); }
    }
}


