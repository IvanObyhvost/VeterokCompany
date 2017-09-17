namespace VeterokCompany
{
    partial class StatisticSale
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.workProductDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.statisticDayGroupBox = new System.Windows.Forms.GroupBox();
            this.dayCalendar = new System.Windows.Forms.MonthCalendar();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dayRadioButton = new System.Windows.Forms.RadioButton();
            this.periodRadioButton = new System.Windows.Forms.RadioButton();
            this.statisticPeriodGroupBox = new System.Windows.Forms.GroupBox();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.showStatisticButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.incomeLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.workProductDataGridView)).BeginInit();
            this.statisticDayGroupBox.SuspendLayout();
            this.statisticPeriodGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // workProductDataGridView
            // 
            this.workProductDataGridView.AllowUserToAddRows = false;
            this.workProductDataGridView.AllowUserToDeleteRows = false;
            this.workProductDataGridView.AllowUserToResizeColumns = false;
            this.workProductDataGridView.AllowUserToResizeRows = false;
            this.workProductDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workProductDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.workProductDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.workProductDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.workProductDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.workProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.workProductDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.workProductDataGridView.EnableHeadersVisualStyles = false;
            this.workProductDataGridView.Location = new System.Drawing.Point(206, 12);
            this.workProductDataGridView.MultiSelect = false;
            this.workProductDataGridView.Name = "workProductDataGridView";
            this.workProductDataGridView.ReadOnly = true;
            this.workProductDataGridView.RowHeadersVisible = false;
            this.workProductDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.workProductDataGridView.RowTemplate.Height = 26;
            this.workProductDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.workProductDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.workProductDataGridView.Size = new System.Drawing.Size(850, 453);
            this.workProductDataGridView.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Статистика за ";
            // 
            // statisticDayGroupBox
            // 
            this.statisticDayGroupBox.Controls.Add(this.dayCalendar);
            this.statisticDayGroupBox.Location = new System.Drawing.Point(12, 78);
            this.statisticDayGroupBox.Name = "statisticDayGroupBox";
            this.statisticDayGroupBox.Size = new System.Drawing.Size(188, 202);
            this.statisticDayGroupBox.TabIndex = 6;
            this.statisticDayGroupBox.TabStop = false;
            this.statisticDayGroupBox.Text = "Статистика за день";
            // 
            // dayCalendar
            // 
            this.dayCalendar.Location = new System.Drawing.Point(12, 25);
            this.dayCalendar.Name = "dayCalendar";
            this.dayCalendar.ShowTodayCircle = false;
            this.dayCalendar.TabIndex = 1;
            this.dayCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.dayCalendar_DateSelected);
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.startDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.startDateTimePicker.Location = new System.Drawing.Point(17, 46);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(154, 23);
            this.startDateTimePicker.TabIndex = 7;
            // 
            // dayRadioButton
            // 
            this.dayRadioButton.AutoSize = true;
            this.dayRadioButton.Checked = true;
            this.dayRadioButton.Location = new System.Drawing.Point(125, 21);
            this.dayRadioButton.Name = "dayRadioButton";
            this.dayRadioButton.Size = new System.Drawing.Size(49, 17);
            this.dayRadioButton.TabIndex = 8;
            this.dayRadioButton.TabStop = true;
            this.dayRadioButton.Text = "день";
            this.dayRadioButton.UseVisualStyleBackColor = true;
            this.dayRadioButton.Click += new System.EventHandler(this.dayRadioButton_Click);
            // 
            // periodRadioButton
            // 
            this.periodRadioButton.AutoSize = true;
            this.periodRadioButton.Location = new System.Drawing.Point(125, 44);
            this.periodRadioButton.Name = "periodRadioButton";
            this.periodRadioButton.Size = new System.Drawing.Size(61, 17);
            this.periodRadioButton.TabIndex = 9;
            this.periodRadioButton.Text = "период";
            this.periodRadioButton.UseVisualStyleBackColor = true;
            this.periodRadioButton.Click += new System.EventHandler(this.periodRadioButton_Click);
            // 
            // statisticPeriodGroupBox
            // 
            this.statisticPeriodGroupBox.Controls.Add(this.endDateTimePicker);
            this.statisticPeriodGroupBox.Controls.Add(this.showStatisticButton);
            this.statisticPeriodGroupBox.Controls.Add(this.label3);
            this.statisticPeriodGroupBox.Controls.Add(this.label2);
            this.statisticPeriodGroupBox.Controls.Add(this.startDateTimePicker);
            this.statisticPeriodGroupBox.Location = new System.Drawing.Point(12, 78);
            this.statisticPeriodGroupBox.Name = "statisticPeriodGroupBox";
            this.statisticPeriodGroupBox.Size = new System.Drawing.Size(188, 202);
            this.statisticPeriodGroupBox.TabIndex = 10;
            this.statisticPeriodGroupBox.TabStop = false;
            this.statisticPeriodGroupBox.Text = "Статистика за период";
            this.statisticPeriodGroupBox.Visible = false;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.endDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.endDateTimePicker.Location = new System.Drawing.Point(17, 117);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(154, 23);
            this.endDateTimePicker.TabIndex = 12;
            // 
            // showStatisticButton
            // 
            this.showStatisticButton.Location = new System.Drawing.Point(73, 157);
            this.showStatisticButton.Name = "showStatisticButton";
            this.showStatisticButton.Size = new System.Drawing.Size(98, 30);
            this.showStatisticButton.TabIndex = 11;
            this.showStatisticButton.Text = "Показать";
            this.showStatisticButton.UseVisualStyleBackColor = true;
            this.showStatisticButton.Click += new System.EventHandler(this.showStatisticButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(14, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "По (включительно):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(14, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Начиная с (включительно):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.incomeLabel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 360);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 105);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Итого";
            // 
            // incomeLabel
            // 
            this.incomeLabel.AutoSize = true;
            this.incomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.incomeLabel.Location = new System.Drawing.Point(77, 22);
            this.incomeLabel.Name = "incomeLabel";
            this.incomeLabel.Size = new System.Drawing.Size(20, 24);
            this.incomeLabel.TabIndex = 1;
            this.incomeLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Доход:";
            // 
            // StatisticSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 477);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statisticPeriodGroupBox);
            this.Controls.Add(this.periodRadioButton);
            this.Controls.Add(this.dayRadioButton);
            this.Controls.Add(this.statisticDayGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.workProductDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StatisticSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика продаж";
            ((System.ComponentModel.ISupportInitialize)(this.workProductDataGridView)).EndInit();
            this.statisticDayGroupBox.ResumeLayout(false);
            this.statisticPeriodGroupBox.ResumeLayout(false);
            this.statisticPeriodGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView workProductDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox statisticDayGroupBox;
        private System.Windows.Forms.MonthCalendar dayCalendar;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.RadioButton dayRadioButton;
        private System.Windows.Forms.RadioButton periodRadioButton;
        private System.Windows.Forms.GroupBox statisticPeriodGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button showStatisticButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label incomeLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
    }
}