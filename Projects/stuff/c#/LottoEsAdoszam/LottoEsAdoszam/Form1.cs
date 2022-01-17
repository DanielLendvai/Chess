using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LottoEsAdoszam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ötösToolStripMenuItem_Click(object sender, EventArgs e)
        {         
            groupBox2.Visible = false;
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.Visible = true;
            tableLayoutPanel1.ColumnCount = 9;
            for (int i = 1; i <= 9; i++)
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.RowCount = 9;
            for (int i = 1; i <= 9; i++)
                tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();
            for (int i = 1; i < 100; i++)
            {
                CheckBox cb = new CheckBox();
                cb.AutoSize = true;
                cb.Text = "" + i;
                cb.CheckedChanged += Kattintas5;
                tableLayoutPanel1.Controls.Add(cb);
            }
        }
        private void lottókToolStripMenuItem_Click(object sender, EventArgs e)
        {            
        }

/// <summary>
/// kattintas szamlalo eventek
/// </summary>
        int db = 0;
        void Kattintas5(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.CheckState == CheckState.Checked) db++; else db--;
            if (db == 5)
            {
                foreach (Control c in tableLayoutPanel1.Controls)
                {
                    CheckBox cb2 = c as CheckBox;
                    if (!cb2.Checked) cb2.Enabled = false;
                }
                groupBox1.Visible = true;
            }
        }
        void Kattintas6(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.CheckState == CheckState.Checked) db++; else db--;
            if (db == 6)
            {
                foreach (Control c in tableLayoutPanel1.Controls)
                {
                    CheckBox cb2 = c as CheckBox;
                    if (!cb2.Checked) cb2.Enabled = false;
                }
                groupBox1.Visible = true;
            }
        }
        void Kattintas7(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.CheckState == CheckState.Checked) db++; else db--;
            if (db == 7)
            {
                foreach (Control c in tableLayoutPanel1.Controls)
                {
                    CheckBox cb2 = c as CheckBox;
                    if (!cb2.Checked) cb2.Enabled = false;
                }
                groupBox1.Visible = true;
            }
        }


        private void hatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.Visible = true;
            tableLayoutPanel1.ColumnCount = 7;
            for (int i = 1; i <= 7; i++)
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.RowCount = 7;
            for (int i = 1; i <= 7; i++)
                tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();
            for (int i = 1; i < 46; i++)
            {
                CheckBox cb = new CheckBox();
                cb.AutoSize = true;
                cb.Text = "" + i;
                cb.CheckedChanged += Kattintas6;
                tableLayoutPanel1.Controls.Add(cb);
            }
        }

        private void skandinávToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.Visible = true;
            tableLayoutPanel1.ColumnCount = 5;
            for (int i = 1; i <= 5; i++)
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.RowCount = 7;
            for (int i = 1; i <= 7; i++)
                tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();
            for (int i = 1; i < 36; i++)
            {
                CheckBox cb = new CheckBox();
                cb.AutoSize = true;
                cb.Text = "" + i;
                cb.CheckedChanged += Kattintas7;
                tableLayoutPanel1.Controls.Add(cb);
            }
        }

        private void adószámGenerátorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.Visible = false;
            groupBox2.Visible = true;
            groupBox1.Visible = false;
            button2.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string adoszam = "8";
            int nap = dateTimePicker1.Value.Subtract(new DateTime(1867, 01, 01)).Days;
            Random r = new Random();
             
            int sorszam = r.Next(0, 1000);
            string sorsz = "";
            if (sorszam < 10)
            {
                sorsz = "00" + sorszam;
            }
            else if (sorszam >= 10 && sorszam < 100)
            {
                sorsz = "0" + sorszam;
            }
            else
            {
                sorsz = sorsz + sorszam;
            }
            adoszam = adoszam + nap + sorsz;
            while (true)
            {
                int szorzatOsszeg = 0;
                for (int i = 0; i < 9; i++)
                {
                    szorzatOsszeg += (adoszam[i] - 48) * (i + 1);
                }
                int maradek = szorzatOsszeg % 11;
                if (maradek < 10)
                {
                    adoszam += maradek;
                    break;
                }
                else
                {
                    sorszam++;
                    sorsz = "" + sorszam;
                    adoszam = "8" + nap + sorsz;
                }
            }
            Graphics rl = label3.CreateGraphics();
            Font f = new Font("Arial", 36);
            rl.DrawString(adoszam, this.Font, new SolidBrush(Color.Red), 20, 20);
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("tippek.txt", true);
            string sor = textBox1.Text;
            sor += ": ";
            sor += DateTime.Now;
            sor += " | tippek:  ";
            foreach (Control c in tableLayoutPanel1.Controls)
            {
                if (c.Enabled)
                {
                    sor += c.Text;
                    sor += " ";
                }
            }
            sw.WriteLine(sor);
            sw.Close();
            button1.Enabled = false;
        }
    }
}
