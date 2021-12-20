using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film_Serie_Vergleich
{
    public partial class frmStart : Form
    {
        Hinzufuegen frmhinzufuegen = new Hinzufuegen();
        public frmStart()
        {
            InitializeComponent();
        }

        private void btnHinzuf_Click(object sender, EventArgs e)
        {
            txtFilmeing.Text = "";
            txtSerieeing.Text = "";
            txtLinks.Text = "";
            txtRechts.Text = "";
            frmhinzufuegen.ShowDialog();
        }

        private void btnVergleich_Click(object sender, EventArgs e)
        {
            string filmlinks = txtFilmeing.Text;
            string serierechts = txtSerieeing.Text;
            if (filmlinks != "")
                txtLinks.Text = HoleInfos(filmlinks);
            if (serierechts != "")
                txtRechts.Text = HoleInfos(serierechts);
        }

        private void tmraktualisieren_Tick(object sender, EventArgs e)
        {
            AktualisiereInfos();
        }

        public void AktualisiereInfos()
        {
            if (frmhinzufuegen.arrayFilme != null)
                lblAnzFilm.Text = frmhinzufuegen.arrayFilme.Count.ToString();
            if (frmhinzufuegen.arraySerien != null)
                lblAnzSerie.Text = frmhinzufuegen.arraySerien.Count.ToString();
        }

        public string HoleInfos(string name)
        {
            string infos = "";
            if(frmhinzufuegen.arrayFilme != null)
            {
                for (int i = 0; i != frmhinzufuegen.arrayFilme.Count; i++)
                {
                    var film = (Filme)frmhinzufuegen.arrayFilme[i];
                    if (film.Name.Equals(name))
                    {
                        infos += film.ToString();
                        return infos;
                    }
                }
            }
            if (frmhinzufuegen.arraySerien != null)
            {
                for (int i = 0; i != frmhinzufuegen.arraySerien.Count; i++)
                {
                    var serie = (Serie)frmhinzufuegen.arraySerien[i];
                    if (serie.Name.Equals(name))
                    {
                        infos += serie.ToString();
                        return infos;
                    }
                }
            }
            infos = "Nichts gefunden";
            return infos;
        }
    }
}
