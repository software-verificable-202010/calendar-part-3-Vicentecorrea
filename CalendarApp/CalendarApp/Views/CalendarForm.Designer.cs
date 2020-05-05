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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.calendarGridView = new System.Windows.Forms.DataGridView();
            this.previousTimePeriodButton = new System.Windows.Forms.Button();
            this.nextTimePeriodButton = new System.Windows.Forms.Button();
            this.todayButton = new System.Windows.Forms.Button();
            this.monthLabel = new System.Windows.Forms.Label();
            this.goToCreateAppointmentFormButton = new System.Windows.Forms.Button();
            this.calendarDisplayMenuListBox = new System.Windows.Forms.ListBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.MondayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuesdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WednesdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThursdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FridayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaturdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SundayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.calendarGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.calendarGridView.Location = new System.Drawing.Point(12, 91);
            this.calendarGridView.Name = "calendarGridView";
            this.calendarGridView.Size = new System.Drawing.Size(886, 384);
            this.calendarGridView.TabIndex = 1;
            this.calendarGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CalendarGridView_CellContentClick);
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
            // goToCreateAppointmentFormButton
            // 
            this.goToCreateAppointmentFormButton.Location = new System.Drawing.Point(597, 40);
            this.goToCreateAppointmentFormButton.Name = "goToCreateAppointmentFormButton";
            this.goToCreateAppointmentFormButton.Size = new System.Drawing.Size(110, 23);
            this.goToCreateAppointmentFormButton.TabIndex = 6;
            this.goToCreateAppointmentFormButton.Text = "create appointment";
            this.goToCreateAppointmentFormButton.UseVisualStyleBackColor = true;
            this.goToCreateAppointmentFormButton.Click += new System.EventHandler(this.GoToCreateAppointmentFormButton_Click);
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
            this.calendarDisplayMenuListBox.SelectedIndexChanged += new System.EventHandler(this.CalendarDisplayMenuListBox_SelectedIndexChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(0, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(100, 23);
            this.linkLabel1.TabIndex = 0;
            // 
            // MondayColumn
            // 
            this.MondayColumn.HeaderText = "Monday";
            this.MondayColumn.Name = "MondayColumn";
            this.MondayColumn.ReadOnly = true;
            this.MondayColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TuesdayColumn
            // 
            this.TuesdayColumn.HeaderText = "Tuesday";
            this.TuesdayColumn.Name = "TuesdayColumn";
            this.TuesdayColumn.ReadOnly = true;
            this.TuesdayColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // WednesdayColumn
            // 
            this.WednesdayColumn.HeaderText = "Wednesday";
            this.WednesdayColumn.Name = "WednesdayColumn";
            this.WednesdayColumn.ReadOnly = true;
            this.WednesdayColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ThursdayColumn
            // 
            this.ThursdayColumn.HeaderText = "Thursday";
            this.ThursdayColumn.Name = "ThursdayColumn";
            this.ThursdayColumn.ReadOnly = true;
            this.ThursdayColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FridayColumn
            // 
            this.FridayColumn.HeaderText = "Friday";
            this.FridayColumn.Name = "FridayColumn";
            this.FridayColumn.ReadOnly = true;
            this.FridayColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SaturdayColumn
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SaturdayColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.SaturdayColumn.HeaderText = "Saturday";
            this.SaturdayColumn.Name = "SaturdayColumn";
            this.SaturdayColumn.ReadOnly = true;
            this.SaturdayColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SundayColumn
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SundayColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.SundayColumn.HeaderText = "Sunday";
            this.SundayColumn.Name = "SundayColumn";
            this.SundayColumn.ReadOnly = true;
            this.SundayColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 549);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.calendarDisplayMenuListBox);
            this.Controls.Add(this.goToCreateAppointmentFormButton);
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
        private System.Windows.Forms.Button previousTimePeriodButton;
        private System.Windows.Forms.Button nextTimePeriodButton;
        private System.Windows.Forms.Button todayButton;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Button goToCreateAppointmentFormButton;
        private System.Windows.Forms.ListBox calendarDisplayMenuListBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MondayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuesdayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WednesdayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThursdayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FridayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaturdayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SundayColumn;
    }
}

