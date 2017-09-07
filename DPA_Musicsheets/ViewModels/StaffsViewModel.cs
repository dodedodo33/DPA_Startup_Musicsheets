using DPA_Musicsheets.Managers;
using DPA_Musicsheets.Messages;
using GalaSoft.MvvmLight;
using PSAMControlLibrary;
using System.Collections.ObjectModel;
namespace DPA_Musicsheets.ViewModels
{
    public class StaffsViewModel : ViewModelBase
    {
        public ObservableCollection<MusicalSymbol> Staffs { get; set; }
        private FileHandler _fileHandler;

        public StaffsViewModel(FileHandler fileHandler)
        {
            _fileHandler = fileHandler;
            Staffs = new ObservableCollection<MusicalSymbol>();

            _fileHandler.WpfStaffsChanged += (src, args) =>
            { 
                Staffs.Clear();
                foreach (var symbol in args.Symbols)
                {
                    Staffs.Add(symbol);
                }

                MessengerInstance.Send<CurrentStateMessage>(new CurrentStateMessage() { State = args.Message });
            };
        }
    }
}
