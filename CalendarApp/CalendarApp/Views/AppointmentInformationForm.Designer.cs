namespace CalendarApp.Views
{
    partial class AppointmentInformationForm
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
            this.appointmentTitleLabel = new System.Windows.Forms.Label();
            this.appointmentTitleValue = new System.Windows.Forms.Label();
            this.appointmentDescriptionLabel = new System.Windows.Forms.Label();
            this.appointmentDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.appointmentStartDateLabel = new System.Windows.Forms.Label();
            this.appointmentStartDateValue = new System.Windows.Forms.Label();
            this.appointmentEndDateLabel = new System.Windows.Forms.Label();
            this.appointmentEndDateValue = new System.Windows.Forms.Label();
            this.appointmentOwnerValue = new System.Windows.Forms.Label();
            this.appointmentOwnerLabel = new System.Windows.Forms.Label();
            this.guestsListBox = new System.Windows.Forms.ListBox();
            this.guestsLabel = new System.Windows.Forms.Label();
            this.deleteAppointmentButton = new System.Windows.Forms.Button();
            this.editAppointmentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // appointmentTitleLabel
            // 
            this.appointmentTitleLabel.AutoSize = true;
            this.appointmentTitleLabel.Location = new System.Drawing.Point(37, 22);
            this.appointmentTitleLabel.Name = "appointmentTitleLabel";
            this.appointmentTitleLabel.Size = new System.Drawing.Size(27, 13);
            this.appointmentTitleLabel.TabIndex = 0;
            this.appointmentTitleLabel.Text = "Title";
            // 
            // appointmentTitleValue
            // 
            this.appointmentTitleValue.AutoSize = true;
            this.appointmentTitleValue.Location = new System.Drawing.Point(78, 22);
            this.appointmentTitleValue.Name = "appointmentTitleValue";
            this.appointmentTitleValue.Size = new System.Drawing.Size(85, 13);
            this.appointmentTitleValue.TabIndex = 1;
            this.appointmentTitleValue.Text = "appointmentTitle";
            // 
            // appointmentDescriptionLabel
            // 
            this.appointmentDescriptionLabel.AutoSize = true;
            this.appointmentDescriptionLabel.Location = new System.Drawing.Point(12, 44);
            this.appointmentDescriptionLabel.Name = "appointmentDescriptionLabel";
            this.appointmentDescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.appointmentDescriptionLabel.TabIndex = 2;
            this.appointmentDescriptionLabel.Text = "Description";
            // 
            // appointmentDescriptionRichTextBox
            // 
            this.appointmentDescriptionRichTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.appointmentDescriptionRichTextBox.Location = new System.Drawing.Point(78, 44);
            this.appointmentDescriptionRichTextBox.Name = "appointmentDescriptionRichTextBox";
            this.appointmentDescriptionRichTextBox.ReadOnly = true;
            this.appointmentDescriptionRichTextBox.Size = new System.Drawing.Size(213, 96);
            this.appointmentDescriptionRichTextBox.TabIndex = 3;
            this.appointmentDescriptionRichTextBox.Text = "";
            // 
            // appointmentStartDateLabel
            // 
            this.appointmentStartDateLabel.AutoSize = true;
            this.appointmentStartDateLabel.Location = new System.Drawing.Point(19, 151);
            this.appointmentStartDateLabel.Name = "appointmentStartDateLabel";
            this.appointmentStartDateLabel.Size = new System.Drawing.Size(53, 13);
            this.appointmentStartDateLabel.TabIndex = 4;
            this.appointmentStartDateLabel.Text = "Start date";
            // 
            // appointmentStartDateValue
            // 
            this.appointmentStartDateValue.AutoSize = true;
            this.appointmentStartDateValue.Location = new System.Drawing.Point(78, 151);
            this.appointmentStartDateValue.Name = "appointmentStartDateValue";
            this.appointmentStartDateValue.Size = new System.Drawing.Size(110, 13);
            this.appointmentStartDateValue.TabIndex = 5;
            this.appointmentStartDateValue.Text = "appointmentStartDate";
            // 
            // appointmentEndDateLabel
            // 
            this.appointmentEndDateLabel.AutoSize = true;
            this.appointmentEndDateLabel.Location = new System.Drawing.Point(22, 177);
            this.appointmentEndDateLabel.Name = "appointmentEndDateLabel";
            this.appointmentEndDateLabel.Size = new System.Drawing.Size(50, 13);
            this.appointmentEndDateLabel.TabIndex = 6;
            this.appointmentEndDateLabel.Text = "End date";
            // 
            // appointmentEndDateValue
            // 
            this.appointmentEndDateValue.AutoSize = true;
            this.appointmentEndDateValue.Location = new System.Drawing.Point(78, 177);
            this.appointmentEndDateValue.Name = "appointmentEndDateValue";
            this.appointmentEndDateValue.Size = new System.Drawing.Size(107, 13);
            this.appointmentEndDateValue.TabIndex = 7;
            this.appointmentEndDateValue.Text = "appointmentEndDate";
            // 
            // appointmentOwnerValue
            // 
            this.appointmentOwnerValue.AutoSize = true;
            this.appointmentOwnerValue.Location = new System.Drawing.Point(78, 205);
            this.appointmentOwnerValue.Name = "appointmentOwnerValue";
            this.appointmentOwnerValue.Size = new System.Drawing.Size(96, 13);
            this.appointmentOwnerValue.TabIndex = 8;
            this.appointmentOwnerValue.Text = "appointmentOwner";
            // 
            // appointmentOwnerLabel
            // 
            this.appointmentOwnerLabel.AutoSize = true;
            this.appointmentOwnerLabel.Location = new System.Drawing.Point(34, 205);
            this.appointmentOwnerLabel.Name = "appointmentOwnerLabel";
            this.appointmentOwnerLabel.Size = new System.Drawing.Size(38, 13);
            this.appointmentOwnerLabel.TabIndex = 9;
            this.appointmentOwnerLabel.Text = "Owner";
            // 
            // guestsListBox
            // 
            this.guestsListBox.FormattingEnabled = true;
            this.guestsListBox.Location = new System.Drawing.Point(322, 44);
            this.guestsListBox.Name = "guestsListBox";
            this.guestsListBox.Size = new System.Drawing.Size(193, 147);
            this.guestsListBox.TabIndex = 10;
            // 
            // guestsLabel
            // 
            this.guestsLabel.AutoSize = true;
            this.guestsLabel.Location = new System.Drawing.Point(322, 21);
            this.guestsLabel.Name = "guestsLabel";
            this.guestsLabel.Size = new System.Drawing.Size(40, 13);
            this.guestsLabel.TabIndex = 11;
            this.guestsLabel.Text = "Guests";
            // 
            // deleteAppointmentButton
            // 
            this.deleteAppointmentButton.Location = new System.Drawing.Point(402, 222);
            this.deleteAppointmentButton.Name = "deleteAppointmentButton";
            this.deleteAppointmentButton.Size = new System.Drawing.Size(113, 23);
            this.deleteAppointmentButton.TabIndex = 12;
            this.deleteAppointmentButton.Text = "Delete appointment";
            this.deleteAppointmentButton.UseVisualStyleBackColor = true;
            this.deleteAppointmentButton.Click += new System.EventHandler(this.DeleteAppointmentButton_Click);
            // 
            // editAppointmentButton
            // 
            this.editAppointmentButton.Location = new System.Drawing.Point(249, 222);
            this.editAppointmentButton.Name = "editAppointmentButton";
            this.editAppointmentButton.Size = new System.Drawing.Size(113, 23);
            this.editAppointmentButton.TabIndex = 13;
            this.editAppointmentButton.Text = "Edit appointment";
            this.editAppointmentButton.UseVisualStyleBackColor = true;
            this.editAppointmentButton.Click += new System.EventHandler(this.EditAppointmentButton_Click);
            // 
            // AppointmentInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 257);
            this.Controls.Add(this.editAppointmentButton);
            this.Controls.Add(this.deleteAppointmentButton);
            this.Controls.Add(this.guestsLabel);
            this.Controls.Add(this.guestsListBox);
            this.Controls.Add(this.appointmentOwnerLabel);
            this.Controls.Add(this.appointmentOwnerValue);
            this.Controls.Add(this.appointmentEndDateValue);
            this.Controls.Add(this.appointmentEndDateLabel);
            this.Controls.Add(this.appointmentStartDateValue);
            this.Controls.Add(this.appointmentStartDateLabel);
            this.Controls.Add(this.appointmentDescriptionRichTextBox);
            this.Controls.Add(this.appointmentDescriptionLabel);
            this.Controls.Add(this.appointmentTitleValue);
            this.Controls.Add(this.appointmentTitleLabel);
            this.Name = "AppointmentInformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appointmentTitleLabel;
        private System.Windows.Forms.Label appointmentTitleValue;
        private System.Windows.Forms.Label appointmentDescriptionLabel;
        private System.Windows.Forms.RichTextBox appointmentDescriptionRichTextBox;
        private System.Windows.Forms.Label appointmentStartDateLabel;
        private System.Windows.Forms.Label appointmentStartDateValue;
        private System.Windows.Forms.Label appointmentEndDateLabel;
        private System.Windows.Forms.Label appointmentEndDateValue;
        private System.Windows.Forms.Label appointmentOwnerValue;
        private System.Windows.Forms.Label appointmentOwnerLabel;
        private System.Windows.Forms.ListBox guestsListBox;
        private System.Windows.Forms.Label guestsLabel;
        private System.Windows.Forms.Button deleteAppointmentButton;
        private System.Windows.Forms.Button editAppointmentButton;
    }
}