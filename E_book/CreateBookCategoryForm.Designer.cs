namespace E_book
{
    partial class CreateBookCategoryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CITextBox = new System.Windows.Forms.TextBox();
            this.CNTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SaveButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SaveButton.Location = new System.Drawing.Point(236, 186);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 31);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "SAVE";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(35, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "類別編號:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(35, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "書籍類別:";
            // 
            // CITextBox
            // 
            this.CITextBox.Location = new System.Drawing.Point(137, 117);
            this.CITextBox.Multiline = true;
            this.CITextBox.Name = "CITextBox";
            this.CITextBox.Size = new System.Drawing.Size(174, 31);
            this.CITextBox.TabIndex = 5;
            // 
            // CNTextBox
            // 
            this.CNTextBox.Location = new System.Drawing.Point(137, 53);
            this.CNTextBox.Multiline = true;
            this.CNTextBox.Name = "CNTextBox";
            this.CNTextBox.Size = new System.Drawing.Size(174, 31);
            this.CNTextBox.TabIndex = 6;
            // 
            // CreateBookCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(360, 244);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CITextBox);
            this.Controls.Add(this.CNTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateBookCategoryForm";
            this.Text = "CreateBookCategoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CITextBox;
        private System.Windows.Forms.TextBox CNTextBox;
    }
}