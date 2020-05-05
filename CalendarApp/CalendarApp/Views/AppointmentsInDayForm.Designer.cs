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
            this.appointmentsListBox = new System.Windows.Forms.ListBox();
            this.appointmentSelectionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // appointmentsListBox
            // 
            this.appointmentsListBox.FormattingEnabled = true;
            this.appointmentsListBox.Location = new System.Drawing.Point(12, 50);
            this.appointmentsListBox.Name = "appointmentsListBox";
            this.appointmentsListBox.Size = new System.Drawing.Size(273, 238);
            this.appointmentsListBox.TabIndex = 0;
            this.appointmentsListBox.SelectedIndexChanged += new System.EventHandler(this.appointmentslistBox_SelectedIndexChanged);
            // 
            // appointmentSelectionLabel
            // 
            this.appointmentSelectionLabel.AutoSize = true;
            this.appointmentSelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.appointmentSelectionLabel.Location = new System.Drawing.Point(9, 19);
            this.appointmentSelectionLabel.Name = "appointmentSelectionLabel";
            this.appointmentSelectionLabel.Size = new System.Drawing.Size(276, 18);
            this.appointmentSelectionLabel.TabIndex = 1;
            this.appointmentSelectionLabel.Text = "Select one of the events of December 20";
            // 
            // AppointmentsInDayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 301);
            this.Controls.Add(this.appointmentSelectionLabel);
            this.Controls.Add(this.appointmentsListBox);
            this.Name = "AppointmentsInDayForm";
            this.Text = "Appointments in selected time period";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox appointmentsListBox;
        private System.Windows.Forms.Label appointmentSelectionLabel;
    }
}