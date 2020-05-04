namespace CalendarApp
{
    partial class CalendarForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.calendarGridView = new System.Windows.Forms.DataGridView();
            this.MondayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuesdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WednesdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThursdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FridayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaturdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SundayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.previousTimePeriodButton = new System.Windows.Forms.Button();
            this.nextTimePeriodButton = new System.Windows.Forms.Button();
            this.todayButton = new System.Windows.Forms.Button();
            this.monthLabel = new System.Windows.Forms.Label();
            this.goToCreateEventFormButton = new System.Windows.Forms.Button();
            this.calendarDisplayMenuListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.calendarGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // calendarGridView
            // 
            this.calendarGridView.AllowUserToAddRows = false;
            this.calendarGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calendarGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MondayColumn,
            this.TuesdayColumn,
            this.WednesdayColumn,
            this.ThursdayColumn,
            this.FridayColumn,
            this.SaturdayColumn,
            this.SundayColumn});
            this.calendarGridView.Location = new System.Drawing.Point(12, 91);
            this.calendarGridView.Name = "calendarGridView";
            this.calendarGridView.Size = new System.Drawing.Size(886, 384);
            this.calendarGridView.TabIndex = 1;
            // 
            // MondayColumn
            // 
            this.MondayColumn.HeaderText = "Monday";
            this.MondayColumn.Name = "MondayColumn";
            // 
            // TuesdayColumn
            // 
            this.TuesdayColumn.HeaderText = "Tuesday";
            this.TuesdayColumn.Name = "TuesdayColumn";
            // 
            // WednesdayColumn
            // 
            this.WednesdayColumn.HeaderText = "Wednesday";
            this.WednesdayColumn.Name = "WednesdayColumn";
            // 
            // ThursdayColumn
            // 
            this.ThursdayColumn.HeaderText = "Thursday";
            this.ThursdayColumn.Name = "ThursdayColumn";
            // 
            // FridayColumn
            // 
            this.FridayColumn.HeaderText = "Friday";
            this.FridayColumn.Name = "FridayColumn";
            // 
            // SaturdayColumn
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SaturdayColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.SaturdayColumn.HeaderText = "Saturday";
            this.SaturdayColumn.Name = "SaturdayColumn";
            // 
            // SundayColumn
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SundayColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.SundayColumn.HeaderText = "Sunday";
            this.SundayColumn.Name = "SundayColumn";
            // 
            // previousTimePeriodButton
            // 
            this.previousTimePeriodButton.Location = new System.Drawing.Point(12, 40);
            this.previousTimePeriodButton.Name = "previousTimePeriodButton";
            this.previousTimePeriodButton.Size = new System.Drawing.Size(101, 23);
            this.previousTimePeriodButton.TabIndex = 2;
            this.previousTimePeriodButton.Text = "previous";
            this.previousTimePeriodButton.UseVisualStyleBackColor = true;
            this.previousTimePeriodButton.Click += new System.EventHandler(this.PreviousTimePeriodButton_Click);
            // 
            // nextTimePeriodButton
            // 
            this.nextTimePeriodButton.Location = new System.Drawing.Point(119, 40);
            this.nextTimePeriodButton.Name = "nextTimePeriodButton";
            this.nextTimePeriodButton.Size = new System.Drawing.Size(101, 23);
            this.nextTimePeriodButton.TabIndex = 3;
            this.nextTimePeriodButton.Text = "next";
            this.nextTimePeriodButton.UseVisualStyleBackColor = true;
            this.nextTimePeriodButton.Click += new System.EventHandler(this.NextTimePeriodButton_Click);
            // 
            // todayButton
            // 
            this.todayButton.Location = new System.Drawing.Point(286, 40);
            this.todayButton.Name = "todayButton";
            this.todayButton.Size = new System.Drawing.Size(75, 23);
            this.todayButton.TabIndex = 4;
            this.todayButton.Text = "today";
            this.todayButton.UseVisualStyleBackColor = true;
            this.todayButton.Click += new System.EventHandler(this.TodayButton_Click);
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthLabel.Location = new System.Drawing.Point(389, 9);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(107, 25);
            this.monthLabel.TabIndex = 5;
            this.monthLabel.Text = "dateLabel";
            // 
            // goToCreateEventFormButton
            // 
            this.goToCreateEventFormButton.Location = new System.Drawing.Point(597, 40);
            this.goToCreateEventFormButton.Name = "goToCreateEventFormButton";
            this.goToCreateEventFormButton.Size = new System.Drawing.Size(75, 23);
            this.goToCreateEventFormButton.TabIndex = 6;
            this.goToCreateEventFormButton.Text = "create event";
            this.goToCreateEventFormButton.UseVisualStyleBackColor = true;
            this.goToCreateEventFormButton.Click += new System.EventHandler(this.GoToCreateEventFormButton_Click);
            // 
            // calendarDisplayMenuListBox
            // 
            this.calendarDisplayMenuListBox.FormattingEnabled = true;
            this.calendarDisplayMenuListBox.Items.AddRange(new object[] {
            "Month",
            "Week"});
            this.calendarDisplayMenuListBox.Location = new System.Drawing.Point(778, 40);
            this.calendarDisplayMenuListBox.Name = "calendarDisplayMenuListBox";
            this.calendarDisplayMenuListBox.Size = new System.Drawing.Size(120, 30);
            this.calendarDisplayMenuListBox.TabIndex = 7;
            this.calendarDisplayMenuListBox.SelectedItem = "Month";
            this.calendarDisplayMenuListBox.SelectedIndexChanged += new System.EventHandler(this.CalendarDisplayMenuListBox_SelectedIndexChanged);
            // 
            // CalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 549);
            this.Controls.Add(this.calendarDisplayMenuListBox);
            this.Controls.Add(this.goToCreateEventFormButton);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.todayButton);
            this.Controls.Add(this.nextTimePeriodButton);
            this.Controls.Add(this.previousTimePeriodButton);
            this.Controls.Add(this.calendarGridView);
            this.Name = "CalendarForm";
            this.Text = "Calendar";
            ((System.ComponentModel.ISupportInitialize)(this.calendarGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView calendarGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn MondayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuesdayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WednesdayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThursdayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FridayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaturdayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SundayColumn;
        private System.Windows.Forms.Button previousTimePeriodButton;
        private System.Windows.Forms.Button nextTimePeriodButton;
        private System.Windows.Forms.Button todayButton;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Button goToCreateEventFormButton;
        private System.Windows.Forms.ListBox calendarDisplayMenuListBox;
    }
}

