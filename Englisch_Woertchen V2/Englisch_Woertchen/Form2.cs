using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Englisch_Woertchen
{
    public partial class Schreiben : Form
    {
        //public static List<Unit_4> lstUnit4 = new List<Unit_4>();
        public static Random rnd = new Random();
        public static Unit4_1 obj;
        public static Unit4_2 obje;
        public static Unit4_3 objek;
        private Unit4_1 clunit4_1 = new Unit4_1();
        private Unit4_2 clunit4_2 = new Unit4_2();
        private Unit4_3 clunit4_3 = new Unit4_3();
        public static int index;
        public int anzahlRichtig = 0;
        public int anzahlFalsch = 0;
        public Schreiben()
        {
            InitializeComponent();
        }

        public Schreiben(Unit4_2 unit4_2)
        {
            clunit4_2 = unit4_2;
        }

        public Schreiben(Unit4_3 unit4_3)
        {
            clunit4_3 = unit4_3;
        }

        public Schreiben(Unit4_1 unit4_1)
        {
            clunit4_1 = unit4_1;
        }

        /*public static void GeneriereListe()
        {
            
            lstUnit4.Add(new Unit_4("a.k.a. (also known as)", "bekannt als"));
            lstUnit4.Add(new Unit_4("archive", "Archiv"));
            lstUnit4.Add(new Unit_4("average", "durchschnittlich"));
            lstUnit4.Add(new Unit_4("be assigned to", "zuordnen"));
            lstUnit4.Add(new Unit_4("can be fitted", "kann angepasst werden"));
            lstUnit4.Add(new Unit_4("circular", "rund"));
            lstUnit4.Add(new Unit_4("confuse", "verwirren"));
            lstUnit4.Add(new Unit_4("considerable", "erheblich"));
            lstUnit4.Add(new Unit_4("convenient", "praktisch"));
            lstUnit4.Add(new Unit_4("corruption", "Beschädigung"));
            lstUnit4.Add(new Unit_4("current(ly)", "aktuell"));
            lstUnit4.Add(new Unit_4("damage", "Schaden"));
            lstUnit4.Add(new Unit_4("directory", "Verzeichnis"));
            lstUnit4.Add(new Unit_4("divide", "teilen"));
            lstUnit4.Add(new Unit_4("due to", "aufgrund"));
            lstUnit4.Add(new Unit_4("durable", "haltbar"));
            lstUnit4.Add(new Unit_4("ensure", "garantieren"));
            lstUnit4.Add(new Unit_4("entry", "Eingabe"));
            lstUnit4.Add(new Unit_4("especially", "besonders"));
            lstUnit4.Add(new Unit_4("familiar", "vertraut"));
            lstUnit4.Add(new Unit_4("fragmentation", "Zersplitterung"));
            lstUnit4.Add(new Unit_4("get stuck to", "steckenbleiben"));
            lstUnit4.Add(new Unit_4("i.e.", "das heisst"));
            lstUnit4.Add(new Unit_4("increasingly", "zunehmend"));
            lstUnit4.Add(new Unit_4("in effect", "in der Tat"));
            lstUnit4.Add(new Unit_4("lifespan", "Lebensdauer"));
            lstUnit4.Add(new Unit_4("magnetisable", "magnetisierbar"));
            lstUnit4.Add(new Unit_4("minimize", "minimieren"));
            lstUnit4.Add(new Unit_4("occur", "auftreten"));
            lstUnit4.Add(new Unit_4("on the one hand", "einerseits"));
            lstUnit4.Add(new Unit_4("own", "besitzen"));
            lstUnit4.Add(new Unit_4("partitioned", "aufgeteilt"));
            lstUnit4.Add(new Unit_4("precious", "kostbar"));
            lstUnit4.Add(new Unit_4("preceding", "vorangegangen"));
            lstUnit4.Add(new Unit_4("relatively", "verhältnismässig"));
            lstUnit4.Add(new Unit_4("result in", "zu etwas führen"));
            lstUnit4.Add(new Unit_4("revolution", "die Revolution"));
            lstUnit4.Add(new Unit_4("scatter", "streuen"));
            lstUnit4.Add(new Unit_4("scratch", "kratzen"));
            lstUnit4.Add(new Unit_4("secondary", "sekundär"));
            lstUnit4.Add(new Unit_4("seek time", "Zugriffzeit Suche"));
            lstUnit4.Add(new Unit_4("sequential", "sequenziell"));
            lstUnit4.Add(new Unit_4("serious", "ernsthaft"));
            lstUnit4.Add(new Unit_4("shock resistant", "stossfest"));
            lstUnit4.Add(new Unit_4("so called", "sogennant"));
            lstUnit4.Add(new Unit_4("specific", "bestimmt"));
            lstUnit4.Add(new Unit_4("spin", "schnell drehen"));
            lstUnit4.Add(new Unit_4("split", "aufteilen"));
            lstUnit4.Add(new Unit_4("stack", "Stapel"));
            lstUnit4.Add(new Unit_4("towards", "gegen"));
            lstUnit4.Add(new Unit_4("transfer rate", "Datenübertragungsrate"));
            lstUnit4.Add(new Unit_4("unfortunately", "unglücklicherweise"));
            lstUnit4.Add(new Unit_4("unless", "ausser wenn"));
        }*/

        private void btnEingabe_Click(object sender, EventArgs e)
        {
            lblFalsch.Text = "";
            SchaueLösung();
        }

        public void Form2_Load(object sender, EventArgs e)
        {
            clunit4_1.GeneriereListe();
            txtLoesung.ReadOnly = false;
            //lblWortAnzahl.Text = Convert.ToString();
            txtLoesung.Select();
        }

        public void HoleWort()
        {
            try
            {
                index = rnd.Next(0, clunit4_1.lstUnit4.Count);
                obj = clunit4_1.lstUnit4[index];
            }
            catch (System.ArgumentOutOfRangeException)
            {
            }

            if (clunit4_1.lstUnit4.Count == 0)
            {
                lblFalsch.Text = "Alle Wörter richtig geschrieben";
                txtLoesung.ReadOnly = true;
                txtGesucht.Visible = false;
            }

            if (rdbDeutsch.Checked)
            {
                txtGesucht.Text = obj.Englisch;
            }
            else if (rdbEnglisch.Checked)
            {
                txtGesucht.Text = obj.Deutsch;
            }
            txtLoesung.Select();
        }
        public void SchaueLösung()
        {
            if (rdbDeutsch.Checked)
            {
                if (txtLoesung.Text == obj.Deutsch)
                {
                    anzahlRichtig++;
                    lblAnzahl.Text = Convert.ToString(anzahlRichtig);
                    clunit4_1.lstUnit4.RemoveAt(index);
                    HoleWort();
                }
                else if (txtLoesung.Text != obj.Deutsch)
                {
                    anzahlFalsch++;
                    txtGesucht.Text = obj.Englisch;
                    lblFalsch.Text = "Falsches Wort";
                    lblFalschW.Text = Convert.ToString(anzahlFalsch);
                }
                txtLoesung.Text = "";
            }
            else if (rdbEnglisch.Checked)
            {
                if (txtLoesung.Text == obj.Englisch)
                {
                    anzahlRichtig++;
                    lblAnzahl.Text = Convert.ToString(anzahlRichtig);
                    clunit4_1.lstUnit4.RemoveAt(index);
                    HoleWort();
                }
                else if (txtLoesung.Text != obj.Englisch)
                {
                    anzahlFalsch++;
                    txtGesucht.Text = obj.Deutsch;
                    lblFalsch.Text = "Falsches Wort";
                    lblFalschW.Text = Convert.ToString(anzahlFalsch);
                }
                txtLoesung.Text = "";
            }
        }

        public void rdbEnglisch_CheckedChanged(object sender, EventArgs e)
        {
            lblFalsch.Text = "";
            lblFalschW.Text = "0";
            txtLoesung.Text = "";
            txtLoesung.ReadOnly = false;
            txtGesucht.Visible = true;
            HoleWort();
        }

        public void rdbDeutsch_CheckedChanged(object sender, EventArgs e)
        {
            lblFalsch.Text = "";
            lblFalschW.Text = "0";
            txtLoesung.Text = "";
            txtLoesung.ReadOnly = false;
            txtGesucht.Visible = true;
            HoleWort();
        }
    }
}
