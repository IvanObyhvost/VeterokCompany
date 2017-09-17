namespace VeterokCompany
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.codeViewButton = new System.Windows.Forms.Button();
            this.addIngredientsButton = new System.Windows.Forms.Button();
            this.getSaleStatisticButton = new System.Windows.Forms.Button();
            this.ingredientButton = new System.Windows.Forms.Button();
            this.categoryButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameProductTextBox = new System.Windows.Forms.TextBox();
            this.countProductComboBox = new System.Windows.Forms.ComboBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.idProductLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.codeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.codeProductLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.incomeLabel = new System.Windows.Forms.Label();
            this.saleProductButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeNumericUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // codeViewButton
            // 
            this.codeViewButton.Location = new System.Drawing.Point(400, 59);
            this.codeViewButton.Name = "codeViewButton";
            this.codeViewButton.Size = new System.Drawing.Size(185, 34);
            this.codeViewButton.TabIndex = 8;
            this.codeViewButton.Text = "Коды товаров/ингридиентов";
            this.codeViewButton.UseVisualStyleBackColor = true;
            this.codeViewButton.Click += new System.EventHandler(this.codeViewButton_Click);
            // 
            // addIngredientsButton
            // 
            this.addIngredientsButton.Location = new System.Drawing.Point(203, 59);
            this.addIngredientsButton.Name = "addIngredientsButton";
            this.addIngredientsButton.Size = new System.Drawing.Size(185, 34);
            this.addIngredientsButton.TabIndex = 7;
            this.addIngredientsButton.Text = "Склад ингридиентов";
            this.addIngredientsButton.UseVisualStyleBackColor = true;
            this.addIngredientsButton.Click += new System.EventHandler(this.addIngredientsButton_Click);
            // 
            // getSaleStatisticButton
            // 
            this.getSaleStatisticButton.Location = new System.Drawing.Point(12, 59);
            this.getSaleStatisticButton.Name = "getSaleStatisticButton";
            this.getSaleStatisticButton.Size = new System.Drawing.Size(185, 34);
            this.getSaleStatisticButton.TabIndex = 6;
            this.getSaleStatisticButton.Text = "Статистика продаж";
            this.getSaleStatisticButton.UseVisualStyleBackColor = true;
            this.getSaleStatisticButton.Click += new System.EventHandler(this.getSaleStatisticButton_Click);
            // 
            // ingredientButton
            // 
            this.ingredientButton.Location = new System.Drawing.Point(257, 19);
            this.ingredientButton.Name = "ingredientButton";
            this.ingredientButton.Size = new System.Drawing.Size(113, 34);
            this.ingredientButton.TabIndex = 5;
            this.ingredientButton.Text = "Ингридиенты";
            this.ingredientButton.UseVisualStyleBackColor = true;
            this.ingredientButton.Click += new System.EventHandler(this.ingredientButton_Click);
            // 
            // categoryButton
            // 
            this.categoryButton.Location = new System.Drawing.Point(12, 19);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(113, 34);
            this.categoryButton.TabIndex = 4;
            this.categoryButton.Text = "Категория";
            this.categoryButton.UseVisualStyleBackColor = true;
            this.categoryButton.Click += new System.EventHandler(this.categoryButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Товар";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(13, 76);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1052, 369);
            this.dataGridView1.TabIndex = 2;
            // 
            // nameProductTextBox
            // 
            this.nameProductTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameProductTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.nameProductTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.nameProductTextBox.Location = new System.Drawing.Point(297, 22);
            this.nameProductTextBox.Multiline = true;
            this.nameProductTextBox.Name = "nameProductTextBox";
            this.nameProductTextBox.ReadOnly = true;
            this.nameProductTextBox.Size = new System.Drawing.Size(477, 35);
            this.nameProductTextBox.TabIndex = 5;
            // 
            // countProductComboBox
            // 
            this.countProductComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.countProductComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.countProductComboBox.FormattingEnabled = true;
            this.countProductComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.countProductComboBox.Location = new System.Drawing.Point(867, 20);
            this.countProductComboBox.Name = "countProductComboBox";
            this.countProductComboBox.Size = new System.Drawing.Size(71, 37);
            this.countProductComboBox.TabIndex = 7;
            // 
            // costTextBox
            // 
            this.costTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.costTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.costTextBox.Location = new System.Drawing.Point(780, 21);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(81, 36);
            this.costTextBox.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.codeNumericUpDown);
            this.groupBox2.Controls.Add(this.searchButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.codeProductLabel);
            this.groupBox2.Controls.Add(this.idProductLabel);
            this.groupBox2.Controls.Add(this.countProductComboBox);
            this.groupBox2.Controls.Add(this.saleProductButton);
            this.groupBox2.Controls.Add(this.costTextBox);
            this.groupBox2.Controls.Add(this.nameProductTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1053, 67);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Меню";
            // 
            // idProductLabel
            // 
            this.idProductLabel.AutoSize = true;
            this.idProductLabel.Location = new System.Drawing.Point(477, 6);
            this.idProductLabel.Name = "idProductLabel";
            this.idProductLabel.Size = new System.Drawing.Size(78, 13);
            this.idProductLabel.TabIndex = 11;
            this.idProductLabel.Text = "idProductLabel";
            this.idProductLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(0, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Код";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(180, 22);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(111, 35);
            this.searchButton.TabIndex = 15;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // codeNumericUpDown
            // 
            this.codeNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.codeNumericUpDown.InterceptArrowKeys = false;
            this.codeNumericUpDown.Location = new System.Drawing.Point(70, 23);
            this.codeNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.codeNumericUpDown.Name = "codeNumericUpDown";
            this.codeNumericUpDown.Size = new System.Drawing.Size(104, 32);
            this.codeNumericUpDown.TabIndex = 16;
            this.codeNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.codeNumericUpDown.KeyUp += new System.Windows.Forms.KeyEventHandler(this.codeNumericUpDown_KeyUp);
            // 
            // codeProductLabel
            // 
            this.codeProductLabel.AutoSize = true;
            this.codeProductLabel.Location = new System.Drawing.Point(368, 5);
            this.codeProductLabel.Name = "codeProductLabel";
            this.codeProductLabel.Size = new System.Drawing.Size(94, 13);
            this.codeProductLabel.TabIndex = 12;
            this.codeProductLabel.Text = "codeProductLabel";
            this.codeProductLabel.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.codeViewButton);
            this.groupBox3.Controls.Add(this.categoryButton);
            this.groupBox3.Controls.Add(this.addIngredientsButton);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.getSaleStatisticButton);
            this.groupBox3.Controls.Add(this.ingredientButton);
            this.groupBox3.Location = new System.Drawing.Point(7, 451);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(866, 100);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Действия";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.incomeLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(879, 451);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подсчеты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Доходы:";
            // 
            // incomeLabel
            // 
            this.incomeLabel.AutoSize = true;
            this.incomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.incomeLabel.Location = new System.Drawing.Point(89, 19);
            this.incomeLabel.Name = "incomeLabel";
            this.incomeLabel.Size = new System.Drawing.Size(24, 26);
            this.incomeLabel.TabIndex = 1;
            this.incomeLabel.Text = "0";
            // 
            // saleProductButton
            // 
            this.saleProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saleProductButton.Image = ((System.Drawing.Image)(resources.GetObject("saleProductButton.Image")));
            this.saleProductButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.saleProductButton.Location = new System.Drawing.Point(944, 21);
            this.saleProductButton.Name = "saleProductButton";
            this.saleProductButton.Size = new System.Drawing.Size(103, 36);
            this.saleProductButton.TabIndex = 3;
            this.saleProductButton.Text = "Продать";
            this.saleProductButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saleProductButton.UseVisualStyleBackColor = true;
            this.saleProductButton.Click += new System.EventHandler(this.saleProductButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 563);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Ветерок (моя бугалтерия)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeNumericUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.Button saleProductButton;
        private System.Windows.Forms.TextBox nameProductTextBox;
        private System.Windows.Forms.ComboBox countProductComboBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ingredientButton;
        private System.Windows.Forms.Button getSaleStatisticButton;
        private System.Windows.Forms.Button codeViewButton;
        private System.Windows.Forms.Button addIngredientsButton;
        private System.Windows.Forms.Label idProductLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown codeNumericUpDown;
        private System.Windows.Forms.Label codeProductLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label incomeLabel;
        private System.Windows.Forms.Label label2;
    }
}

