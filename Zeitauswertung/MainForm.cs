using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zeitauswertung
{
    public partial class MainForm : Form
    {
        DBManager DB;
        public MainForm()
        {
            InitializeComponent();
            DB = new DBManager();
            ReinitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void ReinitializeComponent()
        {
            cmb_Bearbeiter.DataSource = new BindingSource(DB.dic_Bearbeiter, null);
            cmb_Bearbeiter.DisplayMember = "Key";
            cmb_Bearbeiter.ValueMember = "Value";
            cmb_Bearbeiter.SelectedItem = null;
        }

        private void btn_suchen_Click(object sender, EventArgs e)
        {
            DateChecker dateChecker = new DateChecker();
            tb_gesamtstunden.Text = "0";
            TimeSpan gesamtDauer = TimeSpan.Zero;
            TimeSpan gesamtKrank = TimeSpan.Zero;
            TimeSpan gesamtUrlaub = TimeSpan.Zero;
            TimeSpan gesamtArbeit = TimeSpan.Zero;
            int gesamtSollStunden = 0;
            if (cmb_Bearbeiter.SelectedItem!=null)
            {
                List<TableBuchung>tb = DB.GetBuchungen(((KeyValuePair<string, Bearbeiter>)cmb_Bearbeiter.SelectedItem).Value,date_von.Value,date_bis.Value);

                foreach (TableBuchung t in tb)
                {
                    TimeSpan dauer = (gesamtDauer + t.dauer);
                    
                    tb_gesamtstunden.Text = string.Format("{0}:{1}",dauer.Days*24+dauer.Hours,dauer.Minutes);
                    gesamtDauer = dauer;
                    if (t.Zeittyp == "Urlaub")
                    {
                        TimeSpan dauerU = (gesamtUrlaub + t.dauer);
                        tb_urlaub.Text = string.Format("{0}:{1}", dauerU.Days * 24 + dauerU.Hours, dauerU.Minutes);
                        gesamtUrlaub = dauerU;
                    }
                    else
                    {
                        if (t.Zeittyp == "Krank")
                        {
                            TimeSpan dauerK = (gesamtKrank + t.dauer);
                            tb_krank.Text = string.Format("{0}:{1}", dauerK.Days * 24 + dauerK.Hours, dauerK.Minutes);
                            gesamtKrank = dauerK;
                        }
                        else
                        {
                            TimeSpan dauerA = (gesamtArbeit + t.dauer);
                            tb_gearbeitet.Text = string.Format("{0}:{1}", dauerA.Days * 24 + dauerA.Hours, dauerA.Minutes);
                            gesamtArbeit = dauerA;                    
                        }
                    }
                }
                table.DataSource= tb.OrderByDescending(a => a.Datum).ToList();
                

                foreach (DateTime day in EachDay(date_von.Value, date_bis.Value))
                {
                    if (dateChecker.isWorkDay(day))
                    {
                        gesamtSollStunden= gesamtSollStunden + 8;                        
                    }
                }
                tb_sollStunden.Text = gesamtSollStunden.ToString();
            }
        }

        public IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
                yield return day;
        }

        private void date_von_ValueChanged(object sender, EventArgs e)
        {
            date_bis.Value = date_von.Value;
        }
    }
}
