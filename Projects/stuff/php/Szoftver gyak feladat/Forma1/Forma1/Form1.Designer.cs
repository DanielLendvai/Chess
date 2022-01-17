
namespace Forma1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kezdőapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nemÚjoncokListájaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újVersenyzőFelvételeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nemUjonc1 = new Forma1.NemUjonc();
            this.ujVersenyzo1 = new Forma1.UjVersenyzo();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kezdőapToolStripMenuItem,
            this.nemÚjoncokListájaToolStripMenuItem,
            this.újVersenyzőFelvételeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1131, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // kezdőapToolStripMenuItem
            // 
            this.kezdőapToolStripMenuItem.Name = "kezdőapToolStripMenuItem";
            this.kezdőapToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.kezdőapToolStripMenuItem.Text = "Kezdőap";
            this.kezdőapToolStripMenuItem.Click += new System.EventHandler(this.kezdőapToolStripMenuItem_Click);
            // 
            // nemÚjoncokListájaToolStripMenuItem
            // 
            this.nemÚjoncokListájaToolStripMenuItem.Name = "nemÚjoncokListájaToolStripMenuItem";
            this.nemÚjoncokListájaToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.nemÚjoncokListájaToolStripMenuItem.Text = "Nem újoncok listája";
            this.nemÚjoncokListájaToolStripMenuItem.Click += new System.EventHandler(this.nemÚjoncokListájaToolStripMenuItem_Click);
            // 
            // újVersenyzőFelvételeToolStripMenuItem
            // 
            this.újVersenyzőFelvételeToolStripMenuItem.Name = "újVersenyzőFelvételeToolStripMenuItem";
            this.újVersenyzőFelvételeToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.újVersenyzőFelvételeToolStripMenuItem.Text = "Új versenyző felvétele";
            this.újVersenyzőFelvételeToolStripMenuItem.Click += new System.EventHandler(this.újVersenyzőFelvételeToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1131, 580);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // nemUjonc1
            // 
            this.nemUjonc1.AutoSize = true;
            this.nemUjonc1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nemUjonc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nemUjonc1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nemUjonc1.Location = new System.Drawing.Point(0, 28);
            this.nemUjonc1.Margin = new System.Windows.Forms.Padding(5);
            this.nemUjonc1.Name = "nemUjonc1";
            this.nemUjonc1.Size = new System.Drawing.Size(1131, 580);
            this.nemUjonc1.TabIndex = 2;
            this.nemUjonc1.Visible = false;
            this.nemUjonc1.Load += new System.EventHandler(this.nemUjonc1_Load);
            // 
            // ujVersenyzo1
            // 
            this.ujVersenyzo1.AutoSize = true;
            this.ujVersenyzo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ujVersenyzo1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ujVersenyzo1.Location = new System.Drawing.Point(0, 28);
            this.ujVersenyzo1.Margin = new System.Windows.Forms.Padding(5);
            this.ujVersenyzo1.Name = "ujVersenyzo1";
            this.ujVersenyzo1.Size = new System.Drawing.Size(1131, 580);
            this.ujVersenyzo1.TabIndex = 3;
            this.ujVersenyzo1.Visible = false;
            this.ujVersenyzo1.Load += new System.EventHandler(this.ujVersenyzo1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 608);
            this.Controls.Add(this.ujVersenyzo1);
            this.Controls.Add(this.nemUjonc1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Forma1 2021";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kezdőapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nemÚjoncokListájaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újVersenyzőFelvételeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private NemUjonc nemUjonc1;
        private UjVersenyzo ujVersenyzo1;
    }
}

