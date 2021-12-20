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
    public partial class Schleifen : Form
    {
        public Schleifen()
        {
            InitializeComponent();
            TextBox_Sch.ReadOnly = true;
        }

        private void Button_Close_Sch_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Button_easteregg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You found a easteR egg! :D", "Easter Egg Search Part 4");
        }
    }
}
