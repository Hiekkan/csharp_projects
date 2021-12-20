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
    public partial class Form1 : Form
    {
        private Unit4_1 unit4_1 = new Unit4_1();
        private Unit4_2 unit4_2 = new Unit4_2();
        private Unit4_3 unit4_3 = new Unit4_3();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Schreiben frmSchreiben = new Schreiben(unit4_1);
            frmSchreiben.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Schreiben frmSchreiben = new Schreiben(unit4_2);
            frmSchreiben.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Schreiben frmSchreiben = new Schreiben(unit4_3);
            frmSchreiben.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Schreiben frmSchreiben = new Schreiben();
            //frmSchreiben.Show();
        }
    }
}
