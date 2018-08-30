using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LironSaediBouncingBalls
{
    public partial class Form1 : Form
    {
        Graphics gfx;
        Bitmap map;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            map = new Bitmap(ClientSize.Width, ClientSize.Height);
            gfx = Graphics.FromImage(map);
        }

        private void gameTime_Tick(object sender, EventArgs e)
        {


            gfx.FillEllipse(Brushes.Blue, 100, 100, 100, 100);
            gfx.Clear(BackColor);
            
            
        }
    }
}
