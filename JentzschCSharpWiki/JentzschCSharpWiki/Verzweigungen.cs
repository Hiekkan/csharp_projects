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
    public partial class Verzweigungen : Form
    {
        public Verzweigungen()
        {
            InitializeComponent();
            TextBox_Ver.ReadOnly = true;
        }

        private void Button_Close_Ver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Button_egg_3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oh no, you found a easteR egg!", "Easter Egg Search Part 3");
        }
    }
}
