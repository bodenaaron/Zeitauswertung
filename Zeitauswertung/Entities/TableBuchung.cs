using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeitauswertung
{
    class TableBuchung
    {

        [Browsable(false)]
        public int Id { get; set; }
        [Browsable(false)]
        public string Bearbeiter { get; set; }
        public int Auftrag { get; set; }
        public DateTime Datum { get; set; }
        public string Bemerkung { get; set; }
        public string Von { get; set; }
        public string Bis { get; set; }
        public DateTime Erstellt { get; set; }
        [Browsable(false)]
        public DateTime Updated { get; set; }
        [Browsable(false)]
        public bool Geloescht { get; set; }
        public string Zeittyp { get; set; }
        public TimeSpan dauer { get; set; }

        public TableBuchung(Stundenbuchung buchung)
        {
            Id = buchung.Id;
            Bearbeiter = buchung.Bearbeiter;
            Auftrag = buchung.Auftrag;
            Datum = buchung.Datum;
            Bemerkung = buchung.Bemerkung;
            Von = buchung.Von.ToString("HH:mm") ;
            Bis = buchung.Bis.ToString("HH:mm");
            Erstellt = buchung.Erstellt;
            Updated = buchung.Updated;
            Geloescht = buchung.Geloescht;
            Zeittyp = buchung.idZeittyp.Id;
            dauer = (DateTime.Parse(Bis) - DateTime.Parse(Von)) ;
        }
    }
}
