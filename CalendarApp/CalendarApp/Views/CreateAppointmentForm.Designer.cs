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
            this.appointmentNameTextBox = new System.Windows.Forms.TextBox();
            this.appointmentNameLabel = new System.Windows.Forms.Label();
            this.appointmentDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.appointmentDescriptionLabel = new System.Windows.Forms.Label();
            this.appointmentStartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.appointmentStartDateLabel = new System.Windows.Forms.Label();
            this.appointmentEndDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.appointmentEndDateLabel = new System.Windows.Forms.Label();
            this.createappointmentButton = new System.Windows.Forms.Button();
            this.allUsernamesListBox = new System.Windows.Forms.ListBox();
            this.invitedUsernamesListBox = new System.Windows.Forms.ListBox();
            this.allUsersLabel = new System.Windows.Forms.Label();
            this.invitedUsersLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // appointmentNameTextBox
            // 
            this.appointmentNameTextBox.Location = new System.Drawing.Point(78, 18);
            this.appointmentNameTextBox.Name = "appointmentNameTextBox";
            this.appointmentNameTextBox.Size = new System.Drawing.Size(214, 20);
            this.appointmentNameTextBox.TabIndex = 0;
            // 
            // appointmentNameLabel
            // 
            this.appointmentNameLabel.AutoSize = true;
            this.appointmentNameLabel.Location = new System.Drawing.Point(37, 18);
            this.appointmentNameLabel.Name = "appointmentNameLabel";
            this.appointmentNameLabel.Size = new System.Drawing.Size(35, 13);
            this.appointmentNameLabel.TabIndex = 1;
            this.appointmentNameLabel.Text = "Name";
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
            // createappointmentButton
            // 
            this.createappointmentButton.Location = new System.Drawing.Point(323, 229);
            this.createappointmentButton.Name = "createappointmentButton";
            this.createappointmentButton.Size = new System.Drawing.Size(132, 23);
            this.createappointmentButton.TabIndex = 8;
            this.createappointmentButton.Text = "Create appointment";
            this.createappointmentButton.UseVisualStyleBackColor = true;
            this.createappointmentButton.Click += new System.EventHandler(this.CreateAppointmentButton_Click);
            // 
            // allUsernamesListBox
            // 
            this.allUsernamesListBox.FormattingEnabled = true;
            this.allUsernamesListBox.Location = new System.Drawing.Point(323, 44);
            this.allUsernamesListBox.Name = "allUsernamesListBox";
            this.allUsernamesListBox.Size = new System.Drawing.Size(171, 134);
            this.allUsernamesListBox.TabIndex = 9;
            this.allUsernamesListBox.Click += new System.EventHandler(this.AllUsernamesListBox_Click);
            // 
            // invitedUsernamesListBox
            // 
            this.invitedUsernamesListBox.FormattingEnabled = true;
            this.invitedUsernamesListBox.Location = new System.Drawing.Point(562, 47);
            this.invitedUsernamesListBox.Name = "invitedUsernamesListBox";
            this.invitedUsernamesListBox.Size = new System.Drawing.Size(171, 134);
            this.invitedUsernamesListBox.TabIndex = 10;
            this.invitedUsernamesListBox.Click += new System.EventHandler(this.InvitedUsernamesListBox_Click);
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
            this.Controls.Add(this.invitedUsernamesListBox);
            this.Controls.Add(this.allUsernamesListBox);
            this.Controls.Add(this.createappointmentButton);
            this.Controls.Add(this.appointmentEndDateLabel);
            this.Controls.Add(this.appointmentEndDateDateTimePicker);
            this.Controls.Add(this.appointmentStartDateLabel);
            this.Controls.Add(this.appointmentStartDateDateTimePicker);
            this.Controls.Add(this.appointmentDescriptionLabel);
            this.Controls.Add(this.appointmentDescriptionRichTextBox);
            this.Controls.Add(this.appointmentNameLabel);
            this.Controls.Add(this.appointmentNameTextBox);
            this.Name = "CreateAppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox appointmentNameTextBox;
        private System.Windows.Forms.Label appointmentNameLabel;
        private System.Windows.Forms.RichTextBox appointmentDescriptionRichTextBox;
        private System.Windows.Forms.Label appointmentDescriptionLabel;
        private System.Windows.Forms.DateTimePicker appointmentStartDateDateTimePicker;
        private System.Windows.Forms.Label appointmentStartDateLabel;
        private System.Windows.Forms.DateTimePicker appointmentEndDateDateTimePicker;
        private System.Windows.Forms.Label appointmentEndDateLabel;
        private System.Windows.Forms.Button createappointmentButton;
        private System.Windows.Forms.ListBox allUsernamesListBox;
        private System.Windows.Forms.ListBox invitedUsernamesListBox;
        private System.Windows.Forms.Label allUsersLabel;
        private System.Windows.Forms.Label invitedUsersLabel;
    }
}