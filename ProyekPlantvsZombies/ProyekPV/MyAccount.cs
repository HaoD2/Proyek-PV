using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyekPV
{
    public partial class MyAccount : Form
    {
        public MyAccount()
        {
            InitializeComponent();
        }

        private void playBTN_Click(object sender, EventArgs e)
        {
            if(userTB.Text != "")
            {
                inGame ig = new inGame();
                this.Hide();
                ig.Show();
            }
        }
    }
}
