namespace CalendarApp.Views
{
    partial class CreateAppointmentForm
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
            this.appointmentTitleTextBox = new System.Windows.Forms.TextBox();
            this.appointmentTitleLabel = new System.Windows.Forms.Label();
            this.appointmentDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.appointmentDescriptionLabel = new System.Windows.Forms.Label();
            this.appointmentStartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.appointmentStartDateLabel = new System.Windows.Forms.Label();
            this.appointmentEndDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.appointmentEndDateLabel = new System.Windows.Forms.Label();
            this.createAppointmentButton = new System.Windows.Forms.Button();
            this.allUserNamesListBox = new System.Windows.Forms.ListBox();
            this.invitedUserNamesListBox = new System.Windows.Forms.ListBox();
            this.allUsersLabel = new System.Windows.Forms.Label();
            this.invitedUsersLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // appointmentTitleTextBox
            // 
            this.appointmentTitleTextBox.Location = new System.Drawing.Point(78, 18);
            this.appointmentTitleTextBox.Name = "appointmentTitleTextBox";
            this.appointmentTitleTextBox.Size = new System.Drawing.Size(214, 20);
            this.appointmentTitleTextBox.TabIndex = 0;
            // 
            // appointmentTitleLabel
            // 
            this.appointmentTitleLabel.AutoSize = true;
            this.appointmentTitleLabel.Location = new System.Drawing.Point(45, 21);
            this.appointmentTitleLabel.Name = "appointmentTitleLabel";
            this.appointmentTitleLabel.Size = new System.Drawing.Size(27, 13);
            this.appointmentTitleLabel.TabIndex = 1;
            this.appointmentTitleLabel.Text = "Title";
            // 
            // appointmentDescriptionRichTextBox
            // 
            this.appointmentDescriptionRichTextBox.Location = new System.Drawing.Point(78, 44);
            this.appointmentDescriptionRichTextBox.Name = "appointmentDescriptionRichTextBox";
            this.appointmentDescriptionRichTextBox.Size = new System.Drawing.Size(214, 85);
            this.appointmentDescriptionRichTextBox.TabIndex = 2;
            this.appointmentDescriptionRichTextBox.Text = "";
            // 
            // appointmentDescriptionLabel
            // 
            this.appointmentDescriptionLabel.AutoSize = true;
            this.appointmentDescriptionLabel.Location = new System.Drawing.Point(12, 44);
            this.appointmentDescriptionLabel.Name = "appointmentDescriptionLabel";
            this.appointmentDescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.appointmentDescriptionLabel.TabIndex = 3;
            this.appointmentDescriptionLabel.Text = "Description";
            // 
            // appointmentStartDateDateTimePicker
            // 
            this.appointmentStartDateDateTimePicker.CustomFormat = "dddd, d MMMM yyyy HH:mm";
            this.appointmentStartDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.appointmentStartDateDateTimePicker.Location = new System.Drawing.Point(78, 135);
            this.appointmentStartDateDateTimePicker.Name = "appointmentStartDateDateTimePicker";
            this.appointmentStartDateDateTimePicker.Size = new System.Drawing.Size(214, 20);
            this.appointmentStartDateDateTimePicker.TabIndex = 4;
            // 
            // appointmentStartDateLabel
            // 
            this.appointmentStartDateLabel.AutoSize = true;
            this.appointmentStartDateLabel.Location = new System.Drawing.Point(19, 135);
            this.appointmentStartDateLabel.Name = "appointmentStartDateLabel";
            this.appointmentStartDateLabel.Size = new System.Drawing.Size(53, 13);
            this.appointmentStartDateLabel.TabIndex = 5;
            this.appointmentStartDateLabel.Text = "Start date";
            // 
            // appointmentEndDateDateTimePicker
            // 
            this.appointmentEndDateDateTimePicker.CustomFormat = "dddd, d MMMM yyyy HH:mm";
            this.appointmentEndDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.appointmentEndDateDateTimePicker.Location = new System.Drawing.Point(78, 161);
            this.appointmentEndDateDateTimePicker.Name = "appointmentEndDateDateTimePicker";
            this.appointmentEndDateDateTimePicker.Size = new System.Drawing.Size(214, 20);
            this.appointmentEndDateDateTimePicker.TabIndex = 6;
            // 
            // appointmentEndDateLabel
            // 
            this.appointmentEndDateLabel.AutoSize = true;
            this.appointmentEndDateLabel.Location = new System.Drawing.Point(22, 161);
            this.appointmentEndDateLabel.Name = "appointmentEndDateLabel";
            this.appointmentEndDateLabel.Size = new System.Drawing.Size(50, 13);
            this.appointmentEndDateLabel.TabIndex = 7;
            this.appointmentEndDateLabel.Text = "End date";
            // 
            // createAppointmentButton
            // 
            this.createAppointmentButton.Location = new System.Drawing.Point(323, 229);
            this.createAppointmentButton.Name = "createAppointmentButton";
            this.createAppointmentButton.Size = new System.Drawing.Size(132, 23);
            this.createAppointmentButton.TabIndex = 8;
            this.createAppointmentButton.Text = "Create appointment";
            this.createAppointmentButton.UseVisualStyleBackColor = true;
            this.createAppointmentButton.Click += new System.EventHandler(this.CreateAppointmentButton_Click);
            // 
            // allUserNamesListBox
            // 
            this.allUserNamesListBox.BackColor = System.Drawing.Color.LightPink;
            this.allUserNamesListBox.FormattingEnabled = true;
            this.allUserNamesListBox.Location = new System.Drawing.Point(323, 44);
            this.allUserNamesListBox.Name = "allUserNamesListBox";
            this.allUserNamesListBox.Size = new System.Drawing.Size(171, 134);
            this.allUserNamesListBox.TabIndex = 9;
            this.allUserNamesListBox.Click += new System.EventHandler(this.AllUserNamesListBox_Click);
            // 
            // invitedUserNamesListBox
            // 
            this.invitedUserNamesListBox.BackColor = System.Drawing.Color.LightGreen;
            this.invitedUserNamesListBox.FormattingEnabled = true;
            this.invitedUserNamesListBox.Location = new System.Drawing.Point(562, 44);
            this.invitedUserNamesListBox.Name = "invitedUserNamesListBox";
            this.invitedUserNamesListBox.Size = new System.Drawing.Size(171, 134);
            this.invitedUserNamesListBox.TabIndex = 10;
            this.invitedUserNamesListBox.Click += new System.EventHandler(this.InvitedUserNamesListBox_Click);
            // 
            // allUsersLabel
            // 
            this.allUsersLabel.AutoSize = true;
            this.allUsersLabel.Location = new System.Drawing.Point(320, 21);
            this.allUsersLabel.Name = "allUsersLabel";
            this.allUsersLabel.Size = new System.Drawing.Size(207, 13);
            this.allUsersLabel.TabIndex = 11;
            this.allUsersLabel.Text = "Choose users to invite to your appointment";
            // 
            // invitedUsersLabel
            // 
            this.invitedUsersLabel.AutoSize = true;
            this.invitedUsersLabel.Location = new System.Drawing.Point(559, 21);
            this.invitedUsersLabel.Name = "invitedUsersLabel";
            this.invitedUsersLabel.Size = new System.Drawing.Size(67, 13);
            this.invitedUsersLabel.TabIndex = 12;
            this.invitedUsersLabel.Text = "Invited users";
            // 
            // CreateAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 284);
            this.Controls.Add(this.invitedUsersLabel);
            this.Controls.Add(this.allUsersLabel);
            this.Controls.Add(this.invitedUserNamesListBox);
            this.Controls.Add(this.allUserNamesListBox);
            this.Controls.Add(this.createAppointmentButton);
            this.Controls.Add(this.appointmentEndDateLabel);
            this.Controls.Add(this.appointmentEndDateDateTimePicker);
            this.Controls.Add(this.appointmentStartDateLabel);
            this.Controls.Add(this.appointmentStartDateDateTimePicker);
            this.Controls.Add(this.appointmentDescriptionLabel);
            this.Controls.Add(this.appointmentDescriptionRichTextBox);
            this.Controls.Add(this.appointmentTitleLabel);
            this.Controls.Add(this.appointmentTitleTextBox);
            this.Name = "CreateAppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox appointmentTitleTextBox;
        private System.Windows.Forms.Label appointmentTitleLabel;
        private System.Windows.Forms.RichTextBox appointmentDescriptionRichTextBox;
        private System.Windows.Forms.Label appointmentDescriptionLabel;
        private System.Windows.Forms.DateTimePicker appointmentStartDateDateTimePicker;
        private System.Windows.Forms.Label appointmentStartDateLabel;
        private System.Windows.Forms.DateTimePicker appointmentEndDateDateTimePicker;
        private System.Windows.Forms.Label appointmentEndDateLabel;
        private System.Windows.Forms.Button createAppointmentButton;
        private System.Windows.Forms.ListBox allUserNamesListBox;
        private System.Windows.Forms.ListBox invitedUserNamesListBox;
        private System.Windows.Forms.Label allUsersLabel;
        private System.Windows.Forms.Label invitedUsersLabel;
    }
}