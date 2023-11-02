
namespace Appointr
{
    partial class Home
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.mtbPostal = new System.Windows.Forms.MaskedTextBox();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.lbPostal = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.tbAddress2 = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.tabAppointments = new System.Windows.Forms.TabPage();
            this.gbAppointment = new System.Windows.Forms.GroupBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lbType = new System.Windows.Forms.Label();
            this.tbType = new System.Windows.Forms.TextBox();
            this.lbStart = new System.Windows.Forms.Label();
            this.lbEnd = new System.Windows.Forms.Label();
            this.lbURL = new System.Windows.Forms.Label();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.lbContact = new System.Windows.Forms.Label();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.lbLocation = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.dgvAppointment = new System.Windows.Forms.DataGridView();
            this.tabCalendar = new System.Windows.Forms.TabPage();
            this.lstActive = new System.Windows.Forms.ListBox();
            this.lstSchedule = new System.Windows.Forms.ListBox();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.lblActive = new System.Windows.Forms.Label();
            this.lblTypeCount = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblWeek = new System.Windows.Forms.Label();
            this.lstCount = new System.Windows.Forms.ListBox();
            this.lstMonth = new System.Windows.Forms.ListBox();
            this.lstWeek = new System.Windows.Forms.ListBox();
            this.btExit = new System.Windows.Forms.Button();
            this.lbHello = new System.Windows.Forms.Label();
            this.btUpd = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.tabCtrl.SuspendLayout();
            this.tabCustomers.SuspendLayout();
            this.gbCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.tabAppointments.SuspendLayout();
            this.gbAppointment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).BeginInit();
            this.tabCalendar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrl
            // 
            this.tabCtrl.Controls.Add(this.tabCustomers);
            this.tabCtrl.Controls.Add(this.tabAppointments);
            this.tabCtrl.Controls.Add(this.tabCalendar);
            this.tabCtrl.Location = new System.Drawing.Point(15, 71);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(884, 450);
            this.tabCtrl.TabIndex = 0;
            this.tabCtrl.SelectedIndexChanged += new System.EventHandler(this.tabCtrl_SelectedIndexChanged);
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.gbCustomer);
            this.tabCustomers.Controls.Add(this.dgvCustomer);
            this.tabCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomers.Size = new System.Drawing.Size(876, 424);
            this.tabCustomers.TabIndex = 1;
            this.tabCustomers.Text = "Customers";
            this.tabCustomers.UseVisualStyleBackColor = true;
            // 
            // gbCustomer
            // 
            this.gbCustomer.Controls.Add(this.mtbPostal);
            this.gbCustomer.Controls.Add(this.mtbPhone);
            this.gbCustomer.Controls.Add(this.lblCountry);
            this.gbCustomer.Controls.Add(this.tbCountry);
            this.gbCustomer.Controls.Add(this.lbPostal);
            this.gbCustomer.Controls.Add(this.lblCity);
            this.gbCustomer.Controls.Add(this.tbCity);
            this.gbCustomer.Controls.Add(this.lblAddress2);
            this.gbCustomer.Controls.Add(this.tbAddress2);
            this.gbCustomer.Controls.Add(this.lbAddress);
            this.gbCustomer.Controls.Add(this.lbPhone);
            this.gbCustomer.Controls.Add(this.lbName);
            this.gbCustomer.Controls.Add(this.tbAddress);
            this.gbCustomer.Controls.Add(this.tbName);
            this.gbCustomer.Location = new System.Drawing.Point(616, 6);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(254, 405);
            this.gbCustomer.TabIndex = 7;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Customer";
            // 
            // mtbPostal
            // 
            this.mtbPostal.Location = new System.Drawing.Point(6, 266);
            this.mtbPostal.Mask = "00000";
            this.mtbPostal.Name = "mtbPostal";
            this.mtbPostal.Size = new System.Drawing.Size(242, 20);
            this.mtbPostal.TabIndex = 17;
            this.mtbPostal.Text = "12345";
            // 
            // mtbPhone
            // 
            this.mtbPhone.Location = new System.Drawing.Point(6, 71);
            this.mtbPhone.Mask = "000-0000";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(242, 20);
            this.mtbPhone.TabIndex = 12;
            this.mtbPhone.Text = "1234567";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(6, 211);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 15;
            this.lblCountry.Text = "Country";
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(6, 227);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(242, 20);
            this.tbCountry.TabIndex = 16;
            this.tbCountry.Text = "US";
            // 
            // lbPostal
            // 
            this.lbPostal.AutoSize = true;
            this.lbPostal.Location = new System.Drawing.Point(6, 250);
            this.lbPostal.Name = "lbPostal";
            this.lbPostal.Size = new System.Drawing.Size(64, 13);
            this.lbPostal.TabIndex = 13;
            this.lbPostal.Text = "Postal Code";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(6, 172);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 11;
            this.lblCity.Text = "City";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(6, 188);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(242, 20);
            this.tbCity.TabIndex = 15;
            this.tbCity.Text = "New York City";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(6, 133);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(54, 13);
            this.lblAddress2.TabIndex = 9;
            this.lblAddress2.Text = "Address 2";
            // 
            // tbAddress2
            // 
            this.tbAddress2.Location = new System.Drawing.Point(6, 149);
            this.tbAddress2.Name = "tbAddress2";
            this.tbAddress2.Size = new System.Drawing.Size(242, 20);
            this.tbAddress2.TabIndex = 14;
            this.tbAddress2.Text = "Apt ABC";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(6, 94);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(45, 13);
            this.lbAddress.TabIndex = 6;
            this.lbAddress.Text = "Address";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(6, 55);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(38, 13);
            this.lbPhone.TabIndex = 5;
            this.lbPhone.Text = "Phone";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(6, 16);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "Name";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(6, 110);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(242, 20);
            this.tbAddress.TabIndex = 13;
            this.tbAddress.Text = "123 Sesame Street";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(6, 32);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(242, 20);
            this.tbName.TabIndex = 11;
            this.tbName.Text = "First Last";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.AllowUserToResizeColumns = false;
            this.dgvCustomer.AllowUserToResizeRows = false;
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(0, 0);
            this.dgvCustomer.MultiSelect = false;
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersVisible = false;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(610, 417);
            this.dgvCustomer.TabIndex = 2;
            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellClick);
            // 
            // tabAppointments
            // 
            this.tabAppointments.Controls.Add(this.gbAppointment);
            this.tabAppointments.Controls.Add(this.dgvAppointment);
            this.tabAppointments.Location = new System.Drawing.Point(4, 22);
            this.tabAppointments.Name = "tabAppointments";
            this.tabAppointments.Padding = new System.Windows.Forms.Padding(3);
            this.tabAppointments.Size = new System.Drawing.Size(876, 424);
            this.tabAppointments.TabIndex = 0;
            this.tabAppointments.Text = "Appointments";
            this.tabAppointments.UseVisualStyleBackColor = true;
            // 
            // gbAppointment
            // 
            this.gbAppointment.Controls.Add(this.dtpEnd);
            this.gbAppointment.Controls.Add(this.dtpStart);
            this.gbAppointment.Controls.Add(this.rtbDescription);
            this.gbAppointment.Controls.Add(this.lbType);
            this.gbAppointment.Controls.Add(this.tbType);
            this.gbAppointment.Controls.Add(this.lbStart);
            this.gbAppointment.Controls.Add(this.lbEnd);
            this.gbAppointment.Controls.Add(this.lbURL);
            this.gbAppointment.Controls.Add(this.tbURL);
            this.gbAppointment.Controls.Add(this.lbContact);
            this.gbAppointment.Controls.Add(this.tbContact);
            this.gbAppointment.Controls.Add(this.lbLocation);
            this.gbAppointment.Controls.Add(this.lbDescription);
            this.gbAppointment.Controls.Add(this.lbTitle);
            this.gbAppointment.Controls.Add(this.tbLocation);
            this.gbAppointment.Controls.Add(this.tbTitle);
            this.gbAppointment.Location = new System.Drawing.Point(616, 6);
            this.gbAppointment.Name = "gbAppointment";
            this.gbAppointment.Size = new System.Drawing.Size(254, 405);
            this.gbAppointment.TabIndex = 1;
            this.gbAppointment.TabStop = false;
            this.gbAppointment.Text = "Appointment";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "ddd h:mm tt M/d/yyyy";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(5, 334);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(243, 20);
            this.dtpEnd.TabIndex = 22;
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "ddd h:mm tt M/d/yyyy";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(6, 295);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(241, 20);
            this.dtpStart.TabIndex = 21;
            // 
            // rtbDescription
            // 
            this.rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbDescription.Location = new System.Drawing.Point(6, 71);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(241, 50);
            this.rtbDescription.TabIndex = 1;
            this.rtbDescription.Text = "This is a description";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(6, 202);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(31, 13);
            this.lbType.TabIndex = 20;
            this.lbType.Text = "Type";
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(5, 217);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(242, 20);
            this.tbType.TabIndex = 4;
            this.tbType.Text = "Type";
            // 
            // lbStart
            // 
            this.lbStart.AutoSize = true;
            this.lbStart.Location = new System.Drawing.Point(6, 279);
            this.lbStart.Name = "lbStart";
            this.lbStart.Size = new System.Drawing.Size(29, 13);
            this.lbStart.TabIndex = 15;
            this.lbStart.Text = "Start";
            // 
            // lbEnd
            // 
            this.lbEnd.AutoSize = true;
            this.lbEnd.Location = new System.Drawing.Point(6, 318);
            this.lbEnd.Name = "lbEnd";
            this.lbEnd.Size = new System.Drawing.Size(26, 13);
            this.lbEnd.TabIndex = 13;
            this.lbEnd.Text = "End";
            // 
            // lbURL
            // 
            this.lbURL.AutoSize = true;
            this.lbURL.Location = new System.Drawing.Point(6, 240);
            this.lbURL.Name = "lbURL";
            this.lbURL.Size = new System.Drawing.Size(29, 13);
            this.lbURL.TabIndex = 11;
            this.lbURL.Text = "URL";
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(6, 256);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(242, 20);
            this.tbURL.TabIndex = 5;
            this.tbURL.Text = "URL";
            // 
            // lbContact
            // 
            this.lbContact.AutoSize = true;
            this.lbContact.Location = new System.Drawing.Point(6, 163);
            this.lbContact.Name = "lbContact";
            this.lbContact.Size = new System.Drawing.Size(44, 13);
            this.lbContact.TabIndex = 9;
            this.lbContact.Text = "Contact";
            // 
            // tbContact
            // 
            this.tbContact.Location = new System.Drawing.Point(6, 179);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(242, 20);
            this.tbContact.TabIndex = 3;
            this.tbContact.Text = "Contact";
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Location = new System.Drawing.Point(6, 124);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(48, 13);
            this.lbLocation.TabIndex = 6;
            this.lbLocation.Text = "Location";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(6, 55);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(60, 13);
            this.lbDescription.TabIndex = 5;
            this.lbDescription.Text = "Description";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(6, 16);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(27, 13);
            this.lbTitle.TabIndex = 4;
            this.lbTitle.Text = "Title";
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(6, 140);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(242, 20);
            this.tbLocation.TabIndex = 2;
            this.tbLocation.Text = "Location";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(6, 32);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(242, 20);
            this.tbTitle.TabIndex = 0;
            this.tbTitle.Text = "Title";
            // 
            // dgvAppointment
            // 
            this.dgvAppointment.AllowUserToAddRows = false;
            this.dgvAppointment.AllowUserToDeleteRows = false;
            this.dgvAppointment.AllowUserToResizeColumns = false;
            this.dgvAppointment.AllowUserToResizeRows = false;
            this.dgvAppointment.BackgroundColor = System.Drawing.Color.White;
            this.dgvAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointment.Location = new System.Drawing.Point(0, 0);
            this.dgvAppointment.MultiSelect = false;
            this.dgvAppointment.Name = "dgvAppointment";
            this.dgvAppointment.ReadOnly = true;
            this.dgvAppointment.RowHeadersVisible = false;
            this.dgvAppointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointment.Size = new System.Drawing.Size(610, 417);
            this.dgvAppointment.TabIndex = 1;
            this.dgvAppointment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointment_CellClick);
            // 
            // tabCalendar
            // 
            this.tabCalendar.Controls.Add(this.lstActive);
            this.tabCalendar.Controls.Add(this.lstSchedule);
            this.tabCalendar.Controls.Add(this.lblSchedule);
            this.tabCalendar.Controls.Add(this.lblActive);
            this.tabCalendar.Controls.Add(this.lblTypeCount);
            this.tabCalendar.Controls.Add(this.lblMonth);
            this.tabCalendar.Controls.Add(this.lblWeek);
            this.tabCalendar.Controls.Add(this.lstCount);
            this.tabCalendar.Controls.Add(this.lstMonth);
            this.tabCalendar.Controls.Add(this.lstWeek);
            this.tabCalendar.Location = new System.Drawing.Point(4, 22);
            this.tabCalendar.Name = "tabCalendar";
            this.tabCalendar.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalendar.Size = new System.Drawing.Size(876, 424);
            this.tabCalendar.TabIndex = 2;
            this.tabCalendar.Text = "Calendar";
            this.tabCalendar.UseVisualStyleBackColor = true;
            // 
            // lstActive
            // 
            this.lstActive.FormattingEnabled = true;
            this.lstActive.HorizontalScrollbar = true;
            this.lstActive.Location = new System.Drawing.Point(700, 19);
            this.lstActive.Name = "lstActive";
            this.lstActive.Size = new System.Drawing.Size(163, 173);
            this.lstActive.TabIndex = 12;
            // 
            // lstSchedule
            // 
            this.lstSchedule.FormattingEnabled = true;
            this.lstSchedule.HorizontalScrollbar = true;
            this.lstSchedule.Location = new System.Drawing.Point(9, 19);
            this.lstSchedule.Name = "lstSchedule";
            this.lstSchedule.Size = new System.Drawing.Size(415, 173);
            this.lstSchedule.TabIndex = 11;
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Location = new System.Drawing.Point(6, 3);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(77, 13);
            this.lblSchedule.TabIndex = 8;
            this.lblSchedule.Text = "User Schedule";
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Location = new System.Drawing.Point(697, 3);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(115, 13);
            this.lblActive.TabIndex = 7;
            this.lblActive.Text = "Active Customer Count";
            // 
            // lblTypeCount
            // 
            this.lblTypeCount.AutoSize = true;
            this.lblTypeCount.Location = new System.Drawing.Point(446, 3);
            this.lblTypeCount.Name = "lblTypeCount";
            this.lblTypeCount.Size = new System.Drawing.Size(102, 13);
            this.lblTypeCount.TabIndex = 6;
            this.lblTypeCount.Text = "Monthly Type Count";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(6, 222);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(74, 13);
            this.lblMonth.TabIndex = 5;
            this.lblMonth.Text = "Current Month";
            // 
            // lblWeek
            // 
            this.lblWeek.AutoSize = true;
            this.lblWeek.Location = new System.Drawing.Point(446, 222);
            this.lblWeek.Name = "lblWeek";
            this.lblWeek.Size = new System.Drawing.Size(73, 13);
            this.lblWeek.TabIndex = 4;
            this.lblWeek.Text = "Current Week";
            // 
            // lstCount
            // 
            this.lstCount.FormattingEnabled = true;
            this.lstCount.HorizontalScrollbar = true;
            this.lstCount.Location = new System.Drawing.Point(449, 19);
            this.lstCount.Name = "lstCount";
            this.lstCount.Size = new System.Drawing.Size(163, 173);
            this.lstCount.TabIndex = 3;
            // 
            // lstMonth
            // 
            this.lstMonth.FormattingEnabled = true;
            this.lstMonth.HorizontalScrollbar = true;
            this.lstMonth.Location = new System.Drawing.Point(449, 238);
            this.lstMonth.Name = "lstMonth";
            this.lstMonth.Size = new System.Drawing.Size(421, 173);
            this.lstMonth.TabIndex = 2;
            // 
            // lstWeek
            // 
            this.lstWeek.FormattingEnabled = true;
            this.lstWeek.HorizontalScrollbar = true;
            this.lstWeek.Location = new System.Drawing.Point(9, 238);
            this.lstWeek.Name = "lstWeek";
            this.lstWeek.Size = new System.Drawing.Size(421, 173);
            this.lstWeek.TabIndex = 1;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(844, 28);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(55, 37);
            this.btExit.TabIndex = 13;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // lbHello
            // 
            this.lbHello.AutoSize = true;
            this.lbHello.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHello.Location = new System.Drawing.Point(12, 25);
            this.lbHello.Name = "lbHello";
            this.lbHello.Size = new System.Drawing.Size(166, 33);
            this.lbHello.TabIndex = 14;
            this.lbHello.Text = "Hello, World!";
            // 
            // btUpd
            // 
            this.btUpd.Location = new System.Drawing.Point(701, 28);
            this.btUpd.Margin = new System.Windows.Forms.Padding(10);
            this.btUpd.Name = "btUpd";
            this.btUpd.Size = new System.Drawing.Size(55, 37);
            this.btUpd.TabIndex = 9;
            this.btUpd.Text = "Update";
            this.btUpd.UseVisualStyleBackColor = true;
            this.btUpd.Click += new System.EventHandler(this.btUpd_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(626, 28);
            this.btAdd.Margin = new System.Windows.Forms.Padding(10);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(55, 37);
            this.btAdd.TabIndex = 8;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(776, 28);
            this.btDel.Margin = new System.Windows.Forms.Padding(10);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(55, 37);
            this.btDel.TabIndex = 10;
            this.btDel.Text = "Delete";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 527);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.lbHello);
            this.Controls.Add(this.btUpd);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.tabCtrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GCO - Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.tabCtrl.ResumeLayout(false);
            this.tabCustomers.ResumeLayout(false);
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.tabAppointments.ResumeLayout(false);
            this.gbAppointment.ResumeLayout(false);
            this.gbAppointment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).EndInit();
            this.tabCalendar.ResumeLayout(false);
            this.tabCalendar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.TabPage tabAppointments;
        private System.Windows.Forms.GroupBox gbAppointment;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.Label lbStart;
        private System.Windows.Forms.Label lbEnd;
        private System.Windows.Forms.Label lbURL;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Label lbContact;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.DataGridView dgvAppointment;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.MaskedTextBox mtbPostal;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.Label lbPostal;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.TextBox tbAddress2;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TabPage tabCalendar;
        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.ListBox lstWeek;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lbHello;
        protected internal System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.ListBox lstMonth;
        private System.Windows.Forms.ListBox lstCount;
        private System.Windows.Forms.ListBox lstActive;
        private System.Windows.Forms.ListBox lstSchedule;
        private System.Windows.Forms.Label lblSchedule;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.Label lblTypeCount;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblWeek;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btUpd;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDel;
    }
}