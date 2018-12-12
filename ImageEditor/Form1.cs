using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.DirectoryServices;

namespace ImageEditor
{
    public partial class Form1 : Form
    {
        Point movestart;
        Size sizestartPct, sizestartPnl;
        enum Painters
        {
            Pencil = 0,
            Brush,
            Text,
            Ellipse,
            Line,
            Curve,
            Rectangle,

        }
        Painters ToolNow = Painters.Brush;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SizePictureTSSL.Text = $"{pictureBox1.Width} × {pictureBox1.Height}px";
        }

        private void ShadowPic_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                movestart = new Point(e.X, e.Y);
                sizestartPct = new Size(pictureBox1.Width, pictureBox1.Height);
                sizestartPnl = new Size(ShadowPic.Width, ShadowPic.Height);
            }
        }

        private void ShadowPic_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                Point deltaPos = new Point(e.X - movestart.X, e.Y - movestart.Y);
                pictureBox1.Size = new Size(sizestartPct.Width + deltaPos.X, sizestartPct.Height + deltaPos.Y);
                ShadowPic.Size = new Size(sizestartPnl.Width + deltaPos.X, sizestartPnl.Height + deltaPos.Y);
                //label1.Text = $"{e.X} {e.Y}";
                //label2.Text = $"{movestart.X} {movestart.Y}";
                //label3.Text = $"{pictureBox1.Width} {pictureBox1.Height}";
                //label4.Text = $"{panel2.Width} {panel2.Height}";
            }
        }

        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {
            SizePictureTSSL.Text = $"{pictureBox1.Width} × {pictureBox1.Height}px";
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            LocationMouseTSSL.Text = "";
        }

        private void PencilBtn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.FlatStyle = FlatStyle.Popup;
            
            ToolNow = 0;
            label1.Text = ToolNow.ToString();
            string file = Application.StartupPath;
            //C:\Users\Giro\source\repos\ImageEditor\ImageEditor\bin\Debug
            string curfile = $@"{string.Join(@"\", file.Split('\\'), 0, 7)}\Pencil.cur";
            pictureBox1.Cursor = new Cursor(curfile);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            LocationMouseTSSL.Text = $"{e.X}, {e.Y}px";
        }
    }
}
