namespace VeterokCompany
{
    partial class AddIngredients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ingredientDataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.addOrUpdateGroupBox = new System.Windows.Forms.GroupBox();
            this.quantitiesComboBox = new System.Windows.Forms.ComboBox();
            this.countNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.codeSearchIngredientNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.idIngredientLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientDataGridView)).BeginInit();
            this.addOrUpdateGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeSearchIngredientNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ingredientDataGridView
            // 
            this.ingredientDataGridView.AllowUserToAddRows = false;
            this.ingredientDataGridView.AllowUserToDeleteRows = false;
            this.ingredientDataGridView.AllowUserToResizeColumns = false;
            this.ingredientDataGridView.AllowUserToResizeRows = false;
            this.ingredientDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ingredientDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ingredientDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ingredientDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ingredientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ingredientDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.ingredientDataGridView.EnableHeadersVisualStyles = false;
            this.ingredientDataGridView.Location = new System.Drawing.Point(12, 41);
            this.ingredientDataGridView.MultiSelect = false;
            this.ingredientDataGridView.Name = "ingredientDataGridView";
            this.ingredientDataGridView.ReadOnly = true;
            this.ingredientDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ingredientDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.ingredientDataGridView.RowHeadersVisible = false;
            this.ingredientDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ingredientDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.ingredientDataGridView.RowTemplate.Height = 26;
            this.ingredientDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ingredientDataGridView.Size = new System.Drawing.Size(518, 535);
            this.ingredientDataGridView.TabIndex = 11;
            this.ingredientDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ingredientDataGridView_CellMouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(46, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(415, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Доступно ингридиентов на складе";
            // 
            // addOrUpdateGroupBox
            // 
            this.addOrUpdateGroupBox.Controls.Add(this.quantitiesComboBox);
            this.addOrUpdateGroupBox.Controls.Add(this.countNumericUpDown);
            this.addOrUpdateGroupBox.Controls.Add(this.label4);
            this.addOrUpdateGroupBox.Controls.Add(this.nameTextBox);
            this.addOrUpdateGroupBox.Controls.Add(this.label5);
            this.addOrUpdateGroupBox.Controls.Add(this.saveButton);
            this.addOrUpdateGroupBox.Location = new System.Drawing.Point(536, 95);
            this.addOrUpdateGroupBox.Name = "addOrUpdateGroupBox";
            this.addOrUpdateGroupBox.Size = new System.Drawing.Size(289, 161);
            this.addOrUpdateGroupBox.TabIndex = 15;
            this.addOrUpdateGroupBox.TabStop = false;
            this.addOrUpdateGroupBox.Text = "Добавить новую покупку ингридиента";
            // 
            // quantitiesComboBox
            // 
            this.quantitiesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quantitiesComboBox.Enabled = false;
            this.quantitiesComboBox.FormattingEnabled = true;
            this.quantitiesComboBox.Location = new System.Drawing.Point(220, 76);
            this.quantitiesComboBox.Name = "quantitiesComboBox";
            this.quantitiesComboBox.Size = new System.Drawing.Size(63, 21);
            this.quantitiesComboBox.TabIndex = 21;
            // 
            // countNumericUpDown
            // 
            this.countNumericUpDown.DecimalPlaces = 2;
            this.countNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.countNumericUpDown.Location = new System.Drawing.Point(124, 76);
            this.countNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.countNumericUpDown.Name = "countNumericUpDown";
            this.countNumericUpDown.Size = new System.Drawing.Size(88, 20);
            this.countNumericUpDown.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(6, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Количество";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameTextBox.Location = new System.Drawing.Point(124, 31);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(159, 23);
            this.nameTextBox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(6, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Наименование*";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(83, 114);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(129, 41);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Добавить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(754, 40);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(68, 21);
            this.searchButton.TabIndex = 28;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // codeSearchIngredientNumericUpDown
            // 
            this.codeSearchIngredientNumericUpDown.Location = new System.Drawing.Point(660, 41);
            this.codeSearchIngredientNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.codeSearchIngredientNumericUpDown.Name = "codeSearchIngredientNumericUpDown";
            this.codeSearchIngredientNumericUpDown.Size = new System.Drawing.Size(88, 20);
            this.codeSearchIngredientNumericUpDown.TabIndex = 27;
            this.codeSearchIngredientNumericUpDown.KeyUp += new System.Windows.Forms.KeyEventHandler(this.codeSearchIngredientNumericUpDown_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(543, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Поиск по коду";
            // 
            // idIngredientLabel
            // 
            this.idIngredientLabel.AutoSize = true;
            this.idIngredientLabel.Location = new System.Drawing.Point(543, 68);
            this.idIngredientLabel.Name = "idIngredientLabel";
            this.idIngredientLabel.Size = new System.Drawing.Size(62, 13);
            this.idIngredientLabel.TabIndex = 29;
            this.idIngredientLabel.Text = "idIngredient";
            this.idIngredientLabel.Visible = false;
            // 
            // AddIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 588);
            this.Controls.Add(this.idIngredientLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.codeSearchIngredientNumericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addOrUpdateGroupBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ingredientDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddIngredients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склад ингридиентов";
            ((System.ComponentModel.ISupportInitialize)(this.ingredientDataGridView)).EndInit();
            this.addOrUpdateGroupBox.ResumeLayout(false);
            this.addOrUpdateGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeSearchIngredientNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ingredientDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox addOrUpdateGroupBox;
        private System.Windows.Forms.ComboBox quantitiesComboBox;
        private System.Windows.Forms.NumericUpDown countNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.NumericUpDown codeSearchIngredientNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label idIngredientLabel;
    }
}