using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Englisch_Woertchen
{
    public partial class Unit4 
    {
        private string englisch;
        private string deutsch;

        public Unit4(string eng, string de)
        {
            englisch = eng;
            deutsch = de;
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
