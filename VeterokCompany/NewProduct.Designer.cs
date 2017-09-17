namespace VeterokCompany
{
    partial class NewProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.addOrUpdateProductGroupBox = new System.Windows.Forms.GroupBox();
            this.codeProductNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.coastNumeric = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameProductTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.productDataGrid = new System.Windows.Forms.DataGridView();
            this.addNewProductButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.validMessageLabel = new System.Windows.Forms.Label();
            this.addOrUpdateProductGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeProductNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coastNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addOrUpdateProductGroupBox
            // 
            this.addOrUpdateProductGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addOrUpdateProductGroupBox.Controls.Add(this.codeProductNumericUpDown);
            this.addOrUpdateProductGroupBox.Controls.Add(this.label3);
            this.addOrUpdateProductGroupBox.Controls.Add(this.idLabel);
            this.addOrUpdateProductGroupBox.Controls.Add(this.coastNumeric);
            this.addOrUpdateProductGroupBox.Controls.Add(this.saveButton);
            this.addOrUpdateProductGroupBox.Controls.Add(this.label2);
            this.addOrUpdateProductGroupBox.Controls.Add(this.label1);
            this.addOrUpdateProductGroupBox.Controls.Add(this.nameProductTextBox);
            this.addOrUpdateProductGroupBox.Location = new System.Drawing.Point(336, 56);
            this.addOrUpdateProductGroupBox.Name = "addOrUpdateProductGroupBox";
            this.addOrUpdateProductGroupBox.Size = new System.Drawing.Size(324, 192);
            this.addOrUpdateProductGroupBox.TabIndex = 1;
            this.addOrUpdateProductGroupBox.TabStop = false;
            this.addOrUpdateProductGroupBox.Text = "Редактировать";
            this.addOrUpdateProductGroupBox.Visible = false;
            // 
            // codeProductNumericUpDown
            // 
            this.codeProductNumericUpDown.Location = new System.Drawing.Point(147, 32);
            this.codeProductNumericUpDown.Name = "codeProductNumericUpDown";
            this.codeProductNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.codeProductNumericUpDown.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(16, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Код*";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(144, 16);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(52, 13);
            this.idLabel.TabIndex = 6;
            this.idLabel.Text = "idProduct";
            this.idLabel.Visible = false;
            // 
            // coastNumeric
            // 
            this.coastNumeric.DecimalPlaces = 2;
            this.coastNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.coastNumeric.Location = new System.Drawing.Point(147, 111);
            this.coastNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.coastNumeric.Name = "coastNumeric";
            this.coastNumeric.Size = new System.Drawing.Size(120, 20);
            this.coastNumeric.TabIndex = 10;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(95, 147);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(143, 35);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(16, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Стоимость";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(16, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наименование*";
            // 
            // nameProductTextBox
            // 
            this.nameProductTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameProductTextBox.Location = new System.Drawing.Point(147, 66);
            this.nameProductTextBox.Name = "nameProductTextBox";
            this.nameProductTextBox.Size = new System.Drawing.Size(170, 23);
            this.nameProductTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(13, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Категория";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Блюдо",
            "Лавка"});
            this.categoryComboBox.Location = new System.Drawing.Point(142, 13);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(183, 28);
            this.categoryComboBox.TabIndex = 6;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // productDataGrid
            // 
            this.productDataGrid.AllowUserToAddRows = false;
            this.productDataGrid.AllowUserToDeleteRows = false;
            this.productDataGrid.AllowUserToResizeColumns = false;
            this.productDataGrid.AllowUserToResizeRows = false;
            this.productDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.productDataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.productDataGrid.EnableHeadersVisualStyles = false;
            this.productDataGrid.Location = new System.Drawing.Point(17, 56);
            this.productDataGrid.MultiSelect = false;
            this.productDataGrid.Name = "productDataGrid";
            this.productDataGrid.ReadOnly = true;
            this.productDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.productDataGrid.RowHeadersVisible = false;
            this.productDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.productDataGrid.RowTemplate.Height = 26;
            this.productDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDataGrid.Size = new System.Drawing.Size(308, 458);
            this.productDataGrid.TabIndex = 7;
            this.productDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDataGrid_CellClick);
            // 
            // addNewProductButton
            // 
            this.addNewProductButton.Location = new System.Drawing.Point(358, 13);
            this.addNewProductButton.Name = "addNewProductButton";
            this.addNewProductButton.Size = new System.Drawing.Size(122, 37);
            this.addNewProductButton.TabIndex = 11;
            this.addNewProductButton.Text = "Добавить";
            this.addNewProductButton.UseVisualStyleBackColor = true;
            this.addNewProductButton.Click += new System.EventHandler(this.addNewProductButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(545, 13);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(115, 37);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // validMessageLabel
            // 
            this.validMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.validMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.validMessageLabel.Location = new System.Drawing.Point(336, 275);
            this.validMessageLabel.Name = "validMessageLabel";
            this.validMessageLabel.Size = new System.Drawing.Size(324, 59);
            this.validMessageLabel.TabIndex = 10;
            this.validMessageLabel.Text = "Валидация";
            // 
            // NewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 526);
            this.Controls.Add(this.validMessageLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addNewProductButton);
            this.Controls.Add(this.productDataGrid);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addOrUpdateProductGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товар";
            this.addOrUpdateProductGroupBox.ResumeLayout(false);
            this.addOrUpdateProductGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeProductNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coastNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox addOrUpdateProductGroupBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameProductTextBox;
        private System.Windows.Forms.NumericUpDown coastNumeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.DataGridView productDataGrid;
        private System.Windows.Forms.Button addNewProductButton;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label validMessageLabel;
        private System.Windows.Forms.NumericUpDown codeProductNumericUpDown;
        private System.Windows.Forms.Label label3;
    }
}