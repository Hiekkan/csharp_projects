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
    public partial class Methoden : Form
    {
        public Methoden()
        {
            InitializeComponent();
            TextBox_Meth.ReadOnly = true;
        }

        private void Button_Close_Meth_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_egg_5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You found the last easter egg! Now go to the mAin window ^-^", "Easter Egg Search Part 5");
        }
    }
}
