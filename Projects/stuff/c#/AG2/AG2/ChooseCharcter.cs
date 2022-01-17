using System;
using System.Windows.Forms;

namespace AG2
{

    public partial class ChooseCharcter : UserControl
    {

        private void PopulateProfilesView(Profile profile = null)
        {
            Profiles.BeginUpdate();
            try
            {
                Profiles.Items.Clear();
                foreach(var pr in Game.Current.Profiles)
                {
                    ListViewItem li = Profiles.Items.Add(pr.Name);
                    li.SubItems.Add(Enum.GetName(typeof(CharacterClass), pr.Class));
                    li.Tag = pr;
                    if(pr == profile)
                    {
                        li.Selected = true;
                        li.Focused = true;
                    }
                }
            }
            finally
            {
                Profiles.EndUpdate();
            }
        }

        private Profile CreateCharacter()
        {
            string name = CharName.Text;
            if(string.IsNullOrEmpty(name))
            {
                CharName.Focus();
                return null;
            }

            if(CharClass.SelectedIndex < 0)
            {
                CharClass.Focus();
                return null;
            }

            if(CharGender.SelectedIndex < 0)
            {
                CharGender.Focus();
                return null;
            }

            Profile ent = new Profile();

            ent.Fejezet = 1;
            ent.Pontszam = 0;
            ent.Name = name;
            ent.Gender = (CharacterGender) CharGender.SelectedIndex;
            ent.Class  = (CharacterClass) CharClass.SelectedIndex;

            return ent;
        }

        public ChooseCharcter()
        {
            InitializeComponent();

            PopulateProfilesView();
        }
        
        private void btnSaveChar_Click(object sender, EventArgs e)
        {
            Profile profile = CreateCharacter();
            if(profile == null)
                return;
            Game.Current.Profiles.Add(profile);
            Game.Current.Save();
            PopulateProfilesView(profile);
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if(Profiles.SelectedItems.Count == 0)
                return;
            Profile profile = (Profile) Profiles.SelectedItems[0].Tag;
            Game.Current.Profile = profile;
            if(_onStart != null)
                _onStart(this, EventArgs.Empty);
        }

        private EventHandler _onStart;

        public event EventHandler OnStart
        {
            add => _onStart += value;
            remove => _onStart -= value;
        }

        private void CharClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        bool hasBeenClicked = false;
        private void CharName_Enter(object sender, EventArgs e)
        {
            if (!hasBeenClicked)
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                hasBeenClicked = true;
            }
        }
    }
}
