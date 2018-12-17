namespace ImageEditor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsPnl = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.EditColorsLbl = new System.Windows.Forms.Label();
            this.Color2Lbl = new System.Windows.Forms.Label();
            this.Color2Btn = new System.Windows.Forms.Button();
            this.Color1Lbl = new System.Windows.Forms.Label();
            this.ImgsPalette = new System.Windows.Forms.ImageList(this.components);
            this.SizeDUD = new System.Windows.Forms.DomainUpDown();
            this.Color1Btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.BackgroundPnl = new System.Windows.Forms.Panel();
            this.ShadowPic = new System.Windows.Forms.Panel();
            this.BotLeftAnglePnl = new System.Windows.Forms.Panel();
            this.TopRightAnglePnl = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.FoldingPaletteTmr = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PatternPB = new System.Windows.Forms.PictureBox();
            this.LocationMouseTSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.SizePictureTSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.LineBtn = new System.Windows.Forms.Button();
            this.EllipseBtn = new System.Windows.Forms.Button();
            this.RectangleBtn = new System.Windows.Forms.Button();
            this.PaletteBtn = new System.Windows.Forms.Button();
            this.PencilBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.ToolsPnl.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.BackgroundPnl.SuspendLayout();
            this.ShadowPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatternPB)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1215, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.openToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveAsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ToolsPnl
            // 
            this.ToolsPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ToolsPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ToolsPnl.Controls.Add(this.label8);
            this.ToolsPnl.Controls.Add(this.label7);
            this.ToolsPnl.Controls.Add(this.LineBtn);
            this.ToolsPnl.Controls.Add(this.label6);
            this.ToolsPnl.Controls.Add(this.label5);
            this.ToolsPnl.Controls.Add(this.tableLayoutPanel1);
            this.ToolsPnl.Controls.Add(this.EditColorsLbl);
            this.ToolsPnl.Controls.Add(this.EllipseBtn);
            this.ToolsPnl.Controls.Add(this.RectangleBtn);
            this.ToolsPnl.Controls.Add(this.Color2Lbl);
            this.ToolsPnl.Controls.Add(this.Color2Btn);
            this.ToolsPnl.Controls.Add(this.Color1Lbl);
            this.ToolsPnl.Controls.Add(this.PaletteBtn);
            this.ToolsPnl.Controls.Add(this.SizeDUD);
            this.ToolsPnl.Controls.Add(this.Color1Btn);
            this.ToolsPnl.Controls.Add(this.PencilBtn);
            this.ToolsPnl.Controls.Add(this.label4);
            this.ToolsPnl.Controls.Add(this.label3);
            this.ToolsPnl.Controls.Add(this.label2);
            this.ToolsPnl.Controls.Add(this.label1);
            this.ToolsPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolsPnl.Location = new System.Drawing.Point(0, 24);
            this.ToolsPnl.Name = "ToolsPnl";
            this.ToolsPnl.Size = new System.Drawing.Size(1215, 100);
            this.ToolsPnl.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.button20, 9, 1);
            this.tableLayoutPanel1.Controls.Add(this.button19, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.button18, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.button17, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.button16, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.button14, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button13, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button12, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button11, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button10, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.button9, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.button8, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.button7, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.button6, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.button5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.button4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button15, 4, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(668, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 50);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Thistle;
            this.button20.Location = new System.Drawing.Point(225, 25);
            this.button20.Margin = new System.Windows.Forms.Padding(0);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(25, 25);
            this.button20.TabIndex = 34;
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.ColorBtns_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.SteelBlue;
            this.button19.Location = new System.Drawing.Point(200, 25);
            this.button19.Margin = new System.Windows.Forms.Padding(0);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(25, 25);
            this.button19.TabIndex = 33;
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.ColorBtns_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button18.Location = new System.Drawing.Point(175, 25);
            this.button18.Margin = new System.Windows.Forms.Padding(0);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(25, 25);
            this.button18.TabIndex = 32;
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.ColorBtns_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Lime;
            this.button17.Location = new System.Drawing.Point(150, 25);
            this.button17.Margin = new System.Windows.Forms.Padding(0);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(25, 25);
            this.button17.TabIndex = 31;
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.ColorBtns_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.LightYellow;
            this.button16.Location = new System.Drawing.Point(125, 25);
            this.button16.Margin = new System.Windows.Forms.Padding(0);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(25, 25);
            this.button16.TabIndex = 30;
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.ColorBtns_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.LightPink;
            this.button14.Location = new System.Drawing.Point(75, 25);
            this.button14.Margin = new System.Windows.Forms.Padding(0);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(25, 25);
            this.button14.TabIndex = 28;
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.ColorBtns_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Peru;
            this.button13.Location = new System.Drawing.Point(50, 25);
            this.button13.Margin = new System.Windows.Forms.Padding(0);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(25, 25);
            this.button13.TabIndex = 27;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.ColorBtns_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Silver;
            this.button12.Location = new System.Drawing.Point(25, 25);
            this.button12.Margin = new System.Windows.Forms.Padding(0);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(25, 25);
            this.button12.TabIndex = 26;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.ColorBtns_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(0, 25);
            this.button11.Margin = new System.Windows.Forms.Padding(0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(25, 25);
            this.button11.TabIndex = 25;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.ColorBtns_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.DarkMagenta;
            this.button10.Location = new System.Drawing.Point(225, 0);
            this.button10.Margin = new System.Windows.Forms.Padding(0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(25, 25);
            this.button10.TabIndex = 24;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.ColorBtns_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Blue;
            this.button9.Location = new System.Drawing.Point(200, 0);
            this.button9.Margin = new System.Windows.Forms.Padding(0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(25, 25);
            this.button9.TabIndex = 23;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.ColorBtns_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DodgerBlue;
            this.button8.Location = new System.Drawing.Point(175, 0);
            this.button8.Margin = new System.Windows.Forms.Padding(0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(25, 25);
            this.button8.TabIndex = 22;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.ColorBtns_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.ForestGreen;
            this.button7.Location = new System.Drawing.Point(150, 0);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(25, 25);
            this.button7.TabIndex = 21;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.ColorBtns_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Yellow;
            this.button6.Location = new System.Drawing.Point(125, 0);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(25, 25);
            this.button6.TabIndex = 20;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.ColorBtns_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Orange;
            this.button5.Location = new System.Drawing.Point(100, 0);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 25);
            this.button5.TabIndex = 19;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.ColorBtns_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(75, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 25);
            this.button4.TabIndex = 18;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.ColorBtns_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.Location = new System.Drawing.Point(50, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 25);
            this.button3.TabIndex = 17;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.ColorBtns_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Location = new System.Drawing.Point(25, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 25);
            this.button2.TabIndex = 16;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ColorBtns_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ColorBtns_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Gold;
            this.button15.Location = new System.Drawing.Point(100, 25);
            this.button15.Margin = new System.Windows.Forms.Padding(0);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(25, 25);
            this.button15.TabIndex = 29;
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.ColorBtns_Click);
            // 
            // EditColorsLbl
            // 
            this.EditColorsLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EditColorsLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EditColorsLbl.Location = new System.Drawing.Point(924, 40);
            this.EditColorsLbl.Name = "EditColorsLbl";
            this.EditColorsLbl.Size = new System.Drawing.Size(35, 26);
            this.EditColorsLbl.TabIndex = 13;
            this.EditColorsLbl.Text = "Edit colors";
            this.EditColorsLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Color2Lbl
            // 
            this.Color2Lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Color2Lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Color2Lbl.Location = new System.Drawing.Point(627, 40);
            this.Color2Lbl.Name = "Color2Lbl";
            this.Color2Lbl.Size = new System.Drawing.Size(35, 26);
            this.Color2Lbl.TabIndex = 10;
            this.Color2Lbl.Text = "Color 2";
            this.Color2Lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Color2Btn
            // 
            this.Color2Btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Color2Btn.BackColor = System.Drawing.Color.White;
            this.Color2Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Color2Btn.FlatAppearance.BorderSize = 3;
            this.Color2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Color2Btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Color2Btn.Location = new System.Drawing.Point(627, 5);
            this.Color2Btn.Name = "Color2Btn";
            this.Color2Btn.Size = new System.Drawing.Size(35, 35);
            this.Color2Btn.TabIndex = 9;
            this.Color2Btn.UseVisualStyleBackColor = false;
            this.Color2Btn.BackColorChanged += new System.EventHandler(this.Color2Btn_BackColorChanged);
            this.Color2Btn.Click += new System.EventHandler(this.Color2Btn_Click);
            // 
            // Color1Lbl
            // 
            this.Color1Lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Color1Lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Color1Lbl.Location = new System.Drawing.Point(581, 40);
            this.Color1Lbl.Name = "Color1Lbl";
            this.Color1Lbl.Size = new System.Drawing.Size(35, 26);
            this.Color1Lbl.TabIndex = 8;
            this.Color1Lbl.Text = "Color 1";
            this.Color1Lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ImgsPalette
            // 
            this.ImgsPalette.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgsPalette.ImageStream")));
            this.ImgsPalette.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgsPalette.Images.SetKeyName(0, "Palette_Step0.png");
            this.ImgsPalette.Images.SetKeyName(1, "Palette_Step1.png");
            this.ImgsPalette.Images.SetKeyName(2, "Palette_Step2.png");
            this.ImgsPalette.Images.SetKeyName(3, "Palette_Step3.png");
            // 
            // SizeDUD
            // 
            this.SizeDUD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SizeDUD.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.SizeDUD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SizeDUD.Location = new System.Drawing.Point(481, 10);
            this.SizeDUD.Name = "SizeDUD";
            this.SizeDUD.Size = new System.Drawing.Size(72, 20);
            this.SizeDUD.TabIndex = 6;
            this.SizeDUD.TextChanged += new System.EventHandler(this.SizeDUD_TextChanged);
            // 
            // Color1Btn
            // 
            this.Color1Btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Color1Btn.BackColor = System.Drawing.Color.Black;
            this.Color1Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(84)))), ((int)(((byte)(86)))));
            this.Color1Btn.FlatAppearance.BorderSize = 3;
            this.Color1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Color1Btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Color1Btn.Location = new System.Drawing.Point(581, 5);
            this.Color1Btn.Name = "Color1Btn";
            this.Color1Btn.Size = new System.Drawing.Size(35, 35);
            this.Color1Btn.TabIndex = 5;
            this.Color1Btn.UseVisualStyleBackColor = false;
            this.Color1Btn.Click += new System.EventHandler(this.Color1Btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(1147, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(1147, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(1147, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(1147, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Painter";
            this.label1.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LocationMouseTSSL,
            this.SizePictureTSSL});
            this.statusStrip1.Location = new System.Drawing.Point(0, 697);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1215, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // BackgroundPnl
            // 
            this.BackgroundPnl.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundPnl.Controls.Add(this.ShadowPic);
            this.BackgroundPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundPnl.Location = new System.Drawing.Point(0, 124);
            this.BackgroundPnl.Name = "BackgroundPnl";
            this.BackgroundPnl.Size = new System.Drawing.Size(1215, 573);
            this.BackgroundPnl.TabIndex = 4;
            // 
            // ShadowPic
            // 
            this.ShadowPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ShadowPic.Controls.Add(this.BotLeftAnglePnl);
            this.ShadowPic.Controls.Add(this.TopRightAnglePnl);
            this.ShadowPic.Controls.Add(this.PatternPB);
            this.ShadowPic.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.ShadowPic.Location = new System.Drawing.Point(5, 5);
            this.ShadowPic.MinimumSize = new System.Drawing.Size(5, 5);
            this.ShadowPic.Name = "ShadowPic";
            this.ShadowPic.Size = new System.Drawing.Size(1005, 505);
            this.ShadowPic.TabIndex = 3;
            this.ShadowPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShadowPic_MouseDown);
            this.ShadowPic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ShadowPic_MouseMove);
            this.ShadowPic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShadowPic_MouseUp);
            // 
            // BotLeftAnglePnl
            // 
            this.BotLeftAnglePnl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BotLeftAnglePnl.BackColor = System.Drawing.SystemColors.GrayText;
            this.BotLeftAnglePnl.Location = new System.Drawing.Point(0, 500);
            this.BotLeftAnglePnl.Name = "BotLeftAnglePnl";
            this.BotLeftAnglePnl.Size = new System.Drawing.Size(5, 5);
            this.BotLeftAnglePnl.TabIndex = 5;
            // 
            // TopRightAnglePnl
            // 
            this.TopRightAnglePnl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TopRightAnglePnl.BackColor = System.Drawing.SystemColors.GrayText;
            this.TopRightAnglePnl.Location = new System.Drawing.Point(1000, 0);
            this.TopRightAnglePnl.Name = "TopRightAnglePnl";
            this.TopRightAnglePnl.Size = new System.Drawing.Size(5, 5);
            this.TopRightAnglePnl.TabIndex = 4;
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // FoldingPaletteTmr
            // 
            this.FoldingPaletteTmr.Interval = 70;
            this.FoldingPaletteTmr.Tick += new System.EventHandler(this.FoldingPaletteTmr_Tick);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(750, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Colors";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(499, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Size";
            // 
            // PatternPB
            // 
            this.PatternPB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PatternPB.BackColor = System.Drawing.Color.White;
            this.PatternPB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PatternPB.Location = new System.Drawing.Point(0, 0);
            this.PatternPB.Name = "PatternPB";
            this.PatternPB.Size = new System.Drawing.Size(1000, 500);
            this.PatternPB.TabIndex = 3;
            this.PatternPB.TabStop = false;
            this.PatternPB.SizeChanged += new System.EventHandler(this.PatternPB_SizeChanged);
            this.PatternPB.Paint += new System.Windows.Forms.PaintEventHandler(this.PatternPB_Paint);
            this.PatternPB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PatternPB_MouseDown);
            this.PatternPB.MouseLeave += new System.EventHandler(this.PatternPB_MouseLeave);
            this.PatternPB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PatternPB_MouseMove);
            this.PatternPB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PatternPB_MouseUp);
            // 
            // LocationMouseTSSL
            // 
            this.LocationMouseTSSL.AutoSize = false;
            this.LocationMouseTSSL.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LocationMouseTSSL.Image = global::ImageEditor.Properties.Resources.icons8_Collapse_32px;
            this.LocationMouseTSSL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LocationMouseTSSL.Name = "LocationMouseTSSL";
            this.LocationMouseTSSL.Size = new System.Drawing.Size(200, 17);
            this.LocationMouseTSSL.Text = "location mouse";
            this.LocationMouseTSSL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SizePictureTSSL
            // 
            this.SizePictureTSSL.AutoSize = false;
            this.SizePictureTSSL.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SizePictureTSSL.Image = global::ImageEditor.Properties.Resources.icons8_Surface_32px;
            this.SizePictureTSSL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SizePictureTSSL.Name = "SizePictureTSSL";
            this.SizePictureTSSL.Size = new System.Drawing.Size(200, 17);
            this.SizePictureTSSL.Text = "size picturebox";
            this.SizePictureTSSL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LineBtn
            // 
            this.LineBtn.AccessibleDescription = "5";
            this.LineBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LineBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.LineBtn.BackgroundImage = global::ImageEditor.Properties.Resources.icons8_Line_30px;
            this.LineBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LineBtn.FlatAppearance.BorderSize = 0;
            this.LineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LineBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LineBtn.Location = new System.Drawing.Point(331, 10);
            this.LineBtn.Margin = new System.Windows.Forms.Padding(0);
            this.LineBtn.Name = "LineBtn";
            this.LineBtn.Size = new System.Drawing.Size(30, 30);
            this.LineBtn.TabIndex = 17;
            this.LineBtn.Tag = "";
            this.LineBtn.UseVisualStyleBackColor = false;
            this.LineBtn.Click += new System.EventHandler(this.PainterBtn_Click);
            // 
            // EllipseBtn
            // 
            this.EllipseBtn.AccessibleDescription = "4";
            this.EllipseBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EllipseBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.EllipseBtn.BackgroundImage = global::ImageEditor.Properties.Resources.icons8_Oval_32px;
            this.EllipseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EllipseBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.EllipseBtn.FlatAppearance.BorderSize = 0;
            this.EllipseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EllipseBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EllipseBtn.Location = new System.Drawing.Point(411, 10);
            this.EllipseBtn.Margin = new System.Windows.Forms.Padding(0);
            this.EllipseBtn.Name = "EllipseBtn";
            this.EllipseBtn.Size = new System.Drawing.Size(30, 30);
            this.EllipseBtn.TabIndex = 12;
            this.EllipseBtn.Tag = "";
            this.EllipseBtn.UseVisualStyleBackColor = false;
            this.EllipseBtn.Click += new System.EventHandler(this.PainterBtn_Click);
            // 
            // RectangleBtn
            // 
            this.RectangleBtn.AccessibleDescription = "7";
            this.RectangleBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RectangleBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.RectangleBtn.BackgroundImage = global::ImageEditor.Properties.Resources.icons8_Rectangular_32px;
            this.RectangleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RectangleBtn.FlatAppearance.BorderSize = 0;
            this.RectangleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RectangleBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RectangleBtn.Location = new System.Drawing.Point(371, 10);
            this.RectangleBtn.Margin = new System.Windows.Forms.Padding(0);
            this.RectangleBtn.Name = "RectangleBtn";
            this.RectangleBtn.Size = new System.Drawing.Size(30, 30);
            this.RectangleBtn.TabIndex = 11;
            this.RectangleBtn.Tag = "";
            this.RectangleBtn.UseVisualStyleBackColor = false;
            this.RectangleBtn.Click += new System.EventHandler(this.PainterBtn_Click);
            // 
            // PaletteBtn
            // 
            this.PaletteBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PaletteBtn.FlatAppearance.BorderSize = 0;
            this.PaletteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaletteBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PaletteBtn.ImageKey = "Palette_Step0.png";
            this.PaletteBtn.ImageList = this.ImgsPalette;
            this.PaletteBtn.Location = new System.Drawing.Point(924, 5);
            this.PaletteBtn.Name = "PaletteBtn";
            this.PaletteBtn.Size = new System.Drawing.Size(35, 35);
            this.PaletteBtn.TabIndex = 7;
            this.PaletteBtn.UseVisualStyleBackColor = true;
            this.PaletteBtn.Click += new System.EventHandler(this.PaletteBtn_Click);
            this.PaletteBtn.MouseEnter += new System.EventHandler(this.PaletteBtn_MouseEnter);
            this.PaletteBtn.MouseLeave += new System.EventHandler(this.PaletteBtn_MouseLeave);
            // 
            // PencilBtn
            // 
            this.PencilBtn.AccessibleDescription = "1";
            this.PencilBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PencilBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.PencilBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PencilBtn.FlatAppearance.BorderSize = 0;
            this.PencilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PencilBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PencilBtn.Image = global::ImageEditor.Properties.Resources.icons8_Edit_25px;
            this.PencilBtn.Location = new System.Drawing.Point(221, 10);
            this.PencilBtn.Margin = new System.Windows.Forms.Padding(0);
            this.PencilBtn.Name = "PencilBtn";
            this.PencilBtn.Size = new System.Drawing.Size(30, 30);
            this.PencilBtn.TabIndex = 4;
            this.PencilBtn.Tag = "";
            this.PencilBtn.UseVisualStyleBackColor = false;
            this.PencilBtn.Click += new System.EventHandler(this.PainterBtn_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(358, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Shapes";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(219, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Pen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1215, 719);
            this.Controls.Add(this.BackgroundPnl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ToolsPnl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "ImageEditor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ToolsPnl.ResumeLayout(false);
            this.ToolsPnl.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.BackgroundPnl.ResumeLayout(false);
            this.ShadowPic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PatternPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Panel ToolsPnl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LocationMouseTSSL;
        private System.Windows.Forms.ToolStripStatusLabel SizePictureTSSL;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel BackgroundPnl;
        private System.Windows.Forms.Panel ShadowPic;
        private System.Windows.Forms.PictureBox PatternPB;
        private System.Windows.Forms.Button PencilBtn;
        private System.Windows.Forms.Button Color1Btn;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DomainUpDown SizeDUD;
        private System.Windows.Forms.Panel BotLeftAnglePnl;
        private System.Windows.Forms.Panel TopRightAnglePnl;
        private System.Windows.Forms.Button PaletteBtn;
        private System.Windows.Forms.ImageList ImgsPalette;
        private System.Windows.Forms.Timer FoldingPaletteTmr;
        private System.Windows.Forms.Label Color2Lbl;
        private System.Windows.Forms.Button Color2Btn;
        private System.Windows.Forms.Label Color1Lbl;
        private System.Windows.Forms.Button RectangleBtn;
        private System.Windows.Forms.Button EllipseBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label EditColorsLbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button LineBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

