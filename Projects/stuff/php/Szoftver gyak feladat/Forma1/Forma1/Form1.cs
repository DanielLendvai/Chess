using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forma1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

                         //        idx
                         //         |
                         //         v
                         //            1         2
                         //  012345678901234567890123
            string szoveg = "Na, mi újság, Wágner úr?";
            int idx = szoveg.IndexOf('ú');
            string s1 = szoveg.Substring(0, idx + 1), s2 = szoveg.Substring(idx + 1, szoveg.Length - idx - 1);
            char[] szt = szoveg.ToCharArray();
            szt[4] = 'A';

            string adoszam = "82345678";
            if(adoszam[0] != '8')
                throw new Exception("Hibás adószám");
            int crc = 0;
            for(int i = 0; i < adoszam.Length; i++)
                crc += (adoszam[i] - '0') * (i + 1);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void nemÚjoncokListájaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            nemUjonc1.FillDGV();
            nemUjonc1.Visible = true;
            ujVersenyzo1.Visible = false;
        }

        private void kezdőapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nemUjonc1.Visible = false;
            pictureBox1.Visible = true;
            ujVersenyzo1.Visible = false;
        }

        private void újVersenyzőFelvételeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            nemUjonc1.Visible = false;
            ujVersenyzo1.Visible = true;
        }

        private void nemUjonc1_Load(object sender, EventArgs e)
        {

        }

        private void ujVersenyzo1_Load(object sender, EventArgs e)
        {

        }
    }
}
