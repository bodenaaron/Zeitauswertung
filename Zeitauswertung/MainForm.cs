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
            tb_gesamtstunden.Text = "0";
            TimeSpan gesamtDauer = TimeSpan.Zero;
            if (cmb_Bearbeiter.SelectedItem!=null)
            {
                List<TableBuchung>tb = DB.GetBuchungen(((KeyValuePair<string, Bearbeiter>)cmb_Bearbeiter.SelectedItem).Value,date_von.Value,date_bis.Value);

                foreach (TableBuchung t in tb)
                {
                    TimeSpan dauer = (gesamtDauer + t.dauer);
                    tb_gesamtstunden.Text = string.Format("{0}:{1}",dauer.Days*24+dauer.Hours,dauer.Minutes);
                    gesamtDauer = dauer;
                }
                table.DataSource= tb.OrderByDescending(a => a.Datum).ToList();
            }
        }
    }
}
