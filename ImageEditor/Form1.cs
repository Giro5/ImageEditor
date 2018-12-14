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
using System.Drawing.Drawing2D;

namespace ImageEditor
{
    enum Painters
    {
        None = 0,
        Pencil = 1,
        Brush = 2,
        Text = 3,
        Ellipse = 4,
        Line = 5,
        Curve = 6,
        Rectangle = 7,

    }
    public partial class Form1 : Form
    {
        Point movestart, prev, delta;

        Point[] PencilPoints;

        Size sizestartPct, sizestartPnl;

        Pen MyPen = new Pen(Color.Black, 1);

        bool FoldingPalette = true;
        
        Painters Painter = Painters.None;

        Graphics g;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
            SizePictureTSSL.Text = $"{pictureBox1.Width} × {pictureBox1.Height}px";
            label1.Text = Painter.ToString();
            for (int i = 100; i >= 1; i--)
                domainUpDown1.Items.Add(i);
            domainUpDown1.SelectedIndex = 99;
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
            }
        }

        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {
            SizePictureTSSL.Text = $"{pictureBox1.Width} × {pictureBox1.Height}px";
            if (pictureBox1.Width < 5)
                TopRightAnglePnl.Visible = false;
            else
                TopRightAnglePnl.Visible = true;
            if (pictureBox1.Height < 5)
                BotLeftAnglePnl.Visible = false;
            else
                BotLeftAnglePnl.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            LocationMouseTSSL.Text = "";
        }

        private void Color1Btn_Click(object sender, EventArgs e)
        {
            
            MyPen.Color = Color1Btn.BackColor;
        }

        private void domainUpDown1_TextChanged(object sender, EventArgs e)
        {
            int val;
            if (int.TryParse(domainUpDown1.Text, out val))
                MyPen.Width = val;
        }

        private void PaletteBtn_MouseEnter(object sender, EventArgs e)
        {
            FoldingPalette = false;
            FoldingPaletteTmr.Stop();
            FoldingPaletteTmr.Start();
        }

        private void FoldingPaletteTmr_Tick(object sender, EventArgs e)
        {
            if (FoldingPalette)
            {
                if (PaletteBtn.ImageIndex > 0)
                    PaletteBtn.ImageIndex--;
                else
                    FoldingPaletteTmr.Stop();
            }
            else
            {
                if (PaletteBtn.ImageIndex < 3)
                    PaletteBtn.ImageIndex++;
                else
                    FoldingPaletteTmr.Stop();
            }
        }

        private void PaletteBtn_MouseLeave(object sender, EventArgs e)
        {
            FoldingPalette = true;
            FoldingPaletteTmr.Stop();
            FoldingPaletteTmr.Start();
        }

        private void PaletteBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                Color1Btn.BackColor = colorDialog1.Color;
            MyPen.Color = Color1Btn.BackColor;
        }

        private void PainterBtn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            //b.FlatStyle = FlatStyle.Popup;
            
            Painter = (Painters)Convert.ToInt32(b.AccessibleDescription);
            label1.Text = Painter.ToString();
            string file = Application.StartupPath;
            //C:\Users\Giro\source\repos\ImageEditor\ImageEditor\bin\Debug
            if (Painter == Painters.Pencil)
                pictureBox1.Cursor = new Cursor($@"{string.Join(@"\", file.Split('\\'), 0, 7)}\Pencil.cur");
            else if (Painter == Painters.Rectangle)
                pictureBox1.Cursor = new Cursor($@"{string.Join(@"\", file.Split('\\'), 0, 7)}\Figures.cur");

        }
        Image PicImage;

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            grph = e.Graphics.Save();
            //e.Graphics.DrawPolygon(MyPen, new[] { new Point(movestart.X, movestart.Y), new Point(movestart.X, delta.Y), new Point(delta.X, delta.Y), new Point(delta.X, movestart.Y) });
            
        }

        GraphicsState grph;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                //PicImage = (Image)pictureBox1?.InitialImage?.Clone();
                grph = g.Save();
                //pictureBox1.Refresh();

                PencilPoints = new Point[1] { new Point(e.X, e.Y) };
                movestart = new Point(e.X, e.Y);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            LocationMouseTSSL.Text = $"{e.X}, {e.Y}px";
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                if (Painter == Painters.Pencil)
                {
                    Array.Resize(ref PencilPoints, PencilPoints.Length + 1);
                    PencilPoints[PencilPoints.Length - 1] = new Point(e.X, e.Y);
                    g.DrawCurve(MyPen, PencilPoints);
                }
                else if (Painter == Painters.Rectangle)
                {
                    //g.Clear(Color2Btn.BackColor);

                    delta = new Point(e.X, e.Y);
                    //pictureBox1.Refresh();
                    g.DrawPolygon(MyPen, new[] { new Point(movestart.X, movestart.Y), new Point(movestart.X, e.Y), new Point(e.X, e.Y), new Point(e.X, movestart.Y) });
                    g.Restore(grph);
                }
            }
        }
    }
}
