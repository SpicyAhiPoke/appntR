using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;


namespace Appointr.mySQL
{
    public class Database
    {
        public static MySqlConnection conn { get; set; }

        public static void OpenConnection()
        {
            try
            {
                string connString = "datasource=localhost;Port=3306;Database=client_schedule;Username=sqlUser;Password=Passw0rd!";

                conn = new MySqlConnection(connString);

                conn.Open();
                MessageBox.Show("Connection open!", "Database");
            }
            catch (MySqlException exception)
            {
                MessageBox.Show("An error occurred: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public static void CloseConnection()
        {
            try
            {
                if (conn != null)
                {
                    conn.Close();

                    MessageBox.Show("Connection closed.", "Database");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occurred: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
