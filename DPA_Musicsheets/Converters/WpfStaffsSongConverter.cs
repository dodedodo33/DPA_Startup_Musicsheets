using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using DPA_Musicsheets.Models;
using PSAMControlLibrary;

namespace DPA_Musicsheets
{
    class WpfStaffsSongConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Song song = (Song)value;
            var symbols = new List<MusicalSymbol>();
            var currentClef = new Clef(ClefType.GClef, 2);
            symbols.Add(currentClef);

            symbols.Add(new TimeSignature(TimeSignatureType.Numbers, UInt32.Parse(song.Bpm + ""), UInt32.Parse(song.BeatPerBar + "")));

            return symbols;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException("Converting back to song is not implemented yet");
        }
    }
}
