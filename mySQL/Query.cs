using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appointr.Model;
using MySql.Data.MySqlClient;
using Appointr.mySQL;
using System.Windows.Forms;
using System.Data;
using System.ComponentModel;

namespace Appointr.mySQL
{
    internal class Query
    {
        public static Action MinuteAlert = () =>
        {
            string fifteen =
                @"SELECT start FROM appointment WHERE start BETWEEN NOW() AND DATE_ADD(NOW(), INTERVAL 15 MINUTE)";
            try
            {
                //define sql statement
                using (MySqlCommand cmd = new MySqlCommand(fifteen, Database.conn))
                {
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            MessageBox.Show("Appointment(s) within 15 minutes!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        rdr.Close();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        };
        public static bool AppoinmentOverlap(int cId, int aId, DateTime start, DateTime end)
        {
            try
            {
                string overlap =
                    @"SELECT ca.customerId, ca.appointmentId, ca.start, ca.end " +
                    "FROM appointment ca " +
                    "WHERE ca.appointmentId <> @appointmentId " +
                    "AND ca.customerId = @customerId " +
                    "AND (ca.start BETWEEN @start AND @end) " +
                    "AND (ca.end BETWEEN @start AND @end) ";
                using (MySqlCommand cmd = new MySqlCommand(overlap, Database.conn))
                {
                    cmd.Parameters.AddWithValue("@customerId", cId);
                    cmd.Parameters.AddWithValue("@appointmentId", aId);
                    cmd.Parameters.AddWithValue("@start", start);
                    cmd.Parameters.AddWithValue("@end", end);
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            MessageBox.Show("Overlaps another.", "Appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            rdr.Close();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        //Filter
        public static void SelectCurrentUser()
        {
            string currentuser = "SELECT * FROM user WHERE userName = @userName AND password = @password";
            try
            {
                using (MySqlCommand cmdUser = new MySqlCommand(currentuser, Database.conn))
                {
                    Login login = new Login();
                    cmdUser.Parameters.AddWithValue("@userName", login.tbUsername.Text);
                    cmdUser.Parameters.AddWithValue("@password", login.tbPassword.Text);
                    using (MySqlDataReader rdr = cmdUser.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            User.CurrentUserId = rdr.GetInt32("userId");
                            User.CurrentUsername = rdr.GetString("userName");
                        }
                        rdr.Close();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public static void SelectUserSchedule(ListBox lb)
        {
            string schedule = "SELECT title, location, type, start, end FROM appointment WHERE userId = '1'";
            try
            {
                //define sql statement
                using (MySqlCommand cmd = new MySqlCommand(schedule, Database.conn))
                {
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        lb.Items.Clear();
                        while (rdr.Read())
                        {
                            string Title = rdr.GetString("title");
                            string Location = rdr.GetString("location");
                            string Type = rdr.GetString("type");
                            DateTime Start = rdr.GetDateTime("start").ToLocalTime();
                            DateTime End = rdr.GetDateTime("end").ToLocalTime();

                            lb.Items.Add("User: " + User.CurrentUsername + ' ' + Title + " @ " + Location + " - " + Type + " [Start: " + Start + " End: " + End + ']');
                        }
                        rdr.Close();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static void SelectActiveCustomers(ListBox lb)
        {
            string counttypemonth = "SELECT active, count(*) AS count FROM customer GROUP BY active";
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(counttypemonth, Database.conn))
                {
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        lb.Items.Clear();
                        while (rdr.Read())
                        {
                            int active  = rdr.GetInt32("active");
                            int count = rdr.GetInt32("count");
                            lb.Items.Add("Active: " + count + " customer(s)");
                        }
                        rdr.Close();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void SelectTypePerMonth(ListBox lb)
        {
            string counttypemonth =
                @"SELECT MONTH(start) AS month, type, COUNT(*) AS count FROM appointment GROUP BY month, type";
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(counttypemonth, Database.conn))
                {
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        lb.Items.Clear();
                        while (rdr.Read())
                        {
                            string type = rdr.GetString("type");
                            int count = rdr.GetInt32("count");
                            int start = rdr.GetInt32("month");
                            DateTime mm = new DateTime(1, start, 1);
                            string month = mm.ToString("MMMM");
                            lb.Items.Add(count + " " + type + " (s) in " + month);
                        }
                        rdr.Close();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void SelectCurrentWeek(ListBox lb)
        {
            string currentweek =
                @"SELECT title, description, location, contact, type, url, start, end " + 
                 "FROM appointment WHERE WEEK(start, 0) = WEEK(NOW()) AND WEEK(end, 0) = WEEK(NOW())";
            try
            {
                //define sql statement
                using (MySqlCommand cmd = new MySqlCommand(currentweek, Database.conn))
                {
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        lb.Items.Clear();
                        while (rdr.Read())
                        {
                            string Title = rdr.GetString("title");
                            string Description = rdr.GetString("description");
                            string Location = rdr.GetString("location");
                            string Contact = rdr.GetString("contact");
                            string Type = rdr.GetString("type");
                            string URL = rdr.GetString("url");
                            DateTime Start = rdr.GetDateTime("start").ToLocalTime();
                            DateTime End = rdr.GetDateTime("end").ToLocalTime();

                            lb.Items.Add(Title + " @ " + Location + " - " + Type + " [Start: " + Start + " End: " + End + ']');
                        }
                        rdr.Close();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void SelectCurrentMonth(ListBox lb)
        {
            string currentmonth =
                @"SELECT title, description, location, contact, type, url, start, end " +
                 "FROM appointment WHERE MONTH(start) = MONTH(NOW()) AND MONTH(end) = MONTH(NOW())";
            try
            {
                //define sql statement
                using (MySqlCommand cmd = new MySqlCommand(currentmonth, Database.conn))
                {
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        lb.Items.Clear();
                        while (rdr.Read())
                        {
                            string Title = rdr.GetString("title");
                            string Description = rdr.GetString("description");
                            string Location = rdr.GetString("location");
                            string Contact = rdr.GetString("contact");
                            string Type = rdr.GetString("type");
                            string URL = rdr.GetString("url");
                            DateTime Start = rdr.GetDateTime("start").ToLocalTime();
                            DateTime End = rdr.GetDateTime("end").ToLocalTime();

                            lb.Items.Add(Title + " @ " + Location + " - " + Type + " [Start: " + Start + " End: " + End + ']');
                        }
                        rdr.Close();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static void SelectCustomer(DataGridView dgv)
        {            
            string fillcustomers = 
                @"SELECT cr.customerId, cr.customerName, ad.addressId, ad.phone, ad.address, ad.address2, ct.cityId, ct.city, cy.countryId, cy.country, ad.postalCode " +
                 "FROM customer cr " +
                 "JOIN address ad ON cr.addressId = ad.addressId " +
                 "JOIN city ct ON ad.cityId = ct.cityId " +
                 "JOIN country cy ON ct.countryId = cy.countryId ";
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(fillcustomers, Database.conn))
                {
                    // Create a new DataTable object to hold the data from the query
                    DataTable datatable = new DataTable();
                    // Use a MySqlDataAdapter object to fill the DataTable object with the data from the query
                    using (MySqlDataAdapter adpt = new MySqlDataAdapter(cmd))
                    {
                        datatable.Clear();
                        adpt.Fill(datatable);
                        BindingSource bsCustomer = new BindingSource
                        {
                            DataSource = datatable
                        };
                        dgv.DataSource = bsCustomer;
                    }
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static void SelectAppointment(DataGridView dgv)
        {
            string fillappointments =
                @"SELECT appointmentId, customerId, title, description, location, contact, type, url, start, end " +
                 "FROM appointment";
            try
            {
                //define sql statement
                using (MySqlCommand cmd = new MySqlCommand(fillappointments, Database.conn))
                {
                    DataTable datatable = new DataTable();
                    // Use a MySqlDataAdapter object to fill the DataTable object with the data from the query
                    using (MySqlDataAdapter adpt = new MySqlDataAdapter(cmd))
                    {
                        datatable.Clear();
                        adpt.Fill(datatable);
                        BindingSource bsAppointment = new BindingSource
                        {
                            DataSource = datatable
                        };
                        dgv.DataSource = bsAppointment;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Insert
        public static void InsertCustomer(string country, string city, string address, string address2, string postalCode, string phone, string customerName)
        {
            try
            {
                //Country insert
                //sql string
                string newcountry = "INSERT INTO country VALUES (NULL, @country, NOW(), 'user', NOW(), 'user')";
                //cmd
                MySqlCommand cmdCountry = new MySqlCommand(newcountry, Database.conn);
                //set param
                cmdCountry.Parameters.AddWithValue("@country", country);
                //execute query
                cmdCountry.ExecuteNonQuery();
                //autogen id
                int countryId = (int)cmdCountry.LastInsertedId;

                //City insert
                string newcity = "INSERT INTO city VALUES (NULL, @city, @countryId, NOW(), 'user', NOW(), 'user' )";
                MySqlCommand cmdCity = new MySqlCommand(newcity, Database.conn);
                cmdCity.Parameters.AddWithValue("@city", city);
                cmdCity.Parameters.AddWithValue("@countryId", countryId);
                cmdCity.ExecuteNonQuery();
                int cityId = (int)cmdCity.LastInsertedId;

                //Address insert
                string newaddress = @"INSERT INTO address 
                VALUES (NULL, @address, @address2, @cityId, @postalCode, @phone, NOW(), 'user', NOW(), 'user')";
                MySqlCommand cmdAddress = new MySqlCommand(newaddress, Database.conn);
                cmdAddress.Parameters.AddWithValue("@address", address);
                cmdAddress.Parameters.AddWithValue("@address2", address2);
                cmdAddress.Parameters.AddWithValue("@cityId", cityId);
                cmdAddress.Parameters.AddWithValue("@postalCode", postalCode);
                cmdAddress.Parameters.AddWithValue("@phone", phone);
                cmdAddress.ExecuteNonQuery();
                int addressId = (int)cmdAddress.LastInsertedId;

                //Customer insert
                string newcustomer = "INSERT INTO customer VALUES (NULL, @customerName, @addressId, TRUE, NOW(), 'user', NOW(), 'user')";
                MySqlCommand cmdCustomer = new MySqlCommand(newcustomer, Database.conn);
                cmdCustomer.Parameters.AddWithValue("@customerName", customerName);
                cmdCustomer.Parameters.AddWithValue("@addressId", addressId);
                cmdCustomer.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void InsertAppointment
            (int customerId, int userId, string title, string description, string location, string contact, string type, string url, DateTime start, DateTime end)
        {
            string newappoitnment = 
                @"INSERT INTO appointment 
                  VALUES (NULL, @customerId, @userId, @title, @description, @location, @contact, @type, @url, @start, @end, NOW(), 'user', NOW(), 'user')";
            try
            {
                MySqlCommand cmd = new MySqlCommand(newappoitnment, Database.conn);
                cmd.Parameters.AddWithValue("@customerId", customerId);
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@location", location);
                cmd.Parameters.AddWithValue("@contact", contact);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@url", url);
                cmd.Parameters.AddWithValue("@start", start);
                cmd.Parameters.AddWithValue("@end", end);
                cmd.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        //Update
        public static void UpdateCustomer(int customerId, string customerName)
        {
            //cause: = customerId missing '@' applying Id to all rows; effect: updates other customerName rows; fix 0425_23: = @customerId
            string upcustomer = "UPDATE customer SET customerName = @customerName WHERE customerId = @customerId "; 
            using (MySqlCommand cmd = new MySqlCommand(upcustomer, Database.conn))
            {
                cmd.Parameters.AddWithValue("@customerId", customerId);
                cmd.Parameters.AddWithValue("@customerName", customerName);
                cmd.ExecuteNonQuery();
            }
        }
        public static void UpdateAppointment(int appointmentId, string title, string description, string location, string contact, string type, string url, DateTime start, DateTime end)
        {
            string upappointment =
                @"UPDATE appointment SET title = @title, description = @description, location = @location, contact = @contact, type = @type, url = @url, start = @start, end = @end WHERE appointmentId = @appointmentId";
            using (MySqlCommand cmd = new MySqlCommand(upappointment, Database.conn))
            {
                cmd.Parameters.AddWithValue("@appointmentId", appointmentId);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@location", location);
                cmd.Parameters.AddWithValue("@contact", contact);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@url", url);
                cmd.Parameters.AddWithValue("@start", start);
                cmd.Parameters.AddWithValue("@end", end);
                cmd.ExecuteNonQuery();
            }
        }
        public static void UpdateAddress(int addressId, string address, string address2, string postalCode, string phone)
        {
            string upaddress = "UPDATE address SET address = @address, address2 = @address2, postalcode = @postalcode, phone = @phone WHERE addressId = @addressId";
            using (MySqlCommand cmd = new MySqlCommand(upaddress, Database.conn))
            {
                cmd.Parameters.AddWithValue("@addressId", addressId);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@address2", address2);
                cmd.Parameters.AddWithValue("@postalcode", postalCode);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.ExecuteNonQuery();
            }
        }
        public static void UpdateCity(int cityId, string city)
        {
            string upcity = "UPDATE city SET city = @city WHERE cityId = @cityId";
            using (MySqlCommand cmd = new MySqlCommand(upcity, Database.conn))
            {
                cmd.Parameters.AddWithValue("@cityId", cityId);
                cmd.Parameters.AddWithValue("@city", city);
                cmd.ExecuteNonQuery();
            }
        }
        public static void UpdateCountry(int countryId, string country)
        {
            string upcountry = "UPDATE country SET country = @country WHERE countryId = @countryId";
            using (MySqlCommand cmd = new MySqlCommand(upcountry, Database.conn))
            {
                cmd.Parameters.AddWithValue("@countryId", countryId);
                cmd.Parameters.AddWithValue("@country", country);
                cmd.ExecuteNonQuery();
            }
        }
        //Delete
        public static void DeleteCustomer(int customerId)
        {
            string rmvcustomer = "DELETE FROM customer WHERE customerId = @customerId";
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(rmvcustomer, Database.conn))
                {
                    cmd.Parameters.AddWithValue("@customerID", customerId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void DeleteCustomerAppointment(int customerId)
        {
            string rmvcustomerappointment = "DELETE FROM appointment WHERE customerId = @customerId";
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(rmvcustomerappointment, Database.conn))
                {
                    cmd.Parameters.AddWithValue("@customerID", customerId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void DeleteAppointment(int appointmentId)
        {
            string rmvappointment = "DELETE FROM appointment WHERE appointmentId = @appointmentId";
            try
            {
                MySqlCommand cmd = new MySqlCommand(rmvappointment, Database.conn);
                cmd.Parameters.AddWithValue("@appointmentId", appointmentId);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

    }
}
