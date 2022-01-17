using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AG2
{
    public partial class MainForm : Form
    {
        private void OnStart(object sender, EventArgs e)
        {
            Controls.Clear();
            PlayGame play = new PlayGame();
            Controls.Add(play);
            Text = Game.Current.Profile.Name;
        }

        public MainForm()
        {
            InitializeComponent();

           if(DesignMode)
                return;

            Game.Current.Load();
            ChooseCharcter loginDlg = new ChooseCharcter();
            loginDlg.OnStart += OnStart;
            Controls.Add(loginDlg);
        }
    }
}
