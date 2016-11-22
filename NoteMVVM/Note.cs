using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note
{
    class Note
    {
        public int Nr { get; set; }
        public string Emne { get; set; }
        public string Tekst { get; set; }
        public DateTime Dato { get; set; }

        private static int count = 1;

     

        public Note(string emne, string tekst)
        {
            Nr = count++;
            Emne = emne;
            Tekst = tekst;
            Dato = DateTime.Now;
        }

        public override string ToString()
        {
            return string.Format("Nr: {0}, Emne: {1}, Tekst: {2}, Dato: {3}", Nr, Emne, Tekst, Dato);
        }
    }
}
