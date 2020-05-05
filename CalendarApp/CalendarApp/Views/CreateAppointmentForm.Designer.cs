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
            this.appointmentStartTimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.appointmentStartTimeLabel = new System.Windows.Forms.Label();
            this.appointmentEndTimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.appointmentEndTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentStartTimeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentEndTimeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentNameTextBox
            // 
            this.appointmentNameTextBox.Location = new System.Drawing.Point(193, 90);
            this.appointmentNameTextBox.Name = "appointmentNameTextBox";
            this.appointmentNameTextBox.Size = new System.Drawing.Size(203, 20);
            this.appointmentNameTextBox.TabIndex = 0;
            // 
            // appointmentNameLabel
            // 
            this.appointmentNameLabel.AutoSize = true;
            this.appointmentNameLabel.Location = new System.Drawing.Point(152, 97);
            this.appointmentNameLabel.Name = "appointmentNameLabel";
            this.appointmentNameLabel.Size = new System.Drawing.Size(35, 13);
            this.appointmentNameLabel.TabIndex = 1;
            this.appointmentNameLabel.Text = "Name";
            // 
            // appointmentDescriptionRichTextBox
            // 
            this.appointmentDescriptionRichTextBox.Location = new System.Drawing.Point(193, 116);
            this.appointmentDescriptionRichTextBox.Name = "appointmentDescriptionRichTextBox";
            this.appointmentDescriptionRichTextBox.Size = new System.Drawing.Size(203, 85);
            this.appointmentDescriptionRichTextBox.TabIndex = 2;
            this.appointmentDescriptionRichTextBox.Text = "";
            // 
            // appointmentDescriptionLabel
            // 
            this.appointmentDescriptionLabel.AutoSize = true;
            this.appointmentDescriptionLabel.Location = new System.Drawing.Point(127, 116);
            this.appointmentDescriptionLabel.Name = "appointmentDescriptionLabel";
            this.appointmentDescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.appointmentDescriptionLabel.TabIndex = 3;
            this.appointmentDescriptionLabel.Text = "Description";
            // 
            // appointmentStartDateDateTimePicker
            // 
            this.appointmentStartDateDateTimePicker.Location = new System.Drawing.Point(193, 207);
            this.appointmentStartDateDateTimePicker.Name = "appointmentStartDateDateTimePicker";
            this.appointmentStartDateDateTimePicker.Size = new System.Drawing.Size(203, 20);
            this.appointmentStartDateDateTimePicker.TabIndex = 4;
            // 
            // appointmentStartDateLabel
            // 
            this.appointmentStartDateLabel.AutoSize = true;
            this.appointmentStartDateLabel.Location = new System.Drawing.Point(134, 207);
            this.appointmentStartDateLabel.Name = "appointmentStartDateLabel";
            this.appointmentStartDateLabel.Size = new System.Drawing.Size(53, 13);
            this.appointmentStartDateLabel.TabIndex = 5;
            this.appointmentStartDateLabel.Text = "Start date";
            // 
            // appointmentEndDateDateTimePicker
            // 
            this.appointmentEndDateDateTimePicker.Location = new System.Drawing.Point(193, 259);
            this.appointmentEndDateDateTimePicker.Name = "appointmentEndDateDateTimePicker";
            this.appointmentEndDateDateTimePicker.Size = new System.Drawing.Size(203, 20);
            this.appointmentEndDateDateTimePicker.TabIndex = 6;
            // 
            // appointmentEndDateLabel
            // 
            this.appointmentEndDateLabel.AutoSize = true;
            this.appointmentEndDateLabel.Location = new System.Drawing.Point(134, 259);
            this.appointmentEndDateLabel.Name = "appointmentEndDateLabel";
            this.appointmentEndDateLabel.Size = new System.Drawing.Size(50, 13);
            this.appointmentEndDateLabel.TabIndex = 7;
            this.appointmentEndDateLabel.Text = "End date";
            // 
            // createappointmentButton
            // 
            this.createappointmentButton.Location = new System.Drawing.Point(193, 311);
            this.createappointmentButton.Name = "createappointmentButton";
            this.createappointmentButton.Size = new System.Drawing.Size(132, 23);
            this.createappointmentButton.TabIndex = 8;
            this.createappointmentButton.Text = "Create appointment";
            this.createappointmentButton.UseVisualStyleBackColor = true;
            this.createappointmentButton.Click += new System.EventHandler(this.CreateappointmentButton_Click);
            // 
            // appointmentStartTimeNumericUpDown
            // 
            this.appointmentStartTimeNumericUpDown.Location = new System.Drawing.Point(193, 233);
            this.appointmentStartTimeNumericUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.appointmentStartTimeNumericUpDown.Name = "appointmentStartTimeNumericUpDown";
            this.appointmentStartTimeNumericUpDown.Size = new System.Drawing.Size(37, 20);
            this.appointmentStartTimeNumericUpDown.TabIndex = 9;
            // 
            // appointmentStartTimeLabel
            // 
            this.appointmentStartTimeLabel.AutoSize = true;
            this.appointmentStartTimeLabel.Location = new System.Drawing.Point(136, 233);
            this.appointmentStartTimeLabel.Name = "appointmentStartTimeLabel";
            this.appointmentStartTimeLabel.Size = new System.Drawing.Size(51, 13);
            this.appointmentStartTimeLabel.TabIndex = 10;
            this.appointmentStartTimeLabel.Text = "Start time";
            // 
            // appointmentEndTimeNumericUpDown
            // 
            this.appointmentEndTimeNumericUpDown.Location = new System.Drawing.Point(193, 285);
            this.appointmentEndTimeNumericUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.appointmentEndTimeNumericUpDown.Name = "appointmentEndTimeNumericUpDown";
            this.appointmentEndTimeNumericUpDown.Size = new System.Drawing.Size(37, 20);
            this.appointmentEndTimeNumericUpDown.TabIndex = 11;
            // 
            // appointmentEndTimeLabel
            // 
            this.appointmentEndTimeLabel.AutoSize = true;
            this.appointmentEndTimeLabel.Location = new System.Drawing.Point(136, 285);
            this.appointmentEndTimeLabel.Name = "appointmentEndTimeLabel";
            this.appointmentEndTimeLabel.Size = new System.Drawing.Size(48, 13);
            this.appointmentEndTimeLabel.TabIndex = 12;
            this.appointmentEndTimeLabel.Text = "End time";
            // 
            // CreateappointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.appointmentEndTimeLabel);
            this.Controls.Add(this.appointmentEndTimeNumericUpDown);
            this.Controls.Add(this.appointmentStartTimeLabel);
            this.Controls.Add(this.appointmentStartTimeNumericUpDown);
            this.Controls.Add(this.createappointmentButton);
            this.Controls.Add(this.appointmentEndDateLabel);
            this.Controls.Add(this.appointmentEndDateDateTimePicker);
            this.Controls.Add(this.appointmentStartDateLabel);
            this.Controls.Add(this.appointmentStartDateDateTimePicker);
            this.Controls.Add(this.appointmentDescriptionLabel);
            this.Controls.Add(this.appointmentDescriptionRichTextBox);
            this.Controls.Add(this.appointmentNameLabel);
            this.Controls.Add(this.appointmentNameTextBox);
            this.Name = "CreateappointmentForm";
            this.Text = "Create appointment";
            ((System.ComponentModel.ISupportInitialize)(this.appointmentStartTimeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentEndTimeNumericUpDown)).EndInit();
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
        private System.Windows.Forms.NumericUpDown appointmentStartTimeNumericUpDown;
        private System.Windows.Forms.Label appointmentStartTimeLabel;
        private System.Windows.Forms.NumericUpDown appointmentEndTimeNumericUpDown;
        private System.Windows.Forms.Label appointmentEndTimeLabel;
    }
}