
namespace Forma1
{
    partial class UjVersenyzo
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
            this.label2 = new System.Windows.Forms.Label();
            this.input_vnev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.input_vrajt = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.input_ujonc = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.input_datum = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            this.errorNev = new System.Windows.Forms.Label();
            this.errorRajt = new System.Windows.Forms.Label();
            this.errorDatum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.input_vrajt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1029, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "Új versenyző felvétele";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(146, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 56);
            this.label2.TabIndex = 1;
            this.label2.Text = "Versenyző neve";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_vnev
            // 
            this.input_vnev.Location = new System.Drawing.Point(338, 105);
            this.input_vnev.Name = "input_vnev";
            this.input_vnev.Size = new System.Drawing.Size(387, 39);
            this.input_vnev.TabIndex = 2;
            this.input_vnev.TextChanged += new System.EventHandler(this.input_vnev_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(92, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 56);
            this.label3.TabIndex = 3;
            this.label3.Text = "Versenyző rajtszáma";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_vrajt
            // 
            this.input_vrajt.Location = new System.Drawing.Point(338, 174);
            this.input_vrajt.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.input_vrajt.Name = "input_vrajt";
            this.input_vrajt.Size = new System.Drawing.Size(387, 39);
            this.input_vrajt.TabIndex = 4;
            this.input_vrajt.ValueChanged += new System.EventHandler(this.input_vrajt_ValueChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(92, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 56);
            this.label4.TabIndex = 5;
            this.label4.Text = "Versenyző csapata";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(338, 229);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(387, 39);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(92, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 56);
            this.label5.TabIndex = 7;
            this.label5.Text = "Újonc?";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_ujonc
            // 
            this.input_ujonc.Location = new System.Drawing.Point(338, 275);
            this.input_ujonc.Name = "input_ujonc";
            this.input_ujonc.Size = new System.Drawing.Size(303, 51);
            this.input_ujonc.TabIndex = 8;
            this.input_ujonc.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(92, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 56);
            this.label6.TabIndex = 9;
            this.label6.Text = "Belépés dátuma";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_datum
            // 
            this.input_datum.Location = new System.Drawing.Point(338, 338);
            this.input_datum.Name = "input_datum";
            this.input_datum.Size = new System.Drawing.Size(387, 39);
            this.input_datum.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(338, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 43);
            this.button1.TabIndex = 11;
            this.button1.Text = "Felvétel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_result
            // 
            this.label_result.Location = new System.Drawing.Point(338, 466);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(387, 25);
            this.label_result.TabIndex = 12;
            // 
            // errorNev
            // 
            this.errorNev.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorNev.ForeColor = System.Drawing.SystemColors.Desktop;
            this.errorNev.Location = new System.Drawing.Point(744, 105);
            this.errorNev.Name = "errorNev";
            this.errorNev.Size = new System.Drawing.Size(250, 39);
            this.errorNev.TabIndex = 13;
            this.errorNev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorRajt
            // 
            this.errorRajt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorRajt.ForeColor = System.Drawing.SystemColors.Desktop;
            this.errorRajt.Location = new System.Drawing.Point(744, 172);
            this.errorRajt.Name = "errorRajt";
            this.errorRajt.Size = new System.Drawing.Size(225, 39);
            this.errorRajt.TabIndex = 14;
            this.errorRajt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorDatum
            // 
            this.errorDatum.ForeColor = System.Drawing.SystemColors.Desktop;
            this.errorDatum.Location = new System.Drawing.Point(783, 338);
            this.errorDatum.Name = "errorDatum";
            this.errorDatum.Size = new System.Drawing.Size(186, 39);
            this.errorDatum.TabIndex = 15;
            this.errorDatum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UjVersenyzo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.errorDatum);
            this.Controls.Add(this.errorRajt);
            this.Controls.Add(this.errorNev);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.input_datum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.input_ujonc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.input_vrajt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input_vnev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UjVersenyzo";
            this.Size = new System.Drawing.Size(1029, 518);
            this.Load += new System.EventHandler(this.UjVersenyzo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.input_vrajt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input_vnev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown input_vrajt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox input_ujonc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker input_datum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label errorNev;
        private System.Windows.Forms.Label errorRajt;
        private System.Windows.Forms.Label errorDatum;
    }
}
