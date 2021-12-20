using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_Serie_Vergleich
{
    class Serie
    {
        private string name;
        private int jahr;
        private string genre;
        private int anzstaffeln;
        private int anzfolgen;

        public Serie(string sname, int sjahr, string sgenre, int sanzstaffeln, int sanzfolgen)
        {
            name = sname;
            jahr = sjahr;
            genre = sgenre;
            anzstaffeln = sanzstaffeln;
            anzfolgen = sanzfolgen;
        }

        public Serie(string sname, int sjahr, int sanzstaffeln, int sanzfolgen)
        {
            name = sname;
            jahr = sjahr;
            anzstaffeln = sanzstaffeln;
            anzfolgen = sanzfolgen;
        }

        public Serie(string sname, int sjahr, string sgenre)
        {
            name = sname;
            jahr = sjahr;
            genre = sgenre;
        }

        public Serie(string sname, int sjahr)
        {
            name = sname;
            jahr = sjahr;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Jahr
        {
            get { return jahr; }
            set { jahr = value; }
        }

        public string Genre
        {
            get { return genre;  }
            set { genre = value; }
        }

        public int Anzstaffeln
        {
            get { return anzstaffeln; }
            set { anzstaffeln = value; }
        }

        public int Anzfolgen
        {
            get { return anzfolgen; }
            set { anzfolgen = value; }
        }

        public override string ToString()
        {
            return "Objekt Typ: " + GetType() + Environment.NewLine + Environment.NewLine + "Name: " + Name + Environment.NewLine
                    + "Jahr: " + Jahr + Environment.NewLine + "Genre: " + Genre + Environment.NewLine + "Anzahl Staffeln: " + Anzstaffeln 
                    + Environment.NewLine + "Durchschnittliche Folgen: " + Anzfolgen;
        }
    }
}
