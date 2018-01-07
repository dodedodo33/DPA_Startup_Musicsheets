using DPA_Musicsheets.Models;

namespace DPA_Musicsheets.Storage
{
    public abstract class MusicFile
    {
        protected string _filename;

        public MusicFile(string filename)
        {
            _filename = filename;
        }

        public abstract Song Load();

        public abstract void Save(Song song);
    }
}