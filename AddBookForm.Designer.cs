namespace LibraryApp
{
    partial class AddBookForm
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
            this.NameTB = new System.Windows.Forms.TextBox();
            this.PriceTB = new System.Windows.Forms.TextBox();
            this.TypeCB = new System.Windows.Forms.ComboBox();
            this.AuthorCB = new System.Windows.Forms.ComboBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameTB
            // 
            this.NameTB.Font = new System.Drawing.Font("Lalezar", 15F);
            this.NameTB.Location = new System.Drawing.Point(324, 13);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(267, 39);
            this.NameTB.TabIndex = 0;
            this.NameTB.Text = "إسم الكتاب";
            this.NameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PriceTB
            // 
            this.PriceTB.Font = new System.Drawing.Font("Lalezar", 15F);
            this.PriceTB.Location = new System.Drawing.Point(324, 80);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(267, 39);
            this.PriceTB.TabIndex = 1;
            this.PriceTB.Text = "سعر الكتاب";
            this.PriceTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TypeCB
            // 
            this.TypeCB.Font = new System.Drawing.Font("Lalezar", 14F);
            this.TypeCB.FormattingEnabled = true;
            this.TypeCB.Items.AddRange(new object[] {
            "دراما",
            "حرب",
            "رومانسي",
            "رعب",
            "تاريخي"});
            this.TypeCB.Location = new System.Drawing.Point(53, 13);
            this.TypeCB.Name = "TypeCB";
            this.TypeCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TypeCB.Size = new System.Drawing.Size(239, 38);
            this.TypeCB.TabIndex = 2;
            this.TypeCB.Text = "نوع الكتاب";
            // 
            // AuthorCB
            // 
            this.AuthorCB.Font = new System.Drawing.Font("Lalezar", 14F);
            this.AuthorCB.FormattingEnabled = true;
            this.AuthorCB.Location = new System.Drawing.Point(53, 81);
            this.AuthorCB.Name = "AuthorCB";
            this.AuthorCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AuthorCB.Size = new System.Drawing.Size(239, 38);
            this.AuthorCB.TabIndex = 3;
            this.AuthorCB.Text = "الكاتب";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(233, 130);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(195, 66);
            this.AddBtn.TabIndex = 5;
            this.AddBtn.Text = "أضافة";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 208);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.AuthorCB);
            this.Controls.Add(this.TypeCB);
            this.Controls.Add(this.PriceTB);
            this.Controls.Add(this.NameTB);
            this.Name = "AddBookForm";
            this.Text = "AddBookForm";
            this.Load += new System.EventHandler(this.AddBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox PriceTB;
        private System.Windows.Forms.ComboBox TypeCB;
        private System.Windows.Forms.ComboBox AuthorCB;
        private System.Windows.Forms.Button AddBtn;
    }
}