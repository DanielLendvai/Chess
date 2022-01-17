using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Forma1
{
    static class Connect
    {        
        public static MySqlConnection InitDB()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server      = "localhost";
            builder.UserID      = "root";
            builder.Password    = "";
            builder.Database    = "forma1";
            builder.SslMode = MySqlSslMode.None;

            string constr = builder.ToString();
            
            try
            {
                return new MySqlConnection(constr);                
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Hiba az adatbázishoz csatlakozás közben. " + ex.Message);
            }
            return default(MySqlConnection);
        }
    }
}
