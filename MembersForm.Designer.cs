﻿namespace LibraryApp
{
    partial class MembersForm
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
            this.AddBtn = new System.Windows.Forms.Button();
            this.AddressTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.PhoneTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(258, 129);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(195, 66);
            this.AddBtn.TabIndex = 10;
            this.AddBtn.Text = "أضافة";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // AddressTB
            // 
            this.AddressTB.Font = new System.Drawing.Font("Lalezar", 15F);
            this.AddressTB.Location = new System.Drawing.Point(76, 12);
            this.AddressTB.Name = "AddressTB";
            this.AddressTB.Size = new System.Drawing.Size(267, 39);
            this.AddressTB.TabIndex = 7;
            this.AddressTB.Text = "عنوان العضو";
            this.AddressTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NameTB
            // 
            this.NameTB.Font = new System.Drawing.Font("Lalezar", 15F);
            this.NameTB.Location = new System.Drawing.Point(349, 12);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(267, 39);
            this.NameTB.TabIndex = 6;
            this.NameTB.Text = "إسم العضو";
            this.NameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PhoneTB
            // 
            this.PhoneTB.Font = new System.Drawing.Font("Lalezar", 15F);
            this.PhoneTB.Location = new System.Drawing.Point(228, 72);
            this.PhoneTB.Name = "PhoneTB";
            this.PhoneTB.Size = new System.Drawing.Size(267, 39);
            this.PhoneTB.TabIndex = 11;
            this.PhoneTB.Text = "هاتف العضو";
            this.PhoneTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 208);
            this.Controls.Add(this.PhoneTB);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.AddressTB);
            this.Controls.Add(this.NameTB);
            this.Name = "MembersForm";
            this.Text = "MembersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox AddressTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox PhoneTB;
    }
}