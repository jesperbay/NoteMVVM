using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note
{
    class NoteVM
    {
        private static int count = 1;
        public string Emne { get; set; }
        public string Tekst { get; set; }
        public int Nr { get; set; }
        public DateTime Dato { get; set; }

        public NoteVM()
        {
            Nr = count++;
            Emne = "";
            Tekst = "";
            Dato = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{nameof(Emne)}: {Emne}, {nameof(Tekst)}: {Tekst}, {nameof(Nr)}: {Nr}, {nameof(Dato)}: {Dato}";
        }
    }
}
