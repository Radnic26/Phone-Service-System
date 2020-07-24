using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlClass
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle rectangle = e.ClipRectangle;
            Font fontTitle = new Font("Calibri", 28);
            Font font = new Font("Calibri", 16);

            graphics.DrawString("Final Project®", fontTitle, new SolidBrush(Color.Black), 250, 10);
            graphics.DrawString("Version 1.0.8", font, new SolidBrush(Color.Black), 285, 100);
            graphics.DrawString("Copyright© 2019 RaduNiculae", font, new SolidBrush(Color.Black), 205, 150);
            graphics.DrawString("Final Project® is a registered trademark of RaduNiculae 1052", font, new SolidBrush(Color.Black), 95, 180);
            graphics.DrawString("Sponsored by", font, new SolidBrush(Color.Black), 290, 300);
        }
    }
}
