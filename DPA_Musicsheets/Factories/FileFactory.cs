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
            try
            {
                IFile file = null;
                if (Path.GetExtension(s).EndsWith(".mid")) file = new MidiFile();
                if (Path.GetExtension(s).EndsWith(".ly")) file = new LilypondFile();
                return file;
            }
            catch (Exception e)
            {
                throw new NotSupportedException($"File extension {e} is not supported.");
            }
        }
    }
}