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
    public partial class Form5 : Form
    {
        public static List<Unit4_1> lstUnit4All = new List<Unit4_1>();
        public Random rnd = new Random();
        public Unit4_1 obj;
        public int index;
        int anzahlRichtig = 0;
        int anzahlFalsch = 0;
        public Form5()
        {
            InitializeComponent();
        }

        public void GeneriereListe()
        {
            lstUnit4All.Add(new Unit4_1("a.k.a. (also known as)", "bekannt als"));
            lstUnit4All.Add(new Unit4_1("archive", "Archiv"));
            lstUnit4All.Add(new Unit4_1("average", "durchschnittlich"));
            lstUnit4All.Add(new Unit4_1("be assigned to", "zuordnen"));
            lstUnit4All.Add(new Unit4_1("can be fitted", "kann angepasst werden"));
            lstUnit4All.Add(new Unit4_1("circular", "rund"));
            lstUnit4All.Add(new Unit4_1("confuse", "verwirren"));
            lstUnit4All.Add(new Unit4_1("considerable", "erheblich"));
            lstUnit4All.Add(new Unit4_1("convenient", "praktisch"));
            lstUnit4All.Add(new Unit4_1("corruption", "Beschädigung"));
            lstUnit4All.Add(new Unit4_1("current(ly)", "aktuell"));
            lstUnit4All.Add(new Unit4_1("damage", "Schaden"));
            lstUnit4All.Add(new Unit4_1("directory", "Verzeichnis"));
            lstUnit4All.Add(new Unit4_1("divide", "teilen"));
            lstUnit4All.Add(new Unit4_1("due to", "aufgrund"));
            lstUnit4All.Add(new Unit4_1("durable", "haltbar"));
            lstUnit4All.Add(new Unit4_1("ensure", "garantieren"));
            lstUnit4All.Add(new Unit4_1("entry", "Eingabe"));
            lstUnit4All.Add(new Unit4_1("especially", "besonders"));
            lstUnit4All.Add(new Unit4_1("familiar", "vertraut"));
            lstUnit4All.Add(new Unit4_1("fragmentation", "Zersplitterung"));
            lstUnit4All.Add(new Unit4_1("get stuck to", "steckenbleiben"));
            lstUnit4All.Add(new Unit4_1("i.e.", "das heisst"));
            lstUnit4All.Add(new Unit4_1("increasingly", "zunehmend"));
            lstUnit4All.Add(new Unit4_1("in effect", "in der Tat"));
            lstUnit4All.Add(new Unit4_1("lifespan", "Lebensdauer"));
            lstUnit4All.Add(new Unit4_1("magnetisable", "magnetisierbar"));
            lstUnit4All.Add(new Unit4_1("minimize", "minimieren"));
            lstUnit4All.Add(new Unit4_1("occur", "auftreten"));
            lstUnit4All.Add(new Unit4_1("on the one hand", "einerseits"));
            lstUnit4All.Add(new Unit4_1("own", "besitzen"));
            lstUnit4All.Add(new Unit4_1("partitioned", "aufgeteilt"));
            lstUnit4All.Add(new Unit4_1("precious", "kostbar"));
            lstUnit4All.Add(new Unit4_1("preceding", "vorangegangen"));
            lstUnit4All.Add(new Unit4_1("relatively", "verhältnismässig"));
            lstUnit4All.Add(new Unit4_1("result in", "zu etwas führen"));
            lstUnit4All.Add(new Unit4_1("revolution", "die Revolution"));
            lstUnit4All.Add(new Unit4_1("scatter", "streuen"));
            lstUnit4All.Add(new Unit4_1("scratch", "kratzen"));
            lstUnit4All.Add(new Unit4_1("secondary", "sekundär"));
            lstUnit4All.Add(new Unit4_1("seek time", "Zugriffzeit Suche"));
            lstUnit4All.Add(new Unit4_1("sequential", "sequenziell"));
            lstUnit4All.Add(new Unit4_1("serious", "ernsthaft"));
            lstUnit4All.Add(new Unit4_1("shock resistant", "stossfest"));
            lstUnit4All.Add(new Unit4_1("so called", "sogennant"));
            lstUnit4All.Add(new Unit4_1("specific", "bestimmt"));
            lstUnit4All.Add(new Unit4_1("spin", "schnell drehen"));
            lstUnit4All.Add(new Unit4_1("split", "aufteilen"));
            lstUnit4All.Add(new Unit4_1("stack", "Stapel"));
            lstUnit4All.Add(new Unit4_1("towards", "gegen"));
            lstUnit4All.Add(new Unit4_1("transfer rate", "Datenübertragungsrate"));
            lstUnit4All.Add(new Unit4_1("unfortunately", "unglücklicherweise"));
            lstUnit4All.Add(new Unit4_1("unless", "ausser wenn"));

            lstUnit4All.Add(new Unit4_1("affordable", "bezahlbar"));
            lstUnit4All.Add(new Unit4_1("agree", "einverstanden sein mit"));
            lstUnit4All.Add(new Unit4_1("although", "obschon"));
            lstUnit4All.Add(new Unit4_1("as a result", "demzufolge"));
            lstUnit4All.Add(new Unit4_1("at first sight", "auf den ersten Blick"));
            lstUnit4All.Add(new Unit4_1("be affected by", "von etwas betroffen sein"));
            lstUnit4All.Add(new Unit4_1("beam", "Strahl"));
            lstUnit4All.Add(new Unit4_1("besides", "ausser"));
            lstUnit4All.Add(new Unit4_1("blank", "leer"));
            lstUnit4All.Add(new Unit4_1("compatible", "kompatibel"));
            lstUnit4All.Add(new Unit4_1("competing", "konkurrierend"));
            lstUnit4All.Add(new Unit4_1("consequently", "folglich"));
            lstUnit4All.Add(new Unit4_1("counterpart", "Gegenstück"));
            lstUnit4All.Add(new Unit4_1("disagree", "nicht einverstanden sein"));
            lstUnit4All.Add(new Unit4_1("duplicate", "kopieren"));
            lstUnit4All.Add(new Unit4_1("favourite", "Lieblings"));
            lstUnit4All.Add(new Unit4_1("harm", "verletzen"));
            lstUnit4All.Add(new Unit4_1("hence", "deswegen"));
            lstUnit4All.Add(new Unit4_1("in addition", "noch dazu"));
            lstUnit4All.Add(new Unit4_1("major", "gross"));
            lstUnit4All.Add(new Unit4_1("minor", "gering"));
            lstUnit4All.Add(new Unit4_1("occupy", "besetzen"));
            lstUnit4All.Add(new Unit4_1("pit", "Grube"));
            lstUnit4All.Add(new Unit4_1("preserve", "erhalten"));
            lstUnit4All.Add(new Unit4_1("rectangular", "rechteckig"));
            lstUnit4All.Add(new Unit4_1("replace", "austauschen"));
            lstUnit4All.Add(new Unit4_1("rewritable", "wiederbeschreibbar"));
            lstUnit4All.Add(new Unit4_1("so", "deshalb"));
            lstUnit4All.Add(new Unit4_1("successor", "Nachfolger"));
            lstUnit4All.Add(new Unit4_1("typically", "typisch"));
            lstUnit4All.Add(new Unit4_1("unlike", "anders als"));
            lstUnit4All.Add(new Unit4_1("versatile", "vielseitig"));
            lstUnit4All.Add(new Unit4_1("vital", "entscheidend"));
            lstUnit4All.Add(new Unit4_1("whereas", "während"));
            lstUnit4All.Add(new Unit4_1("wherever", "wo (auch) immer"));
            lstUnit4All.Add(new Unit4_1("furthermore", "ausserdem"));

            lstUnit4All.Add(new Unit4_1("according to", "gemäss"));
            lstUnit4All.Add(new Unit4_1("acronym", "Abkürzung"));
            lstUnit4All.Add(new Unit4_1("added", "zusätzlich"));
            lstUnit4All.Add(new Unit4_1("constructed", "aufgebaut"));
            lstUnit4All.Add(new Unit4_1("consumption", "Konsum"));
            lstUnit4All.Add(new Unit4_1("contain", "beinhalten"));
            lstUnit4All.Add(new Unit4_1("disappear", "verschwinden"));
            lstUnit4All.Add(new Unit4_1("dropped", "gefallen"));
            lstUnit4All.Add(new Unit4_1("either or", "entweder oder"));
            lstUnit4All.Add(new Unit4_1("fragile", "zerbrechlich"));
            lstUnit4All.Add(new Unit4_1("housing", "Behausung"));
            lstUnit4All.Add(new Unit4_1("integrate", "integrieren"));
            lstUnit4All.Add(new Unit4_1("interchangeable", "austauschbar"));
            lstUnit4All.Add(new Unit4_1("invent", "erfinden"));
            lstUnit4All.Add(new Unit4_1("last", "dauern"));
            lstUnit4All.Add(new Unit4_1("limitation", "Einschränkung"));
            lstUnit4All.Add(new Unit4_1("non-volatile", "nichtflüchtig"));
            lstUnit4All.Add(new Unit4_1("notes", "Notizen"));
            lstUnit4All.Add(new Unit4_1("offload", "abladen"));
            lstUnit4All.Add(new Unit4_1("once", "sobald"));
            lstUnit4All.Add(new Unit4_1("option", "Wahl"));
            lstUnit4All.Add(new Unit4_1("ordinary", "gewöhnlich"));
            lstUnit4All.Add(new Unit4_1("pick up", "aufnehmen"));
            lstUnit4All.Add(new Unit4_1("range from to", "reichen von bis"));
            lstUnit4All.Add(new Unit4_1("restriction", "Beschränkung"));
            lstUnit4All.Add(new Unit4_1("retain", "behalten"));
            lstUnit4All.Add(new Unit4_1("robust", "widerstandsfähig"));
            lstUnit4All.Add(new Unit4_1("score", "Spielstand"));
            lstUnit4All.Add(new Unit4_1("stamp", "Briefmarke"));
            lstUnit4All.Add(new Unit4_1("subject", "Schulfach"));
            lstUnit4All.Add(new Unit4_1("traditionally", "herkömmlicherweise"));
            lstUnit4All.Add(new Unit4_1("via", "über"));
            lstUnit4All.Add(new Unit4_1("volatile", "flüchtig"));
            lstUnit4All.Add(new Unit4_1("while", "obwohl"));
        }

        private void btnEingabe_Click(object sender, EventArgs e)
        {
            lblFalsch.Text = "";
            SchaueLösung();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            GeneriereListe();
            txtLoesung.ReadOnly = false;
            lblWortAnzahl.Text = Convert.ToString(123);
            txtLoesung.Select();
        }

        private void HoleWort()
        {
            try
            {
                index = rnd.Next(0, lstUnit4All.Count);
                obj = lstUnit4All[index];
            }
            catch (System.ArgumentOutOfRangeException)
            {
            }

            if (lstUnit4All.Count == 0)
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

        private void SchaueLösung()
        {
            if (rdbDeutsch.Checked)
            {
                if (txtLoesung.Text == obj.Deutsch)
                {
                    anzahlRichtig++;
                    lblAnzahl.Text = Convert.ToString(anzahlRichtig);
                    lstUnit4All.RemoveAt(index);
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
                    lstUnit4All.RemoveAt(index);
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

        private void rdbEnglisch_CheckedChanged(object sender, EventArgs e)
        {
            lblFalsch.Text = "";
            lblFalschW.Text = "0";
            txtLoesung.ReadOnly = false;
            txtGesucht.Visible = true;
            HoleWort();
        }

        private void rdbDeutsch_CheckedChanged(object sender, EventArgs e)
        {
            lblFalsch.Text = "";
            lblFalschW.Text = "0";
            txtLoesung.ReadOnly = false;
            txtGesucht.Visible = true;
            HoleWort();
        }
    }
}
