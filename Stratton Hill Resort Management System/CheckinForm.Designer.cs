﻿namespace Stratton_Hill_Resort_Management_System
{
    partial class CheckinForm
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
            this.DisplayBtn = new System.Windows.Forms.Button();
            this.CheckinBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bookingTxtBox = new System.Windows.Forms.TextBox();
            this.dateTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DisplayBtn
            // 
            this.DisplayBtn.Location = new System.Drawing.Point(68, 223);
            this.DisplayBtn.Name = "DisplayBtn";
            this.DisplayBtn.Size = new System.Drawing.Size(75, 23);
            this.DisplayBtn.TabIndex = 0;
            this.DisplayBtn.Text = "Display";
            this.DisplayBtn.UseVisualStyleBackColor = true;
            this.DisplayBtn.Click += new System.EventHandler(this.DisplayBtn_Click);
            // 
            // CheckinBtn
            // 
            this.CheckinBtn.Location = new System.Drawing.Point(157, 223);
            this.CheckinBtn.Name = "CheckinBtn";
            this.CheckinBtn.Size = new System.Drawing.Size(75, 23);
            this.CheckinBtn.TabIndex = 1;
            this.CheckinBtn.Text = "Check in";
            this.CheckinBtn.UseVisualStyleBackColor = true;
            this.CheckinBtn.Click += new System.EventHandler(this.CheckinBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(294, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(456, 213);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Booking ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // bookingTxtBox
            // 
            this.bookingTxtBox.Location = new System.Drawing.Point(132, 146);
            this.bookingTxtBox.Name = "bookingTxtBox";
            this.bookingTxtBox.Size = new System.Drawing.Size(100, 20);
            this.bookingTxtBox.TabIndex = 6;
            // 
            // dateTxtBox
            // 
            this.dateTxtBox.Location = new System.Drawing.Point(132, 182);
            this.dateTxtBox.Name = "dateTxtBox";
            this.dateTxtBox.Size = new System.Drawing.Size(100, 20);
            this.dateTxtBox.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(259, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(281, 45);
            this.label8.TabIndex = 30;
            this.label8.Text = "Check In Client";
            // 
            // CheckinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 359);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTxtBox);
            this.Controls.Add(this.bookingTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CheckinBtn);
            this.Controls.Add(this.DisplayBtn);
            this.Name = "CheckinForm";
            this.Text = "CheckinForm";
            this.Load += new System.EventHandler(this.CheckinForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DisplayBtn;
        private System.Windows.Forms.Button CheckinBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bookingTxtBox;
        private System.Windows.Forms.MaskedTextBox dateTxtBox;
        private System.Windows.Forms.Label label8;
    }
}