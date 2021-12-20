using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_Serie_Vergleich
{
    class Filme
    {
        private string name;
        private int jahr;
        private string genre;

        public Filme(string fname, int fjahr, string fgenre)
        {
            name = fname;
            jahr = fjahr;
            genre = fgenre;
        }

        public Filme(string fname, int fjahr)
        {
            name = fname;
            jahr = fjahr;
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
            get { return genre; }
            set { genre = value; }
        }

        public override string ToString()
        {
            return "Objekt Typ: " + GetType() + Environment.NewLine + Environment.NewLine + "Name: " + Name + Environment.NewLine
                    + "Jahr: " + Jahr + Environment.NewLine + "Genre: " + Genre;
        }
    }
}
