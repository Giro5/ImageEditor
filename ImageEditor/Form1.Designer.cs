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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsPnl = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LocationMouseTSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.SizePictureTSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.BackgroundPnl = new System.Windows.Forms.Panel();
            this.ShadowPic = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PencilBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.ToolsPnl.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.BackgroundPnl.SuspendLayout();
            this.ShadowPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1215, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(111, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // ToolsPnl
            // 
            this.ToolsPnl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ToolsPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1070, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1070, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1070, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1070, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LocationMouseTSSL,
            this.SizePictureTSSL});
            this.statusStrip1.Location = new System.Drawing.Point(0, 697);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1215, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LocationMouseTSSL
            // 
            this.LocationMouseTSSL.AutoSize = false;
            this.LocationMouseTSSL.BackColor = System.Drawing.SystemColors.ButtonFace;
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
            this.SizePictureTSSL.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SizePictureTSSL.Image = global::ImageEditor.Properties.Resources.icons8_Surface_32px;
            this.SizePictureTSSL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SizePictureTSSL.Name = "SizePictureTSSL";
            this.SizePictureTSSL.Size = new System.Drawing.Size(200, 17);
            this.SizePictureTSSL.Text = "size picturebox";
            this.SizePictureTSSL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.ShadowPic.BackColor = System.Drawing.Color.DimGray;
            this.ShadowPic.Controls.Add(this.pictureBox1);
            this.ShadowPic.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.ShadowPic.Location = new System.Drawing.Point(5, 5);
            this.ShadowPic.Name = "ShadowPic";
            this.ShadowPic.Size = new System.Drawing.Size(1000, 500);
            this.ShadowPic.TabIndex = 3;
            this.ShadowPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShadowPic_MouseDown);
            this.ShadowPic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ShadowPic_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(995, 495);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.SizeChanged += new System.EventHandler(this.pictureBox1_SizeChanged);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // PencilBtn
            // 
            this.PencilBtn.FlatAppearance.BorderSize = 0;
            this.PencilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PencilBtn.Location = new System.Drawing.Point(199, 9);
            this.PencilBtn.Margin = new System.Windows.Forms.Padding(0);
            this.PencilBtn.Name = "PencilBtn";
            this.PencilBtn.Size = new System.Drawing.Size(25, 25);
            this.PencilBtn.TabIndex = 4;
            this.PencilBtn.Tag = "0";
            this.PencilBtn.Text = "P";
            this.PencilBtn.UseVisualStyleBackColor = true;
            this.PencilBtn.Click += new System.EventHandler(this.PencilBtn_Click);
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
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.BackgroundPnl.ResumeLayout(false);
            this.ShadowPic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button PencilBtn;
    }
}

