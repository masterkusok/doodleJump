using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DoodleJump
{
    public partial class Records : Form
    {
        public string record, name;
        public Records()
        {
            InitializeComponent();
            using(StreamReader rf = new StreamReader("rec.txt"))
            {
                record = rf.ReadLine();
                name = rf.ReadLine();
            }
            label1.Text = "САМЫЙ КРУТОЙ - " + name + " - " + record + " ОЧКОВ ";
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            menuForm menu = new menuForm();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
