namespace E_book
{
    partial class BookCategoryForm
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
            this.components = new System.ComponentModel.Container();
            this.addButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displayOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCategoryVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryIdComboBox = new System.Windows.Forms.ComboBox();
            this.bookCategoryIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.searchButton2 = new System.Windows.Forms.Button();
            this.fictionCategoryVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookCategoryVMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookCategoryIndexVMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fictionCategoryVMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.addButton.Location = new System.Drawing.Point(289, 406);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(103, 33);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add New";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.categoryNameDataGridViewTextBoxColumn,
            this.displayOrderDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookCategoryVMBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(359, 275);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "書籍類別 :";
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            // 
            // displayOrderDataGridViewTextBoxColumn
            // 
            this.displayOrderDataGridViewTextBoxColumn.DataPropertyName = "DisplayOrder";
            this.displayOrderDataGridViewTextBoxColumn.HeaderText = "類別編號 :";
            this.displayOrderDataGridViewTextBoxColumn.Name = "displayOrderDataGridViewTextBoxColumn";
            // 
            // bookCategoryVMBindingSource
            // 
            this.bookCategoryVMBindingSource.DataSource = typeof(E_book.Models.ViewModels.BookCategoryVM);
            // 
            // categoryIdComboBox
            // 
            this.categoryIdComboBox.DataSource = this.bookCategoryIndexVMBindingSource;
            this.categoryIdComboBox.DisplayMember = "CategoryName";
            this.categoryIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryIdComboBox.FormattingEnabled = true;
            this.categoryIdComboBox.Location = new System.Drawing.Point(33, 35);
            this.categoryIdComboBox.Name = "categoryIdComboBox";
            this.categoryIdComboBox.Size = new System.Drawing.Size(115, 20);
            this.categoryIdComboBox.TabIndex = 2;
            // 
            // bookCategoryIndexVMBindingSource
            // 
            this.bookCategoryIndexVMBindingSource.DataSource = typeof(E_book.Models.ViewModels.BookCategoryIndexVM);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.searchButton.Location = new System.Drawing.Point(74, 61);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(74, 27);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.fictionCategoryVMBindingSource;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(166, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 20);
            this.comboBox1.TabIndex = 7;
            // 
            // searchButton2
            // 
            this.searchButton2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.searchButton2.Location = new System.Drawing.Point(213, 61);
            this.searchButton2.Name = "searchButton2";
            this.searchButton2.Size = new System.Drawing.Size(68, 27);
            this.searchButton2.TabIndex = 8;
            this.searchButton2.Text = "Search";
            this.searchButton2.UseVisualStyleBackColor = true;
            // 
            // fictionCategoryVMBindingSource
            // 
            this.fictionCategoryVMBindingSource.DataSource = typeof(E_book.Models.ViewModels.FictionCategoryVM);
            // 
            // BookCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(427, 480);
            this.Controls.Add(this.searchButton2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.categoryIdComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addButton);
            this.Name = "BookCategoryForm";
            this.Text = "EbookCategoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookCategoryVMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookCategoryIndexVMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fictionCategoryVMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bookCategoryVMBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn displayOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox categoryIdComboBox;
        private System.Windows.Forms.BindingSource bookCategoryIndexVMBindingSource;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button searchButton2;
        private System.Windows.Forms.BindingSource fictionCategoryVMBindingSource;
    }
}