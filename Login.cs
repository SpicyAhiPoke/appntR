using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization; //culture
using Appointr.Model;
using Appointr.mySQL;
using System.IO;
using System.Resources;
using System.Threading;

namespace Appointr
{
    partial class Login : Form
    {
        private ResourceManager resourceManager;
        public Login()
        {
            InitializeComponent();
            //resource manager based on selected language
            resourceManager = new ResourceManager("Appointr.Resources", typeof(Login).Assembly);
            WhereInWorldIsWaldo(CultureInfo.CurrentCulture.TwoLetterISOLanguageName);
            Welcome();
            Sign();
        }
        private static string WhereInWorldIsWaldo(string language)
        {
            //Get user's current culture based on system settings
            CultureInfo currentCulture = CultureInfo.CurrentCulture;
            //Get culture iso code
            string languageCode = currentCulture.TwoLetterISOLanguageName;
            //Determine language based on country code
            switch (languageCode)
            {
                case "en":
                    language = "en"; //English
                    break;
                case "ko":
                    language = "ko"; //Korean
                    break;
                default:
                    language = "en"; //Default English
                    break;
            }
            // Set current culture to selected language
            Thread.CurrentThread.CurrentCulture = new CultureInfo(language);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
            return language;
        }
        private void Welcome()
        {
            switch (WhereInWorldIsWaldo(CultureInfo.CurrentCulture.TwoLetterISOLanguageName))
            {
                case "ko":
                    string welcomeKR = resourceManager.GetString("GroupBox");
                    gbSign.Text = welcomeKR;
                    break;
                default:
                    string welcomeUS = resourceManager.GetString("GroupBox");
                    gbSign.Text = welcomeUS;
                    break;
            }
        }
        private void Sign()
        {
            switch (WhereInWorldIsWaldo(CultureInfo.CurrentCulture.TwoLetterISOLanguageName))
            {
                case "ko":
                    string signKR = resourceManager.GetString("Button");
                    btSign.Text = signKR;
                    break;
                default:
                    string signUS = resourceManager.GetString("Button");
                    btSign.Text = signUS;
                    break;
            }
        }
        private bool IsNotNull()
        {
            //checks for !null/!white/"test"
            return
                (!(string.IsNullOrWhiteSpace(tbUsername.Text) || Int32.TryParse(tbPassword.Text, out int i)) &&
                (!(string.IsNullOrWhiteSpace(tbPassword.Text)) && tbUsername.Text == "test" && tbPassword.Text == "test"));
        }
        private bool IsValid()
        {
            if (IsNotNull())
            {
                VisualLogin();
                btSign.Enabled = true;
                return true;
            }
            else
            {
                VisualLogin();
                btSign.Enabled = false;
                return false;
            }
        }
        private void VisualLogin()
        {            
            if (IsNotNull())
            {
                lbError.Text = " ";
                tbPassword.BackColor = SystemColors.Window;
                tbUsername.BackColor = SystemColors.Window;
            }
            else
            {
                ErrorLogin();
                tbUsername.BackColor = Color.MistyRose;
                tbPassword.BackColor = Color.MistyRose;
            }
        }
        private void ErrorLogin()
        {
            switch (WhereInWorldIsWaldo(CultureInfo.CurrentCulture.TwoLetterISOLanguageName))
            {
                case "ko":
                    string errorKR = resourceManager.GetString("Label");
                    lbError.Text = errorKR;
                    break;
                default:
                    string errorUS = resourceManager.GetString("Label");
                    lbError.Text = errorUS;
                    break;
            }
        }
        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            IsValid();
        }
        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            IsValid();

        }
        private void btSign_Click(object sender, EventArgs e)
        {
            //check username
            if (IsValid())
            {
                //1st & only openconn
                Database.OpenConnection();
                Query.SelectCurrentUser();
                Query.MinuteAlert();
                LogActivity();

                //Hide login; Show main
                Hide();
                Home home = new Home();
                home.Show();

            }
        }
        private Action LogActivity = () =>
        {
            //=> clearly distinguishes as action, filtering method increases readability & is anonymous
            //file path
            string fPath = @"C:\AppointrLogs\log_activity.txt";
            //create dir:path
            Directory.CreateDirectory(Path.GetDirectoryName(fPath));
            //if txtfile exists in path
            if (File.Exists(fPath))
            {
                //append existing txtfile
                using (StreamWriter wrtr = File.AppendText(fPath))
                {
                    //activity
                    wrtr.WriteLine("UserId: " + User.CurrentUserId + " Username: " + User.CurrentUsername + $" logged @ {DateTime.Now}");
                }
            }
            else
            {
                //create new txtfile
                using (StreamWriter wrtr = File.CreateText(fPath))
                {
                    wrtr.WriteLine("UserId: " + User.CurrentUserId + " Username: " + User.CurrentUsername + $" logged @ {DateTime.Now}");
                }
            }
        };

    }
}
