using System;
using System.Collections;
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
    public partial class Hinzufuegen : Form
    {
        public ArrayList arrayFilme = new ArrayList();
        public ArrayList arraySerien = new ArrayList();
        public Hinzufuegen()
        {
            InitializeComponent();
        }

        private void btnEintrag_Click(object sender, EventArgs e)
        {
            if (rdbFilm.Checked)
            {
                if (txtJahr.Text == "" || txtName.Text == "")
                    MessageBox.Show("Beim Film soll das Jahr und der Name eingetragen sein", "Keine Angaben");
                else if (txtGenre.Text != "")
                    arrayFilme.Add(new Filme(txtName.Text, Convert.ToInt32(txtJahr.Text), txtGenre.Text));
                else
                    arrayFilme.Add(new Filme(txtName.Text, Convert.ToInt32(txtJahr.Text)));
            }
            else if (rdbSerie.Checked)
            {
                if (txtJahr.Text == "" || txtName.Text == "")
                    MessageBox.Show("Bei der Serie soll der Name und das Jahr ausgefüllt sein", "Keine Angaben");
                else if (txtAnzFolg.Text != "" && txtAnzSta.Text != "" && txtGenre.Text != "")
                    arraySerien.Add(new Serie(txtName.Text, Convert.ToInt32(txtJahr.Text), txtGenre.Text, Convert.ToInt32(txtAnzSta.Text), Convert.ToInt32(txtAnzFolg.Text)));
                else if (txtAnzFolg.Text != "" && txtAnzSta.Text != "")
                    arraySerien.Add(new Serie(txtName.Text, Convert.ToInt32(txtJahr.Text), Convert.ToInt32(txtAnzSta.Text), Convert.ToInt32(txtAnzFolg.Text)));
                else if (txtGenre.Text != "")
                    arraySerien.Add(new Serie(txtName.Text, Convert.ToInt32(txtJahr.Text), txtGenre.Text));
                else
                    arraySerien.Add(new Serie(txtName.Text, Convert.ToInt32(txtJahr.Text)));
            }
            else
                MessageBox.Show("Es muss eine von den Radiobuttons aktiviert sein", "Keine Angaben");

            this.Hide();
            txtName.Text = "";
            txtGenre.Text = "";
            txtJahr.Text = "";
            txtAnzSta.Text = "";
            txtAnzFolg.Text = "";
            rdbFilm.Checked = false;
            rdbSerie.Checked = false;
        }

        private void rdbFilm_CheckedChanged(object sender, EventArgs e)
        {
            txtAnzSta.Visible = false;
            txtAnzFolg.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
        }

        private void rdbSerie_CheckedChanged(object sender, EventArgs e)
        {
            txtAnzSta.Visible = true;
            txtAnzFolg.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
        }
    }
}
