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
    public partial class Operatoren : Form
    {
        public Operatoren()
        {
            InitializeComponent();
            TextBox_Ope.ReadOnly = true;
        }

        private void Button_Close_Ope_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Button_easter_egg_2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Are so good, you found the second easter egg!", "Easter Egg Search Part 2");
        }
    }
}
