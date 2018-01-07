using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using DPA_Musicsheets.Models;
using Sanford.Multimedia.Midi;

namespace DPA_Musicsheets
{
    class MidiSongConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Song song = (Song)value;

            return new Sequence();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Sequence sequence = (Sequence)value;

            return new Song();
        }
    }
}
