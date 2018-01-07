using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPA_Musicsheets.Models;
using Sanford.Multimedia.Midi;

namespace DPA_Musicsheets.Storage
{
    class MidiFile : MusicFile
    {

        public MidiFile(string filename) : base(filename) { }

        public override Song Load()
        {
            var sequence = new Sequence();
            sequence.Load(_filename);

            // TODO: converte to song
            return new Song();
        }

        public override void Save(Song song)
        {
            // TODO: convert to sequence
            var sequence = new Sequence();
            sequence.Save(_filename);
        }
    }
}
