
namespace AG2
{
    partial class PlayGame
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
            if(disposing && (components != null))
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
            this.labelText = new System.Windows.Forms.Label();
            this.Szoveg = new System.Windows.Forms.TextBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.Dobas = new System.Windows.Forms.Label();
            this.btnGo1 = new System.Windows.Forms.Button();
            this.btnGo2 = new System.Windows.Forms.Button();
            this.btnGo3 = new System.Windows.Forms.Button();
            this.labelPoints = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.BackColor = System.Drawing.Color.Transparent;
            this.labelText.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelText.Location = new System.Drawing.Point(-1, 23);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(167, 31);
            this.labelText.TabIndex = 8;
            this.labelText.Text = "Elért pontok:";
            this.labelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Szoveg
            // 
            this.Szoveg.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Szoveg.Location = new System.Drawing.Point(10, 13);
            this.Szoveg.Multiline = true;
            this.Szoveg.Name = "Szoveg";
            this.Szoveg.ReadOnly = true;
            this.Szoveg.Size = new System.Drawing.Size(565, 259);
            this.Szoveg.TabIndex = 7;
            // 
            // btnAction
            // 
            this.btnAction.BackColor = System.Drawing.Color.Transparent;
            this.btnAction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAction.Location = new System.Drawing.Point(581, 221);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(163, 129);
            this.btnAction.TabIndex = 6;
            this.btnAction.Text = "Dobj!";
            this.btnAction.UseVisualStyleBackColor = false;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // Dobas
            // 
            this.Dobas.BackColor = System.Drawing.Color.Transparent;
            this.Dobas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dobas.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Dobas.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Dobas.Location = new System.Drawing.Point(44, 23);
            this.Dobas.Name = "Dobas";
            this.Dobas.Size = new System.Drawing.Size(75, 77);
            this.Dobas.TabIndex = 5;
            this.Dobas.Text = "0";
            this.Dobas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGo1
            // 
            this.btnGo1.Location = new System.Drawing.Point(14, 296);
            this.btnGo1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGo1.Name = "btnGo1";
            this.btnGo1.Size = new System.Drawing.Size(183, 54);
            this.btnGo1.TabIndex = 10;
            this.btnGo1.UseVisualStyleBackColor = true;
            this.btnGo1.Click += new System.EventHandler(this.btnGo1_Click);
            // 
            // btnGo2
            // 
            this.btnGo2.Location = new System.Drawing.Point(203, 296);
            this.btnGo2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGo2.Name = "btnGo2";
            this.btnGo2.Size = new System.Drawing.Size(183, 54);
            this.btnGo2.TabIndex = 11;
            this.btnGo2.UseVisualStyleBackColor = true;
            this.btnGo2.Click += new System.EventHandler(this.btnGo2_Click);
            // 
            // btnGo3
            // 
            this.btnGo3.Location = new System.Drawing.Point(392, 296);
            this.btnGo3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGo3.Name = "btnGo3";
            this.btnGo3.Size = new System.Drawing.Size(183, 54);
            this.btnGo3.TabIndex = 12;
            this.btnGo3.UseVisualStyleBackColor = true;
            this.btnGo3.Click += new System.EventHandler(this.btnGo3_Click);
            // 
            // labelPoints
            // 
            this.labelPoints.Font = new System.Drawing.Font("Bell MT", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPoints.ForeColor = System.Drawing.Color.White;
            this.labelPoints.Location = new System.Drawing.Point(53, 50);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(57, 44);
            this.labelPoints.TabIndex = 13;
            this.labelPoints.Text = "0";
            this.labelPoints.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelText);
            this.groupBox1.Controls.Add(this.labelPoints);
            this.groupBox1.Location = new System.Drawing.Point(582, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 98);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statisztika";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Dobas);
            this.groupBox2.Location = new System.Drawing.Point(582, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 105);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dobásod";
            // 
            // PlayGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGo3);
            this.Controls.Add(this.btnGo2);
            this.Controls.Add(this.btnGo1);
            this.Controls.Add(this.Szoveg);
            this.Controls.Add(this.btnAction);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PlayGame";
            this.Size = new System.Drawing.Size(759, 368);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.TextBox Szoveg;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Label Dobas;
        private System.Windows.Forms.Button btnGo1;
        private System.Windows.Forms.Button btnGo2;
        private System.Windows.Forms.Button btnGo3;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
