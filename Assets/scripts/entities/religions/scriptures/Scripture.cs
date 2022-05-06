using System.Collections.Generic;
using commandments.sub_commandments;
using dogmas;
using tools;
using UnityEngine;

namespace religions.scriptures
{
    public class Scripture : MonoBehaviour
    {
        protected Liszt<Dogma> _dogmas { get; set; } public Liszt<Dogma> Dogmas { get; set; }
        protected List<Commandment> _commandments { get; set; } public Liszt<Commandment> Commandments { get; set; }

        public Scripture(Liszt<Dogma> dogmas, List<Commandment> commandments)
        {
            _dogmas = dogmas;
            _commandments = commandments;
        }
    }
}