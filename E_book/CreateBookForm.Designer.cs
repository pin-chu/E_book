namespace E_book
{
    partial class CreateBookForm
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
            this.saveButton = new System.Windows.Forms.Button();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BookNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PublishYearTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.categoryIdComboBox = new System.Windows.Forms.ComboBox();
            this.bookIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookCategoryIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bookIndexVMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookCategoryIndexVMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(180, 231);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 30);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AuthorTextBox.Location = new System.Drawing.Point(117, 132);
            this.AuthorTextBox.Multiline = true;
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(138, 29);
            this.AuthorTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(29, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "作者 :";
            // 
            // BookNameTextBox
            // 
            this.BookNameTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BookNameTextBox.Location = new System.Drawing.Point(117, 97);
            this.BookNameTextBox.Multiline = true;
            this.BookNameTextBox.Name = "BookNameTextBox";
            this.BookNameTextBox.Size = new System.Drawing.Size(138, 29);
            this.BookNameTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(29, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "書籍分類 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(29, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "書名 :";
            // 
            // PublishYearTextBox
            // 
            this.PublishYearTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PublishYearTextBox.Location = new System.Drawing.Point(117, 172);
            this.PublishYearTextBox.Multiline = true;
            this.PublishYearTextBox.Name = "PublishYearTextBox";
            this.PublishYearTextBox.Size = new System.Drawing.Size(138, 29);
            this.PublishYearTextBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(29, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "出版年份 :";
            // 
            // categoryIdComboBox
            // 
            this.categoryIdComboBox.DataSource = this.bookIndexVMBindingSource;
            this.categoryIdComboBox.DisplayMember = "CategoryName";
            this.categoryIdComboBox.FormattingEnabled = true;
            this.categoryIdComboBox.Location = new System.Drawing.Point(117, 40);
            this.categoryIdComboBox.Name = "categoryIdComboBox";
            this.categoryIdComboBox.Size = new System.Drawing.Size(138, 20);
            this.categoryIdComboBox.TabIndex = 13;
            this.categoryIdComboBox.ValueMember = "Id";
            // 
            // bookIndexVMBindingSource
            // 
            this.bookIndexVMBindingSource.DataSource = typeof(E_book.Models.ViewModels.BookIndexVM);
            // 
            // bookCategoryIndexVMBindingSource
            // 
            this.bookCategoryIndexVMBindingSource.DataSource = typeof(E_book.Models.ViewModels.BookCategoryIndexVM);
            // 
            // CreateBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(297, 280);
            this.Controls.Add(this.categoryIdComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PublishYearTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BookNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "CreateBookForm";
            this.Text = "CreateBookForm";
            ((System.ComponentModel.ISupportInitialize)(this.bookIndexVMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookCategoryIndexVMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BookNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PublishYearTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox categoryIdComboBox;
        private System.Windows.Forms.BindingSource bookCategoryIndexVMBindingSource;
        private System.Windows.Forms.BindingSource bookIndexVMBindingSource;
    }
}