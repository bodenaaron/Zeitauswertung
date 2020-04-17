using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeitauswertung
{
    public class Stundenbuchung
    {

        [Browsable(false)]
        public virtual int Id { get; set; }
        [Browsable(false)]
        public virtual string Bearbeiter { get; set; }
        public virtual int Auftrag { get; set; }
        public virtual DateTime Datum { get; set; }
        public virtual string Bemerkung { get; set; }
        public virtual DateTime Von { get; set; }
        public virtual DateTime Bis { get; set; }
        public virtual DateTime Erstellt { get; set; }
        [Browsable(false)]
        public virtual DateTime Updated { get; set; }
        [Browsable(false)]
        public virtual bool Geloescht { get; set; }
        public virtual Zeittyp idZeittyp { get; set; }

    }
}
