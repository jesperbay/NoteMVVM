using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using NoteMVVM.Annotations;
using System.Collections.ObjectModel;

namespace NoteMVVM
{
    class NoteVM : INotifyPropertyChanged
    {
        public ObservableCollection<Note> Notes { get; set; }
        public string Emne { get; set; }
        public string Tekst { get; set; }
        public int Nr { get; set; }
        public int SelectedIndex { get; set; }
       

        public NoteVM()
        {
            Notes = new ObservableCollection<Note>();
            Notes.Add(new Note("sport", "Husk svøming "));
        }

        public void Add()
        {
            Notes.Add(new Note(Emne, Tekst));
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
