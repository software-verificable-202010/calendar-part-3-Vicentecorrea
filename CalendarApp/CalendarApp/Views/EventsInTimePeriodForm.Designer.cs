﻿namespace CalendarApp.Views
{
    partial class EventsInTimePeriodForm
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
            this.eventsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // eventsListBox
            // 
            this.eventsListBox.FormattingEnabled = true;
            this.eventsListBox.Location = new System.Drawing.Point(12, 12);
            this.eventsListBox.Name = "eventsListBox";
            this.eventsListBox.Size = new System.Drawing.Size(264, 290);
            this.eventsListBox.TabIndex = 0;
            this.eventsListBox.SelectedIndexChanged += new System.EventHandler(this.EventslistBox_SelectedIndexChanged);
            // 
            // EventsInTimePeriodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 316);
            this.Controls.Add(this.eventsListBox);
            this.Name = "EventsInTimePeriodForm";
            this.Text = "Events in selected time period";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox eventsListBox;
    }
}