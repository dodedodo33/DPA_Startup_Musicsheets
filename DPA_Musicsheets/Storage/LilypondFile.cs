using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPA_Musicsheets.Models;

namespace DPA_Musicsheets.Storage
{
    class LilypondFile : MusicFile
    {

        public LilypondFile(string filename) : base(filename) { }

        public override Song Load()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var line in File.ReadAllLines(_filename))
            {
                sb.AppendLine(line);
            }
            var lilypond = sb.ToString();
            // Sanitize lilypond for conversion
            lilypond = lilypond.Trim().ToLower().Replace("\r\n", " ").Replace("\n", " ").Replace("  ", " ");

            // TODO: return converted song
            return new Song();
        }

        public override void Save(Song song)
        {
            // TODO: convert lilypond
            var lilypond = "";
            using (StreamWriter outputFile = new StreamWriter(_filename))
            {
                outputFile.Write(lilypond);
                outputFile.Close();
            }
        }
    }
}
