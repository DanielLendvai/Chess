using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Forma1
{
    public partial class NemUjonc : UserControl
    {
        MySqlConnection Conn;
        public NemUjonc()
        {
            InitializeComponent();
            Conn = Connect.InitDB();
        }

        public void FillDGV()
        {
            using(var conn = Connect.InitDB())
            {
                conn.Open();
                string query = "CALL Pr_NemUjoncVersenyzok;";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(
                                new object[]
                                {
                            Convert.ToInt32(reader["vrajt"]),
                            reader["vNev"].ToString(),
                            reader["vNemz"].ToString(),
                            reader["csNev"].ToString()
                                }
                            );
                        }
            }            
        }
    }
}
