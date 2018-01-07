﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPA_Musicsheets.Models
{
    public class Song
    {
        public List<Bar> Bars { get; set; }
        public List<Repetition> Repetitions { get; set; }
        public int BeatNote { get; set; }
        public int BeatPerBar { get; set; }
        public int Bpm { get; set; }

    }
}
