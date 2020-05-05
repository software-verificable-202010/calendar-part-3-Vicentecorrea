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
            this.appointmentNameLabel = new System.Windows.Forms.Label();
            this.appointmentNameValue = new System.Windows.Forms.Label();
            this.appointmentDescriptionLabel = new System.Windows.Forms.Label();
            this.appointmentDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.appointmentStartDateLabel = new System.Windows.Forms.Label();
            this.appointmentStartDateValue = new System.Windows.Forms.Label();
            this.appointmentEndDateLabel = new System.Windows.Forms.Label();
            this.appointmentEndDateValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // appointmentNameLabel
            // 
            this.appointmentNameLabel.AutoSize = true;
            this.appointmentNameLabel.Location = new System.Drawing.Point(263, 91);
            this.appointmentNameLabel.Name = "appointmentNameLabel";
            this.appointmentNameLabel.Size = new System.Drawing.Size(35, 13);
            this.appointmentNameLabel.TabIndex = 0;
            this.appointmentNameLabel.Text = "Name";
            // 
            // appointmentNameValue
            // 
            this.appointmentNameValue.AutoSize = true;
            this.appointmentNameValue.Location = new System.Drawing.Point(306, 91);
            this.appointmentNameValue.Name = "appointmentNameValue";
            this.appointmentNameValue.Size = new System.Drawing.Size(35, 13);
            this.appointmentNameValue.TabIndex = 1;
            this.appointmentNameValue.Text = "label1";
            // 
            // appointmentDescriptionLabel
            // 
            this.appointmentDescriptionLabel.AutoSize = true;
            this.appointmentDescriptionLabel.Location = new System.Drawing.Point(238, 117);
            this.appointmentDescriptionLabel.Name = "appointmentDescriptionLabel";
            this.appointmentDescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.appointmentDescriptionLabel.TabIndex = 2;
            this.appointmentDescriptionLabel.Text = "Description";
            // 
            // appointmentDescriptionRichTextBox
            // 
            this.appointmentDescriptionRichTextBox.Location = new System.Drawing.Point(309, 117);
            this.appointmentDescriptionRichTextBox.Name = "appointmentDescriptionRichTextBox";
            this.appointmentDescriptionRichTextBox.ReadOnly = true;
            this.appointmentDescriptionRichTextBox.Size = new System.Drawing.Size(229, 96);
            this.appointmentDescriptionRichTextBox.TabIndex = 3;
            this.appointmentDescriptionRichTextBox.Text = "";
            // 
            // appointmentStartDateLabel
            // 
            this.appointmentStartDateLabel.AutoSize = true;
            this.appointmentStartDateLabel.Location = new System.Drawing.Point(245, 228);
            this.appointmentStartDateLabel.Name = "appointmentStartDateLabel";
            this.appointmentStartDateLabel.Size = new System.Drawing.Size(53, 13);
            this.appointmentStartDateLabel.TabIndex = 4;
            this.appointmentStartDateLabel.Text = "Start date";
            // 
            // appointmentStartDateValue
            // 
            this.appointmentStartDateValue.AutoSize = true;
            this.appointmentStartDateValue.Location = new System.Drawing.Point(306, 228);
            this.appointmentStartDateValue.Name = "appointmentStartDateValue";
            this.appointmentStartDateValue.Size = new System.Drawing.Size(35, 13);
            this.appointmentStartDateValue.TabIndex = 5;
            this.appointmentStartDateValue.Text = "label1";
            // 
            // appointmentEndDateLabel
            // 
            this.appointmentEndDateLabel.AutoSize = true;
            this.appointmentEndDateLabel.Location = new System.Drawing.Point(248, 258);
            this.appointmentEndDateLabel.Name = "appointmentEndDateLabel";
            this.appointmentEndDateLabel.Size = new System.Drawing.Size(50, 13);
            this.appointmentEndDateLabel.TabIndex = 6;
            this.appointmentEndDateLabel.Text = "End date";
            // 
            // appointmentEndDateValue
            // 
            this.appointmentEndDateValue.AutoSize = true;
            this.appointmentEndDateValue.Location = new System.Drawing.Point(306, 258);
            this.appointmentEndDateValue.Name = "appointmentEndDateValue";
            this.appointmentEndDateValue.Size = new System.Drawing.Size(35, 13);
            this.appointmentEndDateValue.TabIndex = 7;
            this.appointmentEndDateValue.Text = "label1";
            // 
            // AppointmentInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.appointmentEndDateValue);
            this.Controls.Add(this.appointmentEndDateLabel);
            this.Controls.Add(this.appointmentStartDateValue);
            this.Controls.Add(this.appointmentStartDateLabel);
            this.Controls.Add(this.appointmentDescriptionRichTextBox);
            this.Controls.Add(this.appointmentDescriptionLabel);
            this.Controls.Add(this.appointmentNameValue);
            this.Controls.Add(this.appointmentNameLabel);
            this.Name = "AppointmentInformationForm";
            this.Text = "Appointment Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appointmentNameLabel;
        private System.Windows.Forms.Label appointmentNameValue;
        private System.Windows.Forms.Label appointmentDescriptionLabel;
        private System.Windows.Forms.RichTextBox appointmentDescriptionRichTextBox;
        private System.Windows.Forms.Label appointmentStartDateLabel;
        private System.Windows.Forms.Label appointmentStartDateValue;
        private System.Windows.Forms.Label appointmentEndDateLabel;
        private System.Windows.Forms.Label appointmentEndDateValue;
    }
}