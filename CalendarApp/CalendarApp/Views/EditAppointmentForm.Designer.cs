namespace CalendarApp.Views
{
    partial class EditAppointmentForm
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
            this.invitedUsersLabel = new System.Windows.Forms.Label();
            this.allUsersLabel = new System.Windows.Forms.Label();
            this.invitedUserNamesListBox = new System.Windows.Forms.ListBox();
            this.notInvitedUserNamesListBox = new System.Windows.Forms.ListBox();
            this.editAppointmentButton = new System.Windows.Forms.Button();
            this.appointmentEndDateLabel = new System.Windows.Forms.Label();
            this.appointmentEndDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.appointmentStartDateLabel = new System.Windows.Forms.Label();
            this.appointmentStartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.appointmentDescriptionLabel = new System.Windows.Forms.Label();
            this.appointmentDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.appointmentTitleLabel = new System.Windows.Forms.Label();
            this.appointmentTitleTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // invitedUsersLabel
            // 
            this.invitedUsersLabel.AutoSize = true;
            this.invitedUsersLabel.Location = new System.Drawing.Point(563, 28);
            this.invitedUsersLabel.Name = "invitedUsersLabel";
            this.invitedUsersLabel.Size = new System.Drawing.Size(67, 13);
            this.invitedUsersLabel.TabIndex = 25;
            this.invitedUsersLabel.Text = "Invited users";
            // 
            // allUsersLabel
            // 
            this.allUsersLabel.AutoSize = true;
            this.allUsersLabel.Location = new System.Drawing.Point(324, 28);
            this.allUsersLabel.Name = "allUsersLabel";
            this.allUsersLabel.Size = new System.Drawing.Size(207, 13);
            this.allUsersLabel.TabIndex = 24;
            this.allUsersLabel.Text = "Choose users to invite to your appointment";
            // 
            // invitedUserNamesListBox
            // 
            this.invitedUserNamesListBox.BackColor = System.Drawing.Color.LightGreen;
            this.invitedUserNamesListBox.FormattingEnabled = true;
            this.invitedUserNamesListBox.Location = new System.Drawing.Point(566, 51);
            this.invitedUserNamesListBox.Name = "invitedUserNamesListBox";
            this.invitedUserNamesListBox.Size = new System.Drawing.Size(171, 134);
            this.invitedUserNamesListBox.TabIndex = 23;
            this.invitedUserNamesListBox.Click += new System.EventHandler(this.InvitedUserNamesListBox_Click);
            // 
            // notInvitedUserNamesListBox
            // 
            this.notInvitedUserNamesListBox.BackColor = System.Drawing.Color.LightPink;
            this.notInvitedUserNamesListBox.FormattingEnabled = true;
            this.notInvitedUserNamesListBox.Location = new System.Drawing.Point(327, 51);
            this.notInvitedUserNamesListBox.Name = "notInvitedUserNamesListBox";
            this.notInvitedUserNamesListBox.Size = new System.Drawing.Size(171, 134);
            this.notInvitedUserNamesListBox.TabIndex = 22;
            this.notInvitedUserNamesListBox.Click += new System.EventHandler(this.NotInvitedUserNamesListBox_Click);
            // 
            // editAppointmentButton
            // 
            this.editAppointmentButton.Location = new System.Drawing.Point(327, 236);
            this.editAppointmentButton.Name = "editAppointmentButton";
            this.editAppointmentButton.Size = new System.Drawing.Size(132, 23);
            this.editAppointmentButton.TabIndex = 21;
            this.editAppointmentButton.Text = "Edit appointment";
            this.editAppointmentButton.UseVisualStyleBackColor = true;
            this.editAppointmentButton.Click += new System.EventHandler(this.EditAppointmentButton_Click);
            // 
            // appointmentEndDateLabel
            // 
            this.appointmentEndDateLabel.AutoSize = true;
            this.appointmentEndDateLabel.Location = new System.Drawing.Point(26, 168);
            this.appointmentEndDateLabel.Name = "appointmentEndDateLabel";
            this.appointmentEndDateLabel.Size = new System.Drawing.Size(50, 13);
            this.appointmentEndDateLabel.TabIndex = 20;
            this.appointmentEndDateLabel.Text = "End date";
            // 
            // appointmentEndDateDateTimePicker
            // 
            this.appointmentEndDateDateTimePicker.CustomFormat = "dddd, d MMMM yyyy HH:mm";
            this.appointmentEndDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.appointmentEndDateDateTimePicker.Location = new System.Drawing.Point(82, 168);
            this.appointmentEndDateDateTimePicker.Name = "appointmentEndDateDateTimePicker";
            this.appointmentEndDateDateTimePicker.Size = new System.Drawing.Size(214, 20);
            this.appointmentEndDateDateTimePicker.TabIndex = 19;
            // 
            // appointmentStartDateLabel
            // 
            this.appointmentStartDateLabel.AutoSize = true;
            this.appointmentStartDateLabel.Location = new System.Drawing.Point(23, 142);
            this.appointmentStartDateLabel.Name = "appointmentStartDateLabel";
            this.appointmentStartDateLabel.Size = new System.Drawing.Size(53, 13);
            this.appointmentStartDateLabel.TabIndex = 18;
            this.appointmentStartDateLabel.Text = "Start date";
            // 
            // appointmentStartDateDateTimePicker
            // 
            this.appointmentStartDateDateTimePicker.CustomFormat = "dddd, d MMMM yyyy HH:mm";
            this.appointmentStartDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.appointmentStartDateDateTimePicker.Location = new System.Drawing.Point(82, 142);
            this.appointmentStartDateDateTimePicker.Name = "appointmentStartDateDateTimePicker";
            this.appointmentStartDateDateTimePicker.Size = new System.Drawing.Size(214, 20);
            this.appointmentStartDateDateTimePicker.TabIndex = 17;
            // 
            // appointmentDescriptionLabel
            // 
            this.appointmentDescriptionLabel.AutoSize = true;
            this.appointmentDescriptionLabel.Location = new System.Drawing.Point(16, 51);
            this.appointmentDescriptionLabel.Name = "appointmentDescriptionLabel";
            this.appointmentDescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.appointmentDescriptionLabel.TabIndex = 16;
            this.appointmentDescriptionLabel.Text = "Description";
            // 
            // appointmentDescriptionRichTextBox
            // 
            this.appointmentDescriptionRichTextBox.Location = new System.Drawing.Point(82, 51);
            this.appointmentDescriptionRichTextBox.Name = "appointmentDescriptionRichTextBox";
            this.appointmentDescriptionRichTextBox.Size = new System.Drawing.Size(214, 85);
            this.appointmentDescriptionRichTextBox.TabIndex = 15;
            this.appointmentDescriptionRichTextBox.Text = "";
            // 
            // appointmentTitleLabel
            // 
            this.appointmentTitleLabel.AutoSize = true;
            this.appointmentTitleLabel.Location = new System.Drawing.Point(41, 25);
            this.appointmentTitleLabel.Name = "appointmentTitleLabel";
            this.appointmentTitleLabel.Size = new System.Drawing.Size(27, 13);
            this.appointmentTitleLabel.TabIndex = 14;
            this.appointmentTitleLabel.Text = "Title";
            // 
            // appointmentTitleTextBox
            // 
            this.appointmentTitleTextBox.Location = new System.Drawing.Point(82, 25);
            this.appointmentTitleTextBox.Name = "appointmentTitleTextBox";
            this.appointmentTitleTextBox.Size = new System.Drawing.Size(214, 20);
            this.appointmentTitleTextBox.TabIndex = 13;
            // 
            // EditAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 284);
            this.Controls.Add(this.invitedUsersLabel);
            this.Controls.Add(this.allUsersLabel);
            this.Controls.Add(this.invitedUserNamesListBox);
            this.Controls.Add(this.notInvitedUserNamesListBox);
            this.Controls.Add(this.editAppointmentButton);
            this.Controls.Add(this.appointmentEndDateLabel);
            this.Controls.Add(this.appointmentEndDateDateTimePicker);
            this.Controls.Add(this.appointmentStartDateLabel);
            this.Controls.Add(this.appointmentStartDateDateTimePicker);
            this.Controls.Add(this.appointmentDescriptionLabel);
            this.Controls.Add(this.appointmentDescriptionRichTextBox);
            this.Controls.Add(this.appointmentTitleLabel);
            this.Controls.Add(this.appointmentTitleTextBox);
            this.Name = "EditAppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label invitedUsersLabel;
        private System.Windows.Forms.Label allUsersLabel;
        private System.Windows.Forms.ListBox invitedUserNamesListBox;
        private System.Windows.Forms.ListBox notInvitedUserNamesListBox;
        private System.Windows.Forms.Button editAppointmentButton;
        private System.Windows.Forms.Label appointmentEndDateLabel;
        private System.Windows.Forms.DateTimePicker appointmentEndDateDateTimePicker;
        private System.Windows.Forms.Label appointmentStartDateLabel;
        private System.Windows.Forms.DateTimePicker appointmentStartDateDateTimePicker;
        private System.Windows.Forms.Label appointmentDescriptionLabel;
        private System.Windows.Forms.RichTextBox appointmentDescriptionRichTextBox;
        private System.Windows.Forms.Label appointmentTitleLabel;
        private System.Windows.Forms.TextBox appointmentTitleTextBox;
    }
}