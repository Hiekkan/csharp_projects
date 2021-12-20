using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Englisch_Woertchen
{
    public partial class Unit4_3
    {
        private string englisch;
        private string deutsch;
        public List<Unit4_3> lstUnit4_3 = new List<Unit4_3>();

        public void GeneriereListe()
        {
            lstUnit4_3.Add(new Unit4_3("according to", "gemäss"));
            lstUnit4_3.Add(new Unit4_3("acronym", "Abkürzung"));
            lstUnit4_3.Add(new Unit4_3("added", "zusätzlich"));
            lstUnit4_3.Add(new Unit4_3("constructed", "aufgebaut"));
            lstUnit4_3.Add(new Unit4_3("consumption", "Konsum"));
            lstUnit4_3.Add(new Unit4_3("contain", "beinhalten"));
            lstUnit4_3.Add(new Unit4_3("disappear", "verschwinden"));
            lstUnit4_3.Add(new Unit4_3("dropped", "gefallen"));
            lstUnit4_3.Add(new Unit4_3("either or", "entweder oder"));
            lstUnit4_3.Add(new Unit4_3("fragile", "zerbrechlich"));
            lstUnit4_3.Add(new Unit4_3("housing", "Behausung"));
            lstUnit4_3.Add(new Unit4_3("integrate", "integrieren"));
            lstUnit4_3.Add(new Unit4_3("interchangeable", "austauschbar"));
            lstUnit4_3.Add(new Unit4_3("invent", "erfinden"));
            lstUnit4_3.Add(new Unit4_3("last", "dauern"));
            lstUnit4_3.Add(new Unit4_3("limitation", "Einschränkung"));
            lstUnit4_3.Add(new Unit4_3("non-volatile", "nichtflüchtig"));
            lstUnit4_3.Add(new Unit4_3("notes", "Notizen"));
            lstUnit4_3.Add(new Unit4_3("offload", "abladen"));
            lstUnit4_3.Add(new Unit4_3("once", "sobald"));
            lstUnit4_3.Add(new Unit4_3("option", "Wahl"));
            lstUnit4_3.Add(new Unit4_3("ordinary", "gewöhnlich"));
            lstUnit4_3.Add(new Unit4_3("pick up", "aufnehmen"));
            lstUnit4_3.Add(new Unit4_3("range from to", "reichen von bis"));
            lstUnit4_3.Add(new Unit4_3("restriction", "Beschränkung"));
            lstUnit4_3.Add(new Unit4_3("retain", "behalten"));
            lstUnit4_3.Add(new Unit4_3("robust", "widerstandsfähig"));
            lstUnit4_3.Add(new Unit4_3("score", "Spielstand"));
            lstUnit4_3.Add(new Unit4_3("stamp", "Briefmarke"));
            lstUnit4_3.Add(new Unit4_3("subject", "Schulfach"));
            lstUnit4_3.Add(new Unit4_3("traditionally", "herkömmlicherweise"));
            lstUnit4_3.Add(new Unit4_3("via", "über"));
            lstUnit4_3.Add(new Unit4_3("volatile", "flüchtig"));
            lstUnit4_3.Add(new Unit4_3("while", "obwohl"));
        }

        public Unit4_3(string eng, string de)
        {
            englisch = eng;
            deutsch = de;
        }

        public Unit4_3()
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
