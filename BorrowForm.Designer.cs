namespace LibraryApp
{
    partial class BorrowForm
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
            this.BookNameCB = new System.Windows.Forms.ComboBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.MemberNameCB = new System.Windows.Forms.ComboBox();
            this.BorrowedDate = new System.Windows.Forms.DateTimePicker();
            this.ReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BookNameCB
            // 
            this.BookNameCB.Font = new System.Drawing.Font("Lalezar", 14F);
            this.BookNameCB.FormattingEnabled = true;
            this.BookNameCB.Location = new System.Drawing.Point(98, 12);
            this.BookNameCB.Name = "BookNameCB";
            this.BookNameCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BookNameCB.Size = new System.Drawing.Size(239, 38);
            this.BookNameCB.TabIndex = 8;
            this.BookNameCB.Text = "إسم الكتاب";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(252, 142);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(195, 66);
            this.AddBtn.TabIndex = 10;
            this.AddBtn.Text = "أضافة";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // MemberNameCB
            // 
            this.MemberNameCB.Font = new System.Drawing.Font("Lalezar", 14F);
            this.MemberNameCB.FormattingEnabled = true;
            this.MemberNameCB.Location = new System.Drawing.Point(387, 12);
            this.MemberNameCB.Name = "MemberNameCB";
            this.MemberNameCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MemberNameCB.Size = new System.Drawing.Size(239, 38);
            this.MemberNameCB.TabIndex = 11;
            this.MemberNameCB.Text = "إسم العضو";
            // 
            // BorrowedDate
            // 
            this.BorrowedDate.Font = new System.Drawing.Font("Lalezar", 14F, System.Drawing.FontStyle.Bold);
            this.BorrowedDate.Location = new System.Drawing.Point(360, 99);
            this.BorrowedDate.Name = "BorrowedDate";
            this.BorrowedDate.Size = new System.Drawing.Size(309, 37);
            this.BorrowedDate.TabIndex = 12;
            // 
            // ReturnDate
            // 
            this.ReturnDate.Font = new System.Drawing.Font("Lalezar", 14F, System.Drawing.FontStyle.Bold);
            this.ReturnDate.Location = new System.Drawing.Point(45, 99);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Size = new System.Drawing.Size(309, 37);
            this.ReturnDate.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lalezar", 14F);
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(465, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "تاريخ الأستعارة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lalezar", 14F);
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(155, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 30);
            this.label2.TabIndex = 15;
            this.label2.Text = "تاريخ الإرجاع";
            // 
            // BorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 223);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReturnDate);
            this.Controls.Add(this.BorrowedDate);
            this.Controls.Add(this.MemberNameCB);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.BookNameCB);
            this.Name = "BorrowForm";
            this.Text = "BorrowForm";
            this.Load += new System.EventHandler(this.BorrowForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox BookNameCB;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ComboBox MemberNameCB;
        private System.Windows.Forms.DateTimePicker BorrowedDate;
        private System.Windows.Forms.DateTimePicker ReturnDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}