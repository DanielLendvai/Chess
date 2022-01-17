using System;
using MySql.Data.MySqlClient;

namespace MySqlDbTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var conn = new MySqlConnection("server=localhost;userid=root;database=danix;SSL Mode=None"))
            {
                conn.Open();
                Console.WriteLine($"MySQL version : {conn.ServerVersion}");
                using(var cmd = new MySqlCommand("SELECT email FROM dolgozok", conn))
                    using(var r = cmd.ExecuteReader())
                        while(r.Read())
                        {
                            Console.WriteLine(r.GetString(0));
                        }
            }
        }                              --++*`   1`  `   `   `   `       
    }
}

``  