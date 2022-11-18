namespace E_book
{
    partial class BookForm
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
            this.addNewButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.categoryIdComboBox = new System.Windows.Forms.ComboBox();
            this.bookIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.BookNameTextBox = new System.Windows.Forms.TextBox();
            this.PublishYearTextBox = new System.Windows.Forms.TextBox();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bookIndexVMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewButton
            // 
            this.addNewButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.addNewButton.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.addNewButton.Location = new System.Drawing.Point(541, 454);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(64, 30);
            this.addNewButton.TabIndex = 6;
            this.addNewButton.Text = "Add";
            this.addNewButton.UseVisualStyleBackColor = false;
            this.addNewButton.Click += new System.EventHandler(this.addnewButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.searchButton.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.searchButton.Location = new System.Drawing.Point(437, 454);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(78, 30);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // categoryIdComboBox
            // 
            this.categoryIdComboBox.DataSource = this.bookIndexVMBindingSource;
            this.categoryIdComboBox.DisplayMember = "CategoryName";
            this.categoryIdComboBox.FormattingEnabled = true;
            this.categoryIdComboBox.Location = new System.Drawing.Point(36, 69);
            this.categoryIdComboBox.Name = "categoryIdComboBox";
            this.categoryIdComboBox.Size = new System.Drawing.Size(95, 20);
            this.categoryIdComboBox.TabIndex = 4;
            // 
            // bookIndexVMBindingSource
            // 
            this.bookIndexVMBindingSource.DataSource = typeof(E_book.Models.ViewModels.BookIndexVM);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 9;
            // 
            // BookNameTextBox
            // 
            this.BookNameTextBox.Location = new System.Drawing.Point(185, 68);
            this.BookNameTextBox.Multiline = true;
            this.BookNameTextBox.Name = "BookNameTextBox";
            this.BookNameTextBox.Size = new System.Drawing.Size(99, 22);
            this.BookNameTextBox.TabIndex = 12;
            // 
            // PublishYearTextBox
            // 
            this.PublishYearTextBox.Location = new System.Drawing.Point(506, 68);
            this.PublishYearTextBox.Multiline = true;
            this.PublishYearTextBox.Name = "PublishYearTextBox";
            this.PublishYearTextBox.Size = new System.Drawing.Size(99, 22);
            this.PublishYearTextBox.TabIndex = 13;
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(348, 68);
            this.AuthorTextBox.Multiline = true;
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(99, 22);
            this.AuthorTextBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(462, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 15;
            this.label1.Tag = "年分 :";
            this.label1.Text = "年分  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(304, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 16;
            this.label3.Tag = "作者 :";
            this.label3.Text = "作者 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(144, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 17;
            this.label4.Tag = "作者 :";
            this.label4.Text = "書名 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(33, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 18;
            this.label5.Tag = "作者 :";
            this.label5.Text = "書籍類別 :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.categoryIdDataGridViewTextBoxColumn,
            this.categoryNameDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.publishYearDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookIndexVMBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(569, 297);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            this.categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "BookName";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "BookName";
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            // 
            // publishYearDataGridViewTextBoxColumn
            // 
            this.publishYearDataGridViewTextBoxColumn.DataPropertyName = "PublishYear";
            this.publishYearDataGridViewTextBoxColumn.HeaderText = "PublishYear";
            this.publishYearDataGridViewTextBoxColumn.Name = "publishYearDataGridViewTextBoxColumn";
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(651, 521);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.PublishYearTextBox);
            this.Controls.Add(this.BookNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addNewButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.categoryIdComboBox);
            this.Name = "BookForm";
            this.Text = "BookForm";
            ((System.ComponentModel.ISupportInitialize)(this.bookIndexVMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addNewButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox categoryIdComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BookNameTextBox;
        private System.Windows.Forms.TextBox PublishYearTextBox;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bookIndexVMBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishYearDataGridViewTextBoxColumn;
    }
}