using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Englisch_Woertchen
{
    public partial class Unit4_2
    {
        private string englisch;
        private string deutsch;
        public List<Unit4_2> lstUnit4_2 = new List<Unit4_2>();

        private void GeneriereListe()
        {
            lstUnit4_2.Add(new Unit4_2("affordable", "bezahlbar"));
            lstUnit4_2.Add(new Unit4_2("agree", "einverstanden sein mit"));
            lstUnit4_2.Add(new Unit4_2("although", "obwohl"));
            lstUnit4_2.Add(new Unit4_2("as a result", "demzufolge"));
            lstUnit4_2.Add(new Unit4_2("at first sight", "auf den ersten Blick"));
            lstUnit4_2.Add(new Unit4_2("be affected by", "von etwas betroffen sein"));
            lstUnit4_2.Add(new Unit4_2("beam", "Strahl"));
            lstUnit4_2.Add(new Unit4_2("besides", "ausser"));
            lstUnit4_2.Add(new Unit4_2("blank", "leer"));
            lstUnit4_2.Add(new Unit4_2("compatible", "kompatibel"));
            lstUnit4_2.Add(new Unit4_2("competing", "konkurrierend"));
            lstUnit4_2.Add(new Unit4_2("consequently", "folglich"));
            lstUnit4_2.Add(new Unit4_2("counterpart", "Gegenstück"));
            lstUnit4_2.Add(new Unit4_2("disagree", "nicht einverstanden sein"));
            lstUnit4_2.Add(new Unit4_2("duplicate", "kopieren"));
            lstUnit4_2.Add(new Unit4_2("favourite", "Lieblings"));
            lstUnit4_2.Add(new Unit4_2("harm", "verletzen"));
            lstUnit4_2.Add(new Unit4_2("hence", "deswegen"));
            lstUnit4_2.Add(new Unit4_2("in addition", "noch dazu"));
            lstUnit4_2.Add(new Unit4_2("major", "gross"));
            lstUnit4_2.Add(new Unit4_2("minor", "gering"));
            lstUnit4_2.Add(new Unit4_2("occupy", "besetzen"));
            lstUnit4_2.Add(new Unit4_2("pit", "Grube"));
            lstUnit4_2.Add(new Unit4_2("preserve", "erhalten"));
            lstUnit4_2.Add(new Unit4_2("rectangular", "rechteckig"));
            lstUnit4_2.Add(new Unit4_2("replace", "austauschen"));
            lstUnit4_2.Add(new Unit4_2("rewritable", "wiederbeschreibbar"));
            lstUnit4_2.Add(new Unit4_2("so", "deshalb"));
            lstUnit4_2.Add(new Unit4_2("successor", "Nachfolger"));
            lstUnit4_2.Add(new Unit4_2("typically", "typisch"));
            lstUnit4_2.Add(new Unit4_2("unlike", "anders als"));
            lstUnit4_2.Add(new Unit4_2("versatile", "vielseitig"));
            lstUnit4_2.Add(new Unit4_2("vital", "entscheidend"));
            lstUnit4_2.Add(new Unit4_2("whereas", "während"));
            lstUnit4_2.Add(new Unit4_2("wherever", "wo (auch) immer"));
            lstUnit4_2.Add(new Unit4_2("furthermore", "ausserdem"));
        }

        public Unit4_2(string eng, string de)
        {
            englisch = eng;
            deutsch = de;
        }

        public Unit4_2()
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
