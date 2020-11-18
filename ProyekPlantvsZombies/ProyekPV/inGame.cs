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
    public partial class inGame : Form
    {
        public inGame()
        {
            InitializeComponent();
            arrEnemy = new List<Enemy>();
        }
        List<Enemy> arrEnemy;
        Image img;
        Rectangle r;
        Image[] zombies;
        Rectangle Hitboxzombies;

        
        private void inGame_Load(object sender, EventArgs e)
        {
            img = ProyekPV.Properties.Resources.board;
            r = new Rectangle(0, 0, 500, 500);
            zombies[0] = ProyekPV.Properties.Resources.zombie1;
            zombies[1] = ProyekPV.Properties.Resources.zombie2;
            zombies[2] = ProyekPV.Properties.Resources.zombie3;
            
        }

        private void inGame_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(img, r);
            for (int i = 0; i < arrEnemy.Count; i++)
            {
                
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
