﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPA_Musicsheets.Models
{
    class Bar
    {
        public List<Note> _musicNotes { get; set; }
        public Tuple<int, int> Rhythm { get; set; }
    }
}
