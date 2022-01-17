
namespace Forma1
{
    partial class NemUjonc
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rajtszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vnev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nemzetiseg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csnev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(763, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "A nem újonc versenyzők listája";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rajtszam,
            this.vnev,
            this.nemzetiseg,
            this.csnev});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(763, 349);
            this.dataGridView1.TabIndex = 1;
            // 
            // rajtszam
            // 
            this.rajtszam.FillWeight = 65.34074F;
            this.rajtszam.HeaderText = "Rajtszám";
            this.rajtszam.MinimumWidth = 6;
            this.rajtszam.Name = "rajtszam";
            this.rajtszam.ReadOnly = true;
            // 
            // vnev
            // 
            this.vnev.FillWeight = 106.9519F;
            this.vnev.HeaderText = "Versenyző";
            this.vnev.MinimumWidth = 6;
            this.vnev.Name = "vnev";
            this.vnev.ReadOnly = true;
            // 
            // nemzetiseg
            // 
            this.nemzetiseg.FillWeight = 129.2981F;
            this.nemzetiseg.HeaderText = "Nemzetiség";
            this.nemzetiseg.MinimumWidth = 6;
            this.nemzetiseg.Name = "nemzetiseg";
            this.nemzetiseg.ReadOnly = true;
            // 
            // csnev
            // 
            this.csnev.FillWeight = 98.40929F;
            this.csnev.HeaderText = "Csapat";
            this.csnev.MinimumWidth = 6;
            this.csnev.Name = "csnev";
            this.csnev.ReadOnly = true;
            // 
            // NemUjonc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "NemUjonc";
            this.Size = new System.Drawing.Size(763, 437);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rajtszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn vnev;
        private System.Windows.Forms.DataGridViewTextBoxColumn nemzetiseg;
        private System.Windows.Forms.DataGridViewTextBoxColumn csnev;
    }
}
