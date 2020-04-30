using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoodleJump
{
    public partial class menuForm : Form
    {
        public menuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 gf = new Form1();
            this.Hide();
            gf.ShowDialog();
            this.Close();
        }

        private void menuForm_Load(object sender, EventArgs e)
        {

        }

        private void recordsBtn_Click(object sender, EventArgs e)
        {
            Records recs = new Records();
            this.Hide();
            recs.ShowDialog();
            this.Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



