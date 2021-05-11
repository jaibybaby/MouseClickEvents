using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseClickEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void picBall_MouseClick(object sender, MouseEventArgs e)
        {
            int x = picBall.Location.X;
            int y = picBall.Location.Y;
            if (e.Button == MouseButtons.Left)
            {
                picBall.Location = new Point(picBall.Location.X-20,picBall.Location.Y);
                // this.Clicks = picBall.Left;
            }
            if (e.Button == MouseButtons.Right)
            {
                picBall.Location = new Point(picBall.Location.X + 20, picBall.Location.Y);
            }
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
