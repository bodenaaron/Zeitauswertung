using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeitauswertung
{
    public class Stundenbuchung
    {

        public virtual int id { get; set; }
        public virtual Bearbeiter Bearbeiter { get; set; }
        public virtual int Auftrag { get; set; }
        public virtual DateTime Datum { get; set; }
        public virtual string Bemerkung { get; set; }
        public virtual DateTime Von { get; set; }
        public virtual DateTime Bis { get; set; }
        public virtual DateTime Erstellt { get; set; }
        public virtual DateTime Updated { get; set; }
        public virtual bool Geloescht { get; set; }
        public virtual Zeittyp Zeittyp { get; set; }

    }
}
