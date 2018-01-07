using DPA_Musicsheets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPA_Musicsheets.Models.Factories
{
    class NoteFactory
    {
        MusicNote create(int key)
        {
            MusicNote note = new MusicNote
            {
                Octave = (key / 12) - 1
            };

            switch (key % 12)
            {
                case 0:
                    {
                        note.Tone = 'C';
                        break;
                    }
                case 1:
                    {
                        note.Tone = 'C';
                        note.Modifier = '#';
                        break;
                    }
                case 2:
                    {
                        note.Tone = 'D';
                        break;
                    }
                case 3:
                    {
                        note.Tone = 'D';
                        note.Modifier = '#';
                        break;
                    }
                case 4:
                    {
                        note.Tone = 'E';
                        break;
                    }
                case 5:
                    {
                        note.Tone = 'F';
                        break;
                    }
                case 6:
                    {
                        note.Tone = 'F';
                        note.Modifier = '#';
                        break;
                    }
                case 7:
                    {
                        note.Tone = 'G';
                        break;
                    }
                case 8:
                    {
                        note.Tone = 'G';
                        note.Modifier = '#';
                        break;
                    }
                case 9:
                    {
                        note.Tone = 'A';
                        break;
                    }
                case 10:
                    {
                        note.Tone = 'A';
                        note.Modifier = '#';
                        break;
                    }
                case 11:
                    {
                        note.Tone = 'B';
                        break;
                    }
                default:
                    break;
            }


            return note;
        }
    }
}
