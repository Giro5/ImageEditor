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
        Pencil = 1,//
        Brush = 2,
        Text = 3,
        Ellipse = 4,//
        Line = 5,//
        Curve = 6,
        Rectangle = 7,//
        Eraser = 8,
    }
    public partial class Form1 : Form
    {
        Point movestart, prev, delta;
        Point[] PencilPoints;
        Size sizestartPct, sizestartPnl;
        Pen MyPen = new Pen(Color.Black, 1);
        bool FoldingPalette = true, Painting = false;
        Painters Painter = Painters.None;
        Graphics g;
        string path = "", TitleName = "ImageEditor";
        string filtersave = "Bitmap (*.bmp; *.dib)|*.bmp; *.dib;|" +
                "JPEG (*.jpg; *.jpeg; *.jpe; *.jfif)|*.jpg; *.jpeg; *.jpe; *.jfif;|" +
                "GIF (*.gif)|*.gif;|" +
                "TIFF (*.tif; *.tiff)|*.tif; *.tiff;|" +
                "PNG (*.png)|*.png;";
        Bitmap MyPic;
        byte[] PenTypes;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = PatternPB.CreateGraphics();
            SizePictureTSSL.Text = $"{PatternPB.Width} × {PatternPB.Height}px";
            label1.Text = Painter.ToString();
            for (int i = 100; i >= 1; i--)
                SizeDUD.Items.Add(i);
            SizeDUD.SelectedIndex = 99;
            MyPic = new Bitmap(PatternPB.ClientSize.Width, PatternPB.ClientSize.Height);
        }

        private void ShadowPic_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                movestart = new Point(e.X, e.Y);
                sizestartPnl = new Size(ShadowPic.Width, ShadowPic.Height);
            }
        }

        private void ShadowPic_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                Point deltaPos = new Point(e.X - movestart.X, e.Y - movestart.Y);
                ShadowPic.Size = new Size(sizestartPnl.Width + deltaPos.X, sizestartPnl.Height + deltaPos.Y);
                g = PatternPB.CreateGraphics();
            }
        }

        private void PatternPB_SizeChanged(object sender, EventArgs e)
        {
            SizePictureTSSL.Text = $"{PatternPB.Width} × {PatternPB.Height}px";
            if (PatternPB.Width < 5)
                TopRightAnglePnl.Visible = false;
            else
                TopRightAnglePnl.Visible = true;
            if (PatternPB.Height < 5)
                BotLeftAnglePnl.Visible = false;
            else
                BotLeftAnglePnl.Visible = true;
        }

        private void PatternPB_MouseLeave(object sender, EventArgs e)
        {
            LocationMouseTSSL.Text = "";
            PatternPB.Refresh();
        }

        private void Color1Btn_Click(object sender, EventArgs e)
        {
            Color1Btn.FlatAppearance.BorderColor = Color.FromArgb(169, 84, 86);
            Color2Btn.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
        }

        private void Color2Btn_Click(object sender, EventArgs e)
        {
            Color2Btn.FlatAppearance.BorderColor = Color.FromArgb(169, 84, 86);
            Color1Btn.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
        }

        private void SizeDUD_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(SizeDUD.Text, out int val))
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
            {
                if (Color1Btn.FlatAppearance.BorderColor == Color.FromArgb(169, 84, 86))
                    Color1Btn.BackColor = colorDialog1.Color;
                else if (Color2Btn.FlatAppearance.BorderColor == Color.FromArgb(169, 84, 86))
                    Color2Btn.BackColor = colorDialog1.Color;
                else
                    MessageBox.Show("No Selected Color Box", "Error Colors");
            }
        }

        private void PainterBtn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            Painter = (Painters)Convert.ToInt32(b.AccessibleDescription);
            label1.Text = Painter.ToString();
            string file = Application.StartupPath;
            if (Painter == Painters.Pencil)
                PatternPB.Cursor = new Cursor($@"{string.Join(@"\", file.Split('\\'), 0, 7)}\Pencil.cur");
            else if (Painter == Painters.Rectangle)
                PatternPB.Cursor = new Cursor($@"{string.Join(@"\", file.Split('\\'), 0, 7)}\Figures.cur");
            else if (Painter == Painters.Ellipse)
                PatternPB.Cursor = new Cursor($@"{string.Join(@"\", file.Split('\\'), 0, 7)}\Figures.cur");
            else if (Painter == Painters.Line)
                PatternPB.Cursor = new Cursor($@"{string.Join(@"\", file.Split('\\'), 0, 7)}\Figures.cur");
        }

        private void ShadowPic_MouseUp(object sender, MouseEventArgs e)
        {
            Rectangle rec = PatternPB.RectangleToScreen(PatternPB.ClientRectangle);
            MyPic = new Bitmap(PatternPB.ClientSize.Width, PatternPB.ClientSize.Height);
            Graphics.FromImage(MyPic).CopyFromScreen(rec.Location, new Point(0, 0), rec.Size);
            g = PatternPB.CreateGraphics();
        }

        private void PatternPB_MouseUp(object sender, MouseEventArgs e)
        {
            Rectangle rec = PatternPB.RectangleToScreen(PatternPB.ClientRectangle);
            MyPic = new Bitmap(PatternPB.ClientSize.Width, PatternPB.ClientSize.Height);
            Graphics.FromImage(MyPic).CopyFromScreen(rec.Location, new Point(0, 0), rec.Size);
            Painting = false;
            Array.Resize(ref PencilPoints, 0);
            Array.Resize(ref PenTypes, 0);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = filtersave +
                "|ICO (*.ico)|*.ico;|" +
                "WEBP (*.webp)|*.webp;|" +
                "All Picture Files|*.bmp; *.dib; *.jpg; *.jpeg; *.jpe; *.jfif; *.gif; *.tif; *.tiff; *.png; *.heic; *.ico; *.webp;|" +
                "All Files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                string file = openFileDialog1.SafeFileName;
                Text = file + " - " + TitleName;
                Image pic = Image.FromFile(path, true);
                MyPic = new Bitmap(pic);
                ShadowPic.Size = new Size(MyPic.Width + 5, MyPic.Height + 5);
                g = PatternPB.CreateGraphics();
                PatternPB.Refresh();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (path != "")
                MyPic.Save(path);
            else
                saveAsToolStripMenuItem.PerformClick();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = filtersave;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
                string file = path.Split('\\').Last();
                Text = file + " - " + TitleName;
                switch (file.Split('.').Last())
                {
                    case "bmp":
                        MyPic.Save(path, ImageFormat.Bmp);
                        break;
                    case "jpg":
                        MyPic.Save(path, ImageFormat.Jpeg);
                        break;
                    case "gif":
                        MyPic.Save(path, ImageFormat.Gif);
                        break;
                    case "tif":
                        MyPic.Save(path, ImageFormat.Tiff);
                        break;
                    case "png":
                        MyPic.Save(path, ImageFormat.Png);
                        break;
                }
                Image pic = Image.FromFile(path, true);
                MyPic = new Bitmap(pic);
                ShadowPic.Size = new Size(MyPic.Width + 5, MyPic.Height + 5);
                g = PatternPB.CreateGraphics();
                PatternPB.Refresh();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ColorBtns_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (Color1Btn.FlatAppearance.BorderColor == Color.FromArgb(169, 84, 86))
                Color1Btn.BackColor = b.BackColor;
            else if (Color2Btn.FlatAppearance.BorderColor == Color.FromArgb(169, 84, 86))
                Color2Btn.BackColor = b.BackColor;
            else
                MessageBox.Show("No Selected Color Box", "Error Colors");
        }

        private void Color2Btn_BackColorChanged(object sender, EventArgs e)
        {
            Rectangle rec = PatternPB.RectangleToScreen(PatternPB.ClientRectangle);
            MyPic = new Bitmap(PatternPB.ClientSize.Width, PatternPB.ClientSize.Height);
            Graphics.FromImage(MyPic).CopyFromScreen(rec.Location, new Point(0, 0), rec.Size);
            PatternPB.Refresh();
            PatternPB.BackColor = Color2Btn.BackColor;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            path = "";
            Text = TitleName;
            MyPic = new Bitmap(PatternPB.ClientSize.Width, PatternPB.ClientSize.Height);
            g = PatternPB.CreateGraphics();
            PatternPB.Refresh();
        }

        private void PatternPB_Paint(object sender, PaintEventArgs e)
        {
            e?.Graphics?.DrawImage(MyPic, 0, 0);
        }

        private void PatternPB_MouseDown(object sender, MouseEventArgs e)
        {
            if (Painting)
            {
                Painting = false;
                g.DrawImage(MyPic, 0, 0);
            }
            else if ((e.Button == MouseButtons.Left || e.Button == MouseButtons.Right) && Painter != Painters.None)
            {
                Painting = true;

                PencilPoints = new Point[1] { new Point(e.X, e.Y) };
                PenTypes = new byte[1] { 0 };
                movestart = new Point(e.X, e.Y);

                Rectangle rec = PatternPB.RectangleToScreen(PatternPB.ClientRectangle);
                MyPic = new Bitmap(PatternPB.ClientSize.Width, PatternPB.ClientSize.Height);
                Graphics.FromImage(MyPic).CopyFromScreen(rec.Location, new Point(0, 0), rec.Size);
            }
        }

        private void PatternPB_MouseMove(object sender, MouseEventArgs e)
        {
            LocationMouseTSSL.Text = $"{e.X}, {e.Y}px";
            if (Painting && (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right))
            {
                MyPen = new Pen(e.Button == MouseButtons.Left ? Color1Btn.BackColor : Color2Btn.BackColor, MyPen.Width);
                MyPen.StartCap = MyPen.EndCap = LineCap.Round;
                MyPen.LineJoin = LineJoin.Round;
                if (Painter == Painters.Pencil)
                {
                    Array.Resize(ref PencilPoints, PencilPoints.Length + 1);
                    PencilPoints[PencilPoints.Length - 1] = new Point(e.X, e.Y);
                    Array.Resize(ref PenTypes, PenTypes.Length + 1);
                    PenTypes[PenTypes.Length - 1] = 1;
                    g.DrawPath(MyPen, new GraphicsPath(PencilPoints, PenTypes));
                }
                else if (Painter == Painters.Rectangle)
                {
                    PatternPB.Refresh();
                    g.DrawPolygon(MyPen, new[] { new Point(movestart.X, movestart.Y), new Point(movestart.X, e.Y), new Point(e.X, e.Y), new Point(e.X, movestart.Y) });
                }
                else if (Painter == Painters.Ellipse)
                {
                    PatternPB.Refresh();
                    g.DrawEllipse(MyPen, movestart.X, movestart.Y, e.X - movestart.X, e.Y - movestart.Y);
                }
                else if (Painter == Painters.Line)
                {
                    PatternPB.Refresh();
                    g.DrawLine(MyPen, movestart.X, movestart.Y, e.X, e.Y);
                }
            }
        }
    }
}
