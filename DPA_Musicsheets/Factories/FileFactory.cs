using System;
using System.IO;
using DPA_Musicsheets.Interfaces;
using DPA_Musicsheets.Models;

namespace DPA_Musicsheets.Factories
{
    public class FileFactory
    {
        public IFile OpenFile(string s)
        {
            if (Path.GetExtension(s).EndsWith(".mid")) return new MidiFile();
            if (Path.GetExtension(s).EndsWith(".ly")) return new LilypondFile();
            return null;
        }
    }
}