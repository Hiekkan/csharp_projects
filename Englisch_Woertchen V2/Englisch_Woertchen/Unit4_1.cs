using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Englisch_Woertchen
{
    public partial class Unit4_1
    {
        private string englisch;
        private string deutsch;
        public List<Unit4_1> lstUnit4 = new List<Unit4_1>();
        public void GeneriereListe()
        {
            lstUnit4.Add(new Unit4_1("a.k.a. (also known as)", "bekannt als"));
            lstUnit4.Add(new Unit4_1("archive", "Archiv"));
            lstUnit4.Add(new Unit4_1("average", "durchschnittlich"));
            lstUnit4.Add(new Unit4_1("be assigned to", "zuordnen"));
            lstUnit4.Add(new Unit4_1("can be fitted", "kann angepasst werden"));
            lstUnit4.Add(new Unit4_1("circular", "rund"));
            lstUnit4.Add(new Unit4_1("confuse", "verwirren"));
            lstUnit4.Add(new Unit4_1("considerable", "erheblich"));
            lstUnit4.Add(new Unit4_1("convenient", "praktisch"));
            lstUnit4.Add(new Unit4_1("corruption", "Beschädigung"));
            lstUnit4.Add(new Unit4_1("current(ly)", "aktuell"));
            lstUnit4.Add(new Unit4_1("damage", "Schaden"));
            lstUnit4.Add(new Unit4_1("directory", "Verzeichnis"));
            lstUnit4.Add(new Unit4_1("divide", "teilen"));
            lstUnit4.Add(new Unit4_1("due to", "aufgrund"));
            lstUnit4.Add(new Unit4_1("durable", "haltbar"));
            lstUnit4.Add(new Unit4_1("ensure", "garantieren"));
            lstUnit4.Add(new Unit4_1("entry", "Eingabe"));
            lstUnit4.Add(new Unit4_1("especially", "besonders"));
            lstUnit4.Add(new Unit4_1("familiar", "vertraut"));
            lstUnit4.Add(new Unit4_1("fragmentation", "Zersplitterung"));
            lstUnit4.Add(new Unit4_1("get stuck to", "steckenbleiben"));
            lstUnit4.Add(new Unit4_1("i.e.", "das heisst"));
            lstUnit4.Add(new Unit4_1("increasingly", "zunehmend"));
            lstUnit4.Add(new Unit4_1("in effect", "in der Tat"));
            lstUnit4.Add(new Unit4_1("lifespan", "Lebensdauer"));
            lstUnit4.Add(new Unit4_1("magnetisable", "magnetisierbar"));
            lstUnit4.Add(new Unit4_1("minimize", "minimieren"));
            lstUnit4.Add(new Unit4_1("occur", "auftreten"));
            lstUnit4.Add(new Unit4_1("on the one hand", "einerseits"));
            lstUnit4.Add(new Unit4_1("own", "besitzen"));
            lstUnit4.Add(new Unit4_1("partitioned", "aufgeteilt"));
            lstUnit4.Add(new Unit4_1("precious", "kostbar"));
            lstUnit4.Add(new Unit4_1("preceding", "vorangegangen"));
            lstUnit4.Add(new Unit4_1("relatively", "verhältnismässig"));
            lstUnit4.Add(new Unit4_1("result in", "zu etwas führen"));
            lstUnit4.Add(new Unit4_1("revolution", "die Revolution"));
            lstUnit4.Add(new Unit4_1("scatter", "streuen"));
            lstUnit4.Add(new Unit4_1("scratch", "kratzen"));
            lstUnit4.Add(new Unit4_1("secondary", "sekundär"));
            lstUnit4.Add(new Unit4_1("seek time", "Zugriffzeit Suche"));
            lstUnit4.Add(new Unit4_1("sequential", "sequenziell"));
            lstUnit4.Add(new Unit4_1("serious", "ernsthaft"));
            lstUnit4.Add(new Unit4_1("shock resistant", "stossfest"));
            lstUnit4.Add(new Unit4_1("so called", "sogennant"));
            lstUnit4.Add(new Unit4_1("specific", "bestimmt"));
            lstUnit4.Add(new Unit4_1("spin", "schnell drehen"));
            lstUnit4.Add(new Unit4_1("split", "aufteilen"));
            lstUnit4.Add(new Unit4_1("stack", "Stapel"));
            lstUnit4.Add(new Unit4_1("towards", "gegen"));
            lstUnit4.Add(new Unit4_1("transfer rate", "Datenübertragungsrate"));
            lstUnit4.Add(new Unit4_1("unfortunately", "unglücklicherweise"));
            lstUnit4.Add(new Unit4_1("unless", "ausser wenn"));
        }

        public Unit4_1(string eng, string de)
        {
            englisch = eng;
            deutsch = de;
        }

        public Unit4_1()
        {
        }

        public string Englisch
        {
            get { return englisch; }
            set { englisch = value; }
        }

        public string Deutsch
        {
            get { return deutsch; }
            set { deutsch = value; }
        }
    }
}
