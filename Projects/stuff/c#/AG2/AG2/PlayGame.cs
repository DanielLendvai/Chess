using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AG2
{
    /// <summary>
    /// A játék végrehajtó motorja
    /// </summary>
    public partial class PlayGame : UserControl
    {
        public int counter;

        /// <summary>
        /// Egy fejezet típusa
        /// </summary>
        private enum Mode
        {
            /// <summary>
            /// Nincs harc
            /// </summary>
            Bekes,
            Harcos,
            Nyertel,
            Vesztettel
        }
        private Mode _mode;
        private Fejezet _fejezet;

        /// <summary>
        /// A képernyő tartalom frissítése az aktuális játék fejezet alapján
        /// </summary>
        private void UpdateVisuals()
        {
            switch(_mode)
            {
                case Mode.Bekes:
                    labelPoints.Text = Convert.ToString(counter);
                    Szoveg.Text = _fejezet.Szoveg;
                    Dobas.Visible = false;
                    btnGo1.Visible = _fejezet.Hivatkozasok != null && _fejezet.Hivatkozasok.Length > 0;
                    if(btnGo1.Visible)
                        btnGo1.Text = Game.Current.Fejezetek[_fejezet.Hivatkozasok[0] - 1].Nev;
                    btnGo2.Visible = _fejezet.Hivatkozasok != null && _fejezet.Hivatkozasok.Length > 1;
                    if(btnGo2.Visible)
                        btnGo2.Text = Game.Current.Fejezetek[_fejezet.Hivatkozasok[1] - 1].Nev;
                    btnGo3.Visible = _fejezet.Hivatkozasok != null && _fejezet.Hivatkozasok.Length > 2;
                    if(btnGo3.Visible)
                        btnGo3.Text = Game.Current.Fejezetek[_fejezet.Hivatkozasok[2] - 1].Nev;
                    btnAction.Text = "Tovább";
                    break;

                case Mode.Harcos:
                    labelPoints.Text = Convert.ToString(counter);
                    Szoveg.Text = _fejezet.Szoveg;
                    Dobas.Visible = true;
                    btnGo1.Visible = btnGo2.Visible = btnGo3.Visible = false;
                    btnAction.BackgroundImage = AG2.Properties.Resources._102683615_pair_of_dice_to_gamble_or_gambling_in_craps_line_art_vector_icon_for_casino_apps_and_websites;
                    btnAction.Text = "";
                    break;

                case Mode.Nyertel:
                    Szoveg.Text = _fejezet.NyertelSzoveg;
                    btnAction.BackgroundImage = null;
                    btnAction.Text = "Tovább";
                    counter++;
                    break;

                case Mode.Vesztettel:
                    Szoveg.Text = _fejezet.VesztettelSzoveg;
                    btnAction.BackgroundImage = null;
                    btnAction.Text = "Tovább";
                    counter--;
                    break;
            
            }
        }

        /// <summary>
        /// Fejezetre lépés
        /// </summary>
        /// <param name="fejezet">a fejezet azonosítója</param>
        private void MoveTo(int fejezet)
        {
            _fejezet = Game.Current.Fejezetek[fejezet - 1];
            switch(_fejezet.Tipus)
            {
                case HarcTipus.Bekes:
                    _mode = Mode.Bekes;
                    break;

                case HarcTipus.Harcos:
                    _mode = Mode.Harcos;
                    break;
            }
            UpdateVisuals();
        }

        /// <summary>
        /// A játék indítása
        /// </summary>
        public PlayGame()
        {
            InitializeComponent();
            MoveTo(Game.Current.Profile.Fejezet);
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            int fejezet;
            switch(_mode)
            {
                case Mode.Bekes:
                    fejezet = _fejezet.Kovetkezo > 0 ? _fejezet.Kovetkezo : Game.Current.Profile.Fejezet + 1;
                    MoveTo(fejezet);                    
                    break;

                case Mode.Harcos:
                    Random r = new Random();
                    int randomNumber = r.Next(0, 11);
                    Dobas.Text = Convert.ToString(randomNumber);
                    if(randomNumber >= _fejezet.NyeroDobas)
                        _mode = Mode.Nyertel;
                    else
                        _mode = Mode.Vesztettel;
                    UpdateVisuals();
                    break;

                case Mode.Nyertel:
                    fejezet = _fejezet.Kovetkezo > 0 ? _fejezet.Kovetkezo : Game.Current.Profile.Fejezet + 1;
                    MoveTo(fejezet);
                    break;

                case Mode.Vesztettel:
                    MoveTo(_fejezet.Elozo);
                    break;
            }
        }

        private void btnGo1_Click(object sender, EventArgs e)
        {
            MoveTo(_fejezet.Hivatkozasok[0]);
        }

        private void btnGo2_Click(object sender, EventArgs e)
        {
            MoveTo(_fejezet.Hivatkozasok[1]);
        }

        private void btnGo3_Click(object sender, EventArgs e)
        {
            MoveTo(_fejezet.Hivatkozasok[2]);
        }
    }
}
