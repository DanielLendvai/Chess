using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Forma1
{
    public partial class UjVersenyzo : UserControl
    {

        MySqlConnection Conn;
        bool errNev, errRajtszam = false;

        public UjVersenyzo()
        {
            InitializeComponent();
            Conn = Connect.InitDB();
        }

        private void UjVersenyzo_Load(object sender, EventArgs e)
        {
            using (var conn = Connect.InitDB())
            {
                conn.Open();
                string query = "CALL Pr_Csapatok;";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        comboBox1.Items.Add
                            (
                                reader["nev"] + " (" +
                                reader["azon"] + ")"
                            );
                    }
            }
            comboBox1.SelectedIndex = 0;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         }

        private void button1_Click(object sender, EventArgs e)
        {
            string vnev = input_vnev.Text;
            int rajtszam = (int)input_vrajt.Value;
            string csapat = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            csapat = csapat.Remove(0, csapat.IndexOf("(")+1);
            csapat = csapat.Remove(csapat.IndexOf(")"));
            int csapatazon = int.Parse(csapat);
            bool ujonc = input_ujonc.Checked;
            DateTime datum = input_datum.Value;

            string query = "CALL pr_UjVersenyzo(@vNev, @vRajt, @csAzon, @ujonc, @belep);";
            //string query = "INSERT INTO versenyzok(nev, rajtszam, ujonc, belepes) VALUES(@vNev, @vRajt, @ujonc, @belep)";
            MySqlCommand cmd = new MySqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("@vNev", vnev);
            cmd.Parameters["@vNev"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@vRajt", rajtszam);
            cmd.Parameters["@vRajt"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@csAzon", csapatazon);
            cmd.Parameters["@csAzon"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@ujonc", ujonc ? 1 : 0);
            cmd.Parameters["@ujonc"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@belep", datum);
            cmd.Parameters["@belep"].Direction = ParameterDirection.Input;

            Conn.Open();
            int result = cmd.ExecuteNonQuery();
            Conn.Close();
            if(result == 0)
            {
                label_result.ForeColor = Color.Red;
                label_result.Text = "Nem sikerült a felvétel.";
            }
            else
            {
                label_result.ForeColor = Color.Green;
                label_result.Text = "Sikerült a felvétel.";
            }
        }

        private void input_vnev_TextChanged(object sender, EventArgs e)
        {
            if(input_vnev.Text.Length < 6)
            {
                errNev = false;
                errorNev.Text = "Túl rövid a versenyző neve.";
            }
            else
            {                
                errorNev.Text = "";
                errNev = true;
                if (Error())
                    button1.Enabled = true;
            }
        }

        private void input_vrajt_ValueChanged(object sender, EventArgs e)
        {
            int rajtszam = (int)input_vrajt.Value;
            string query = "CALL pr_CheckRajtszam(@rajtszam);";
            MySqlCommand cmd = new MySqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("@rajtszam", rajtszam);
            cmd.Parameters["@rajtszam"].Direction = ParameterDirection.Input;

            Conn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            reader.Read();
            if(Convert.ToInt32(reader["van"]) == 0)
            {
                errorRajt.Text = "";
                errRajtszam = true;
                if (Error())
                    button1.Enabled = true;
            }
            else
            {
                errorRajt.Text = "Ez a rajtszám foglalt.";
                errRajtszam = false;
            }
            Conn.Close();
        }
    private bool Error()
        {
            return errNev && errRajtszam;
        }
    }
}
