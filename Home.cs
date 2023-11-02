using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Appointr.Model;
using Appointr.mySQL;

namespace Appointr
{
    public partial class Home : Form
    {
        //Main
        public Home()
        {
            InitializeComponent();
            ShowCurrentUser();
            GetCustomers();
            GetAppointments();
            GetCalendar();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            ClearRowSelect();
        }
        private void tabCtrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearRowSelect();
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Leaving application.", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                Application.Exit();
            }

        }
        private void ShowCurrentUser()
        {
            lbHello.Text = "Hello, " + User.CurrentUsername + "!";

        }
        //Datagrid
        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetRowSelect();
        }
        private void dgvAppointment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetRowSelect();
        }
        private void GetCustomers()
        {
            Query.SelectCustomer(dgvCustomer);
            ClearRowSelect();
        }
        private void GetAppointments()
        {
            Query.SelectAppointment(dgvAppointment);
            TimeZoneUpdate(dgvAppointment);
            ClearRowSelect();
        }
        private void GetCalendar()
        {
            Query.SelectCurrentWeek(lstWeek);
            Query.SelectCurrentMonth(lstMonth);
            Query.SelectUserSchedule(lstSchedule);
            Query.SelectTypePerMonth(lstCount);
            Query.SelectActiveCustomers(lstActive);

        }
        private void GetRowSelect()
        {
            if (tabCtrl.SelectedTab == tabCustomers)
            {
                if (IsRowSelect())
                {
                    tbName.Text = dgvCustomer.CurrentRow.Cells[1].Value.ToString();
                    mtbPhone.Text = dgvCustomer.CurrentRow.Cells[3].Value.ToString();
                    tbAddress.Text = dgvCustomer.CurrentRow.Cells[4].Value.ToString();
                    tbAddress2.Text = dgvCustomer.CurrentRow.Cells[5].Value.ToString();
                    tbCity.Text = dgvCustomer.CurrentRow.Cells[7].Value.ToString();
                    tbCountry.Text = dgvCustomer.CurrentRow.Cells[9].Value.ToString();
                    mtbPostal.Text = dgvCustomer.CurrentRow.Cells[10].Value.ToString();
                }

            }
            else if (tabCtrl.SelectedTab == tabAppointments)
            {
                if (IsRowSelect())
                {
                    tbTitle.Text = dgvAppointment.CurrentRow.Cells[2].Value.ToString();
                    rtbDescription.Text = dgvAppointment.CurrentRow.Cells[3].Value.ToString();
                    tbLocation.Text = dgvAppointment.CurrentRow.Cells[4].Value.ToString();
                    tbContact.Text = dgvAppointment.CurrentRow.Cells[5].Value.ToString();
                    tbType.Text = dgvAppointment.CurrentRow.Cells[6].Value.ToString();
                    tbURL.Text = dgvAppointment.CurrentRow.Cells[7].Value.ToString();
                    DateTime startLocal = DateTime.Parse(dgvAppointment.CurrentRow.Cells[8].Value.ToString());
                    dtpStart.Text = startLocal.ToString();
                    DateTime endLocal = DateTime.Parse(dgvAppointment.CurrentRow.Cells[9].Value.ToString());
                    dtpEnd.Text = endLocal.ToString();
                }

            }

        }
        private void ClearRowSelect()
        {
            //removes row highlight
            if (tabCtrl.SelectedTab.Name == "tabCustomers")
            {
                dgvCustomer.ClearSelection();
                dgvAppointment.ClearSelection();
                lstWeek.ClearSelected();
                lstMonth.ClearSelected();

            }
            else if (tabCtrl.SelectedTab.Name == "tabAppointments")
            {
                dgvAppointment.ClearSelection();
                lstWeek.ClearSelected();
                lstMonth.ClearSelected();

            }
            else if (tabCtrl.SelectedTab.Name == "tabCalendar")
            {
                lstWeek.ClearSelected();
                lstMonth.ClearSelected();
                dgvCustomer.ClearSelection();
                dgvAppointment.ClearSelection();

            }
            else
            {
                //something else
            }

        }
        private bool IsRowSelect()
        {
            if ((dgvCustomer.CurrentRow != null) && (dgvCustomer.CurrentRow.Selected))
            {
                return true;
            }
            else if ((dgvAppointment.CurrentRow != null) && (dgvAppointment.CurrentRow.Selected))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Row not selected.", "Customer");
                return false;
            }

        }
        private bool IsWeekday(DayOfWeek dayofweek)
        {
            //cause: methods in method; effect: returns true if either are true; fix 0428_23: separate day and time methods
            //Mon - Fri
            return dayofweek >= DayOfWeek.Monday && dayofweek <= DayOfWeek.Friday;
        }
        private bool IsWithinHours(DateTime appt)
        {
            User user = new User();
            return appt.TimeOfDay >= user.BusinessOpen.TimeOfDay && appt.TimeOfDay <= user.BusinessClose.TimeOfDay;

        }
        public bool IsOpen(DateTime start, DateTime end)
        {
            if (IsWeekday(start.DayOfWeek) && IsWeekday(end.DayOfWeek))
            {
                if (IsWithinHours(start) && IsWithinHours(end))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Outside business hours:\n7am - 7pm.", "Appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Outside business week:\nMonday - Friday.", "Appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        //GroupBox
        Func<GroupBox, bool> NullEmpty = gb =>
        {
            //=> reduces code length and increase readability. no delegate needed

            //zip, phone, country, postal, city, add2, add
            foreach (var ctrl in gb.Controls)
            {
                switch (ctrl)
                {
                    case Label lbl:
                        continue;
                    case TextBox tb:
                        if (!(string.IsNullOrEmpty(tb.Text) || string.IsNullOrWhiteSpace(tb.Text)))
                        {
                            tb.BackColor = SystemColors.Window;
                        }
                        else
                        {
                            tb.BackColor = Color.MistyRose;
                            MessageBox.Show("Empty value.", "Fix", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return true;
                        }
                        break;
                    case MaskedTextBox mtb:
                        if (!string.IsNullOrWhiteSpace(mtb.Text))
                        {
                            mtb.BackColor = SystemColors.Window;
                        }
                        else
                        {
                            mtb.BackColor = Color.MistyRose;
                            MessageBox.Show("White space.", "Fill", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return true;
                        }
                        break;
                    default:
                        break;
                }
            }
            return false;
        };
        //Add
        private void btAdd_Click(object sender, EventArgs e)
        {
            TabAdd();
            GetCalendar();
        }
        private void TabAdd()
        {
            switch (tabCtrl.SelectedTab.Name)
            {
                case "tabCustomers":
                    if (IsRowSelect())
                    {
                        tabCtrl.SelectedTab = tabAppointments;
                        MessageBox.Show("Appointment information.", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //addcustomer?
                        CustomerAdd();
                    }
                    break;
                case "tabAppointments":
                    if (IsRowSelect()) //maintains customer rowselect
                    {
                        AppointmentAdd();
                        //newpage();

                    }
                    else
                    {
                        tabCtrl.SelectedTab = tabCustomers;
                        MessageBox.Show("Customer for Appointment.", "Select", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "tabCalendar":
                    GetCalendar();
                    break;
                default:
                    MessageBox.Show("No tab selected.", "Tab");
                    break;
            }
        }
        private void CustomerAdd()
        {
            if (MessageBox.Show("New Customer?", "Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (!NullEmpty(gbCustomer))
                {
                    Query.InsertCustomer(tbCountry.Text, tbCity.Text, tbAddress.Text, tbAddress2.Text, mtbPostal.Text, mtbPhone.Text, tbName.Text);
                    GetCustomers();
                }
            }
        }
        private void AppointmentAdd()
        {
            if (MessageBox.Show("New Appointment?", "Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int thisRow = dgvCustomer.CurrentRow.Index;
                int customerId = (int)dgvCustomer.Rows[thisRow].Cells[0].Value;
                Appointment ap = new Appointment();

                if (!NullEmpty(gbAppointment) && IsOpen(dtpStart.Value, dtpEnd.Value))
                {
                    if (!Query.AppoinmentOverlap(customerId, ap.AppointmentId, DateTime.Parse(dtpStart.Value.ToString()).ToUniversalTime(), DateTime.Parse(dtpEnd.Value.ToString()).ToUniversalTime()))
                    {
                        Customer customer = new Customer
                        {
                            CustomerId = customerId
                        };

                        User user = new User
                        {
                            UserId = User.CurrentUserId
                        };
                        //cause: dtpStart/End.Text(); effect: pulls DateTime.Now from empty Appointment constructor; fix 0428_23: dtpStart/End.Value.ToString()
                        Query.InsertAppointment(customer.CustomerId, user.UserId, tbTitle.Text, rtbDescription.Text, tbLocation.Text, tbContact.Text, tbType.Text, tbURL.Text, DateTime.Parse(dtpStart.Value.ToString()).ToUniversalTime(), DateTime.Parse(dtpEnd.Value.ToString()).ToUniversalTime());
                        GetAppointments();

                    }
                }
            }
        }
        //Update
        private void btUpd_Click(object sender, EventArgs e)
        {
            TabUpdate();
            GetCalendar();
        }
        private void TabUpdate()
        {
            switch (tabCtrl.SelectedTab.Name)
            {
                case "tabCustomers":
                    if (IsRowSelect())
                    {
                        CustomerUpdate();
                    }
                    else
                    {
                        MessageBox.Show("Select Customer.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;
                case "tabAppointments":
                    if (IsRowSelect())
                    {
                        AppointmentUpdate();
                    }
                    else
                    {
                        MessageBox.Show("Select Appointment.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;
                case "tabCalendar":
                    GetCalendar();
                    break;
                default:
                    MessageBox.Show("No tab selected.", "Tab");
                    break;
            }
        }
        private void CustomerUpdate()
        {
            if (MessageBox.Show("Customer information?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!NullEmpty(gbCustomer))
                {
                    int thisRow = dgvCustomer.CurrentRow.Index;
                    int countryId = (int)dgvCustomer.Rows[thisRow].Cells["countryId"].Value;
                    int cityId = (int)dgvCustomer.Rows[thisRow].Cells["cityId"].Value;
                    int addressId = (int)dgvCustomer.Rows[thisRow].Cells["addressId"].Value;
                    int customerId = (int)dgvCustomer.Rows[thisRow].Cells["customerId"].Value;

                    Query.UpdateCountry(countryId, tbCountry.Text);
                    Query.UpdateCity(cityId, tbCity.Text);
                    Query.UpdateAddress(addressId, tbAddress.Text, tbAddress2.Text, mtbPostal.Text, mtbPhone.Text);
                    Query.UpdateCustomer(customerId, tbName.Text);
                    GetCustomers();

                }
            }
        }
        private void AppointmentUpdate()
        {
            if (MessageBox.Show("Appointment information?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int thisRow = dgvAppointment.CurrentRow.Index;
                int appointmentId = (int)dgvAppointment.Rows[thisRow].Cells["appointmentId"].Value;
                int customerId = (int)dgvAppointment.Rows[thisRow].Cells["customerId"].Value;
                if (!NullEmpty(gbAppointment) && IsOpen(dtpStart.Value, dtpEnd.Value))
                {
                    if (!Query.AppoinmentOverlap(customerId, appointmentId, DateTime.Parse(dtpStart.Value.ToString()).ToUniversalTime(), DateTime.Parse(dtpEnd.Value.ToString()).ToUniversalTime()))
                    {
                        //cause: dtpStart/End.Text(); effect: pulls DateTime.Now from empty Appointment constructor; fix 0428_23: dtpStart/End.Value.ToString()
                        Query.UpdateAppointment(appointmentId, tbTitle.Text, rtbDescription.Text, tbLocation.Text, tbContact.Text, tbType.Text, tbURL.Text, DateTime.Parse(dtpStart.Value.ToString()).ToUniversalTime(), DateTime.Parse(dtpEnd.Value.ToString()).ToUniversalTime());
                        GetAppointments();
                    }
                }
            }
        }
        private void TimeZoneUpdate(DataGridView dgv)
        {
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Name == "start" || column.Name == "end")
                {
                    for (int i = 0; i < dgv.Rows.Count; i++) // Exclude the new row if present
                    {
                        DateTime time = Convert.ToDateTime(dgv.Rows[i].Cells[column.Name].Value);
                        DateTime timeLocal = TimeZoneInfo.ConvertTimeFromUtc(time, TimeZoneInfo.Local);
                        dgv.Rows[i].Cells[column.Name].Value = timeLocal;
                    }
                }
            }
        }
        //Delete
        private void btDel_Click(object sender, EventArgs e)
        {
            TabDelete();
            GetCalendar();
        }
        private void TabDelete()
        {
            switch (tabCtrl.SelectedTab.Name)
            {
                case "tabCustomers":
                    if (IsRowSelect())
                    {
                        CustomerDelete();
                    }
                    else
                    {
                        MessageBox.Show("Select Customer.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;
                case "tabAppointments":
                    if (IsRowSelect())
                    {
                        AppointmentDelete();
                    }
                    else
                    {
                        MessageBox.Show("Select Appointment.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;
                case "tabCalendar":
                    GetCalendar();
                    break;
                default:
                    MessageBox.Show("No tab selected.", "Tab");
                    break;
            }
        }
        private void CustomerDelete()
        {
            if (MessageBox.Show("Customer & Appointment information?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int thisRow = dgvCustomer.CurrentRow.Index;
                int customerId = (int)dgvCustomer.Rows[thisRow].Cells[0].Value;
                Query.DeleteCustomerAppointment(customerId);
                Query.DeleteCustomer(customerId);
                GetCustomers();
                GetAppointments();
            }
            else
            {
                MessageBox.Show("Not deleted.", "No");
            }
        }
        private void AppointmentDelete()
        {
            if (MessageBox.Show("Appointment information?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int thisRow = dgvAppointment.CurrentRow.Index;
                int appointmentId = (int)dgvAppointment.Rows[thisRow].Cells[0].Value;
                Query.DeleteAppointment(appointmentId);
                GetAppointments();
            }
            else
            {
                MessageBox.Show("Not deleted.", "No");
            }
        }

        //Tests
        private void btTest_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Leaving application.", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
