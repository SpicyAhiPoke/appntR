
namespace Appointr
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.gbSign = new System.Windows.Forms.GroupBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbError = new System.Windows.Forms.Label();
            this.btSign = new System.Windows.Forms.Button();
            this.gbSign.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSign
            // 
            resources.ApplyResources(this.gbSign, "gbSign");
            this.gbSign.BackColor = System.Drawing.Color.White;
            this.gbSign.Controls.Add(this.tbUsername);
            this.gbSign.Controls.Add(this.btSign);
            this.gbSign.Controls.Add(this.tbPassword);
            this.gbSign.Controls.Add(this.lbError);
            this.gbSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbSign.Name = "gbSign";
            this.gbSign.TabStop = false;
            // 
            // tbUsername
            // 
            resources.ApplyResources(this.tbUsername, "tbUsername");
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            // 
            // tbPassword
            // 
            resources.ApplyResources(this.tbPassword, "tbPassword");
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // lbError
            // 
            resources.ApplyResources(this.lbError, "lbError");
            this.lbError.Name = "lbError";
            // 
            // btSign
            // 
            resources.ApplyResources(this.btSign, "btSign");
            this.btSign.BackColor = System.Drawing.Color.YellowGreen;
            this.btSign.ForeColor = System.Drawing.Color.White;
            this.btSign.Name = "btSign";
            this.btSign.UseVisualStyleBackColor = false;
            this.btSign.Click += new System.EventHandler(this.btSign_Click);
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbSign);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.gbSign.ResumeLayout(false);
            this.gbSign.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSign;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Button btSign;
        protected internal System.Windows.Forms.TextBox tbUsername;
        protected internal System.Windows.Forms.TextBox tbPassword;
    }
}