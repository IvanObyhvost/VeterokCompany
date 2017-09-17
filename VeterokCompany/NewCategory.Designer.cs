namespace VeterokCompany
{
    partial class NewCategory
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
            this.categoryDataGridView = new System.Windows.Forms.DataGridView();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.addOrUpdateGroupBox = new System.Windows.Forms.GroupBox();
            this.idCategoryLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.nameCategoryTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.validMessagelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).BeginInit();
            this.addOrUpdateGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryDataGridView
            // 
            this.categoryDataGridView.AllowUserToAddRows = false;
            this.categoryDataGridView.AllowUserToDeleteRows = false;
            this.categoryDataGridView.AllowUserToResizeColumns = false;
            this.categoryDataGridView.AllowUserToResizeRows = false;
            this.categoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoryDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.categoryDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.categoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.categoryDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.categoryDataGridView.EnableHeadersVisualStyles = false;
            this.categoryDataGridView.Location = new System.Drawing.Point(12, 12);
            this.categoryDataGridView.MultiSelect = false;
            this.categoryDataGridView.Name = "categoryDataGridView";
            this.categoryDataGridView.ReadOnly = true;
            this.categoryDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.categoryDataGridView.Size = new System.Drawing.Size(250, 425);
            this.categoryDataGridView.TabIndex = 0;
            this.categoryDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoryDataGridView_CellClick);
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.Location = new System.Drawing.Point(269, 13);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(111, 42);
            this.addCategoryButton.TabIndex = 1;
            this.addCategoryButton.Text = "Добавить";
            this.addCategoryButton.UseVisualStyleBackColor = true;
            this.addCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
            // 
            // addOrUpdateGroupBox
            // 
            this.addOrUpdateGroupBox.Controls.Add(this.idCategoryLabel);
            this.addOrUpdateGroupBox.Controls.Add(this.saveButton);
            this.addOrUpdateGroupBox.Controls.Add(this.nameCategoryTextBox);
            this.addOrUpdateGroupBox.Controls.Add(this.label1);
            this.addOrUpdateGroupBox.Location = new System.Drawing.Point(269, 62);
            this.addOrUpdateGroupBox.Name = "addOrUpdateGroupBox";
            this.addOrUpdateGroupBox.Size = new System.Drawing.Size(286, 124);
            this.addOrUpdateGroupBox.TabIndex = 2;
            this.addOrUpdateGroupBox.TabStop = false;
            this.addOrUpdateGroupBox.Text = "groupBox1";
            this.addOrUpdateGroupBox.Visible = false;
            // 
            // idCategoryLabel
            // 
            this.idCategoryLabel.AutoSize = true;
            this.idCategoryLabel.Location = new System.Drawing.Point(115, 16);
            this.idCategoryLabel.Name = "idCategoryLabel";
            this.idCategoryLabel.Size = new System.Drawing.Size(83, 13);
            this.idCategoryLabel.TabIndex = 3;
            this.idCategoryLabel.Text = "idCategoryLabel";
            this.idCategoryLabel.Visible = false;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(80, 72);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(129, 41);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // nameCategoryTextBox
            // 
            this.nameCategoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameCategoryTextBox.Location = new System.Drawing.Point(118, 32);
            this.nameCategoryTextBox.Name = "nameCategoryTextBox";
            this.nameCategoryTextBox.Size = new System.Drawing.Size(162, 23);
            this.nameCategoryTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование*";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(438, 14);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(111, 42);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // validMessagelabel
            // 
            this.validMessagelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.validMessagelabel.ForeColor = System.Drawing.Color.Red;
            this.validMessagelabel.Location = new System.Drawing.Point(268, 189);
            this.validMessagelabel.Name = "validMessagelabel";
            this.validMessagelabel.Size = new System.Drawing.Size(274, 26);
            this.validMessagelabel.TabIndex = 4;
            this.validMessagelabel.Text = "Валидация";
            this.validMessagelabel.Visible = false;
            // 
            // NewCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 449);
            this.Controls.Add(this.validMessagelabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addOrUpdateGroupBox);
            this.Controls.Add(this.addCategoryButton);
            this.Controls.Add(this.categoryDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Категории";
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).EndInit();
            this.addOrUpdateGroupBox.ResumeLayout(false);
            this.addOrUpdateGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView categoryDataGridView;
        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.GroupBox addOrUpdateGroupBox;
        private System.Windows.Forms.TextBox nameCategoryTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label idCategoryLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label validMessagelabel;
    }
}