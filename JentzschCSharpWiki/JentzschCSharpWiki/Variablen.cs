using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JentzschCSharpWiki
{
    public partial class Variablen : Form
    {
        public Variablen()
        {
            InitializeComponent();
            TextBox_Var.ReadOnly = true;
        }

        private void Button_Close_Var_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Button_egg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WOW, You found the first easter egg! :D", "Easter Egg Search Part 1");
        }
    }
}
