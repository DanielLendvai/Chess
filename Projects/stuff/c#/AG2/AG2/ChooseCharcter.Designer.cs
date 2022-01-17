
namespace AG2
{
    partial class ChooseCharcter
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
            this.Profiles = new System.Windows.Forms.ListView();
            this.nameHeader = new System.Windows.Forms.ColumnHeader();
            this.charHeader = new System.Windows.Forms.ColumnHeader();
            this.pointHeader = new System.Windows.Forms.ColumnHeader();
            this.CharClass = new System.Windows.Forms.ComboBox();
            this.CharGender = new System.Windows.Forms.ComboBox();
            this.btnSaveChar = new System.Windows.Forms.Button();
            this.CharName = new System.Windows.Forms.TextBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Profiles
            // 
            this.Profiles.BackColor = System.Drawing.Color.Silver;
            this.Profiles.BackgroundImageTiled = true;
            this.Profiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameHeader,
            this.charHeader,
            this.pointHeader});
            this.Profiles.Font = new System.Drawing.Font("Candara Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Profiles.FullRowSelect = true;
            this.Profiles.GridLines = true;
            this.Profiles.HideSelection = false;
            this.Profiles.Location = new System.Drawing.Point(13, 16);
            this.Profiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Profiles.Name = "Profiles";
            this.Profiles.Scrollable = false;
            this.Profiles.Size = new System.Drawing.Size(273, 157);
            this.Profiles.TabIndex = 22;
            this.Profiles.UseCompatibleStateImageBehavior = false;
            this.Profiles.View = System.Windows.Forms.View.Details;
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Név";
            this.nameHeader.Width = 80;
            // 
            // charHeader
            // 
            this.charHeader.Text = "Karakter";
            this.charHeader.Width = 80;
            // 
            // pointHeader
            // 
            this.pointHeader.Text = "Max. Pontszám";
            this.pointHeader.Width = 110;
            // 
            // CharClass
            // 
            this.CharClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CharClass.Font = new System.Drawing.Font("Candara Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CharClass.FormattingEnabled = true;
            this.CharClass.Items.AddRange(new object[] {
            "Harcos",
            "Vadász",
            "Mágus",
            "Lovag",
            "Tolvaj"});
            this.CharClass.Location = new System.Drawing.Point(292, 49);
            this.CharClass.Name = "CharClass";
            this.CharClass.Size = new System.Drawing.Size(260, 30);
            this.CharClass.TabIndex = 20;
            this.CharClass.Text = "Válassz karaktert";
            this.CharClass.SelectedIndexChanged += new System.EventHandler(this.CharClass_SelectedIndexChanged);
            // 
            // CharGender
            // 
            this.CharGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CharGender.Font = new System.Drawing.Font("Candara Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CharGender.FormattingEnabled = true;
            this.CharGender.Items.AddRange(new object[] {
            "Férfi",
            "Nő",
            "Ismeretlen"});
            this.CharGender.Location = new System.Drawing.Point(292, 83);
            this.CharGender.Name = "CharGender";
            this.CharGender.Size = new System.Drawing.Size(260, 30);
            this.CharGender.TabIndex = 19;
            this.CharGender.Text = "Válassz nemet";
            // 
            // btnSaveChar
            // 
            this.btnSaveChar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveChar.Font = new System.Drawing.Font("Candara Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveChar.Location = new System.Drawing.Point(423, 120);
            this.btnSaveChar.Name = "btnSaveChar";
            this.btnSaveChar.Size = new System.Drawing.Size(129, 53);
            this.btnSaveChar.TabIndex = 17;
            this.btnSaveChar.Text = "Mentsd el";
            this.btnSaveChar.UseVisualStyleBackColor = true;
            this.btnSaveChar.Click += new System.EventHandler(this.btnSaveChar_Click);
            // 
            // CharName
            // 
            this.CharName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CharName.BackColor = System.Drawing.Color.LightGray;
            this.CharName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CharName.Font = new System.Drawing.Font("Candara Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CharName.HideSelection = false;
            this.CharName.Location = new System.Drawing.Point(292, 16);
            this.CharName.Multiline = true;
            this.CharName.Name = "CharName";
            this.CharName.Size = new System.Drawing.Size(260, 27);
            this.CharName.TabIndex = 16;
            this.CharName.Text = "Írd be a neved";
            this.CharName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CharName.WordWrap = false;
            this.CharName.Enter += new System.EventHandler(this.CharName_Enter);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartGame.Font = new System.Drawing.Font("Candara Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStartGame.Location = new System.Drawing.Point(288, 120);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(129, 53);
            this.btnStartGame.TabIndex = 14;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // ChooseCharcter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Profiles);
            this.Controls.Add(this.CharClass);
            this.Controls.Add(this.CharGender);
            this.Controls.Add(this.btnSaveChar);
            this.Controls.Add(this.CharName);
            this.Controls.Add(this.btnStartGame);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ChooseCharcter";
            this.Size = new System.Drawing.Size(568, 190);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Profiles;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader charHeader;
        private System.Windows.Forms.ComboBox CharClass;
        private System.Windows.Forms.ComboBox CharGender;
        private System.Windows.Forms.Button btnSaveChar;
        private System.Windows.Forms.TextBox CharName;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.ColumnHeader pointHeader;
    }
}
