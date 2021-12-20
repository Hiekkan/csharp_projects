using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace JentzschCSharpWiki
{
    public partial class CSharp_Grundlagen : Form
    {
        Variablen Form_Variablen = new Variablen();
        Operatoren Form_Operatoren = new Operatoren();
        Verzweigungen Form_Verzweigungen = new Verzweigungen();
        Schleifen Form_Schleifen = new Schleifen();
        Methoden Form_Methoden = new Methoden();
        public CSharp_Grundlagen()
        {
            InitializeComponent();
        }

        private void Button_Var_Click(object sender, EventArgs e)
        {
            Form_Variablen.Show();
        }

        private void Button_Ope_Click(object sender, EventArgs e)
        {
            Form_Operatoren.Show();
        }

        private void Button_Ver_Click(object sender, EventArgs e)
        {
            Form_Verzweigungen.Show();
        }

        private void Button_Sch_Click(object sender, EventArgs e)
        {
            Form_Schleifen.Show();
        }

        private void Button_Meth_Click(object sender, EventArgs e)
        {
            Form_Methoden.Show();
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InputBox_Click(object sender, EventArgs e)
        {
            string message, title, defaultValue;
            string myValue;

            message = "Welcome to the easter egg search. In each section there is a easter egg.\n\n\nPasswort:";
            title = "InputBox";
            defaultValue = "0";
            myValue = Interaction.InputBox(message, title, defaultValue, -1, -1);
            
            if (myValue == "Array")
            {
                MessageBox.Show("Gratulations! You've won the easter egg search.");
            }
        }
    }
}
