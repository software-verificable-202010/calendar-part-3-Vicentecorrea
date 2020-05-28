namespace CalendarApp.Views
{
    partial class AppointmentsInDayForm
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
            this.myAppointmentsListBox = new System.Windows.Forms.ListBox();
            this.appointmentSelectionLabel = new System.Windows.Forms.Label();
            this.dateAndTimeLabel = new System.Windows.Forms.Label();
            this.invitedAppointmentsListBox = new System.Windows.Forms.ListBox();
            this.yourAppointmentLabel = new System.Windows.Forms.Label();
            this.invitedAppointmentsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // myAppointmentsListBox
            // 
            this.myAppointmentsListBox.FormattingEnabled = true;
            this.myAppointmentsListBox.Location = new System.Drawing.Point(13, 82);
            this.myAppointmentsListBox.Name = "myAppointmentsListBox";
            this.myAppointmentsListBox.Size = new System.Drawing.Size(246, 199);
            this.myAppointmentsListBox.TabIndex = 0;
            this.myAppointmentsListBox.SelectedIndexChanged += new System.EventHandler(this.MyAppointmentslistBox_SelectedIndexChanged);
            // 
            // appointmentSelectionLabel
            // 
            this.appointmentSelectionLabel.AutoSize = true;
            this.appointmentSelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.appointmentSelectionLabel.Location = new System.Drawing.Point(9, 19);
            this.appointmentSelectionLabel.Name = "appointmentSelectionLabel";
            this.appointmentSelectionLabel.Size = new System.Drawing.Size(249, 20);
            this.appointmentSelectionLabel.TabIndex = 1;
            this.appointmentSelectionLabel.Text = "Select one of the appointments of";
            // 
            // dateAndTimeLabel
            // 
            this.dateAndTimeLabel.AutoSize = true;
            this.dateAndTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateAndTimeLabel.Location = new System.Drawing.Point(253, 19);
            this.dateAndTimeLabel.Name = "dateAndTimeLabel";
            this.dateAndTimeLabel.Size = new System.Drawing.Size(167, 20);
            this.dateAndTimeLabel.TabIndex = 2;
            this.dateAndTimeLabel.Text = "December 20 at 23:00";
            // 
            // invitedAppointmentsListBox
            // 
            this.invitedAppointmentsListBox.FormattingEnabled = true;
            this.invitedAppointmentsListBox.Location = new System.Drawing.Point(289, 82);
            this.invitedAppointmentsListBox.Name = "invitedAppointmentsListBox";
            this.invitedAppointmentsListBox.Size = new System.Drawing.Size(246, 199);
            this.invitedAppointmentsListBox.TabIndex = 3;
            this.invitedAppointmentsListBox.SelectedIndexChanged += new System.EventHandler(this.InvitedAppointmentsListBox_SelectedIndexChanged);
            // 
            // yourAppointmentLabel
            // 
            this.yourAppointmentLabel.AutoSize = true;
            this.yourAppointmentLabel.Location = new System.Drawing.Point(13, 63);
            this.yourAppointmentLabel.Name = "yourAppointmentLabel";
            this.yourAppointmentLabel.Size = new System.Drawing.Size(95, 13);
            this.yourAppointmentLabel.TabIndex = 4;
            this.yourAppointmentLabel.Text = "Your appointments";
            // 
            // invitedAppointmentsLabel
            // 
            this.invitedAppointmentsLabel.AutoSize = true;
            this.invitedAppointmentsLabel.Location = new System.Drawing.Point(289, 62);
            this.invitedAppointmentsLabel.Name = "invitedAppointmentsLabel";
            this.invitedAppointmentsLabel.Size = new System.Drawing.Size(191, 13);
            this.invitedAppointmentsLabel.TabIndex = 5;
            this.invitedAppointmentsLabel.Text = "Appointments you have been invited to";
            // 
            // AppointmentsInDayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 298);
            this.Controls.Add(this.invitedAppointmentsLabel);
            this.Controls.Add(this.yourAppointmentLabel);
            this.Controls.Add(this.invitedAppointmentsListBox);
            this.Controls.Add(this.dateAndTimeLabel);
            this.Controls.Add(this.appointmentSelectionLabel);
            this.Controls.Add(this.myAppointmentsListBox);
            this.Name = "AppointmentsInDayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox myAppointmentsListBox;
        private System.Windows.Forms.Label appointmentSelectionLabel;
        private System.Windows.Forms.Label dateAndTimeLabel;
        private System.Windows.Forms.ListBox invitedAppointmentsListBox;
        private System.Windows.Forms.Label yourAppointmentLabel;
        private System.Windows.Forms.Label invitedAppointmentsLabel;
    }
}