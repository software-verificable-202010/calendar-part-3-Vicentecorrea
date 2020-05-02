namespace CalendarApp.Views
{
    partial class CreateEventForm
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
            this.eventNameTextBox = new System.Windows.Forms.TextBox();
            this.eventNameLabel = new System.Windows.Forms.Label();
            this.eventDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.eventDescriptionLabel = new System.Windows.Forms.Label();
            this.eventStartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.eventStartDateLabel = new System.Windows.Forms.Label();
            this.eventEndDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.eventEndDateLabel = new System.Windows.Forms.Label();
            this.createEventButton = new System.Windows.Forms.Button();
            this.eventStartTimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.eventStartTimeLabel = new System.Windows.Forms.Label();
            this.eventEndTimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.eventEndTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventStartTimeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventEndTimeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // eventNameTextBox
            // 
            this.eventNameTextBox.Location = new System.Drawing.Point(193, 90);
            this.eventNameTextBox.Name = "eventNameTextBox";
            this.eventNameTextBox.Size = new System.Drawing.Size(203, 20);
            this.eventNameTextBox.TabIndex = 0;
            // 
            // eventNameLabel
            // 
            this.eventNameLabel.AutoSize = true;
            this.eventNameLabel.Location = new System.Drawing.Point(152, 97);
            this.eventNameLabel.Name = "eventNameLabel";
            this.eventNameLabel.Size = new System.Drawing.Size(35, 13);
            this.eventNameLabel.TabIndex = 1;
            this.eventNameLabel.Text = "Name";
            // 
            // eventDescriptionRichTextBox
            // 
            this.eventDescriptionRichTextBox.Location = new System.Drawing.Point(193, 116);
            this.eventDescriptionRichTextBox.Name = "eventDescriptionRichTextBox";
            this.eventDescriptionRichTextBox.Size = new System.Drawing.Size(203, 85);
            this.eventDescriptionRichTextBox.TabIndex = 2;
            this.eventDescriptionRichTextBox.Text = "";
            // 
            // eventDescriptionLabel
            // 
            this.eventDescriptionLabel.AutoSize = true;
            this.eventDescriptionLabel.Location = new System.Drawing.Point(127, 116);
            this.eventDescriptionLabel.Name = "eventDescriptionLabel";
            this.eventDescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.eventDescriptionLabel.TabIndex = 3;
            this.eventDescriptionLabel.Text = "Description";
            // 
            // eventStartDateDateTimePicker
            // 
            this.eventStartDateDateTimePicker.Location = new System.Drawing.Point(193, 207);
            this.eventStartDateDateTimePicker.Name = "eventStartDateDateTimePicker";
            this.eventStartDateDateTimePicker.Size = new System.Drawing.Size(203, 20);
            this.eventStartDateDateTimePicker.TabIndex = 4;
            // 
            // eventStartDateLabel
            // 
            this.eventStartDateLabel.AutoSize = true;
            this.eventStartDateLabel.Location = new System.Drawing.Point(134, 207);
            this.eventStartDateLabel.Name = "eventStartDateLabel";
            this.eventStartDateLabel.Size = new System.Drawing.Size(53, 13);
            this.eventStartDateLabel.TabIndex = 5;
            this.eventStartDateLabel.Text = "Start date";
            // 
            // eventEndDateDateTimePicker
            // 
            this.eventEndDateDateTimePicker.Location = new System.Drawing.Point(193, 259);
            this.eventEndDateDateTimePicker.Name = "eventEndDateDateTimePicker";
            this.eventEndDateDateTimePicker.Size = new System.Drawing.Size(203, 20);
            this.eventEndDateDateTimePicker.TabIndex = 6;
            // 
            // eventEndDateLabel
            // 
            this.eventEndDateLabel.AutoSize = true;
            this.eventEndDateLabel.Location = new System.Drawing.Point(134, 259);
            this.eventEndDateLabel.Name = "eventEndDateLabel";
            this.eventEndDateLabel.Size = new System.Drawing.Size(50, 13);
            this.eventEndDateLabel.TabIndex = 7;
            this.eventEndDateLabel.Text = "End date";
            // 
            // createEventButton
            // 
            this.createEventButton.Location = new System.Drawing.Point(193, 311);
            this.createEventButton.Name = "createEventButton";
            this.createEventButton.Size = new System.Drawing.Size(132, 23);
            this.createEventButton.TabIndex = 8;
            this.createEventButton.Text = "Create event";
            this.createEventButton.UseVisualStyleBackColor = true;
            this.createEventButton.Click += new System.EventHandler(this.CreateEventButton_Click);
            // 
            // eventStartTimeNumericUpDown
            // 
            this.eventStartTimeNumericUpDown.Location = new System.Drawing.Point(193, 233);
            this.eventStartTimeNumericUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.eventStartTimeNumericUpDown.Name = "eventStartTimeNumericUpDown";
            this.eventStartTimeNumericUpDown.Size = new System.Drawing.Size(37, 20);
            this.eventStartTimeNumericUpDown.TabIndex = 9;
            // 
            // eventStartTimeLabel
            // 
            this.eventStartTimeLabel.AutoSize = true;
            this.eventStartTimeLabel.Location = new System.Drawing.Point(136, 233);
            this.eventStartTimeLabel.Name = "eventStartTimeLabel";
            this.eventStartTimeLabel.Size = new System.Drawing.Size(51, 13);
            this.eventStartTimeLabel.TabIndex = 10;
            this.eventStartTimeLabel.Text = "Start time";
            // 
            // eventEndTimeNumericUpDown
            // 
            this.eventEndTimeNumericUpDown.Location = new System.Drawing.Point(193, 285);
            this.eventEndTimeNumericUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.eventEndTimeNumericUpDown.Name = "eventEndTimeNumericUpDown";
            this.eventEndTimeNumericUpDown.Size = new System.Drawing.Size(37, 20);
            this.eventEndTimeNumericUpDown.TabIndex = 11;
            // 
            // eventEndTimeLabel
            // 
            this.eventEndTimeLabel.AutoSize = true;
            this.eventEndTimeLabel.Location = new System.Drawing.Point(136, 285);
            this.eventEndTimeLabel.Name = "eventEndTimeLabel";
            this.eventEndTimeLabel.Size = new System.Drawing.Size(48, 13);
            this.eventEndTimeLabel.TabIndex = 12;
            this.eventEndTimeLabel.Text = "End time";
            // 
            // CreateEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eventEndTimeLabel);
            this.Controls.Add(this.eventEndTimeNumericUpDown);
            this.Controls.Add(this.eventStartTimeLabel);
            this.Controls.Add(this.eventStartTimeNumericUpDown);
            this.Controls.Add(this.createEventButton);
            this.Controls.Add(this.eventEndDateLabel);
            this.Controls.Add(this.eventEndDateDateTimePicker);
            this.Controls.Add(this.eventStartDateLabel);
            this.Controls.Add(this.eventStartDateDateTimePicker);
            this.Controls.Add(this.eventDescriptionLabel);
            this.Controls.Add(this.eventDescriptionRichTextBox);
            this.Controls.Add(this.eventNameLabel);
            this.Controls.Add(this.eventNameTextBox);
            this.Name = "CreateEventForm";
            this.Text = "Create Event";
            ((System.ComponentModel.ISupportInitialize)(this.eventStartTimeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventEndTimeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox eventNameTextBox;
        private System.Windows.Forms.Label eventNameLabel;
        private System.Windows.Forms.RichTextBox eventDescriptionRichTextBox;
        private System.Windows.Forms.Label eventDescriptionLabel;
        private System.Windows.Forms.DateTimePicker eventStartDateDateTimePicker;
        private System.Windows.Forms.Label eventStartDateLabel;
        private System.Windows.Forms.DateTimePicker eventEndDateDateTimePicker;
        private System.Windows.Forms.Label eventEndDateLabel;
        private System.Windows.Forms.Button createEventButton;
        private System.Windows.Forms.NumericUpDown eventStartTimeNumericUpDown;
        private System.Windows.Forms.Label eventStartTimeLabel;
        private System.Windows.Forms.NumericUpDown eventEndTimeNumericUpDown;
        private System.Windows.Forms.Label eventEndTimeLabel;
    }
}