namespace Stratton_Hill_Resort_Management_System
{
    partial class MainForm
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
            this.ClientBtn = new System.Windows.Forms.Button();
            this.AccommBtn = new System.Windows.Forms.Button();
            this.StaffBtn = new System.Windows.Forms.Button();
            this.BookingBtn = new System.Windows.Forms.Button();
            this.CheckinBtn = new System.Windows.Forms.Button();
            this.PaymentBtn = new System.Windows.Forms.Button();
            this.CheckoutBtn = new System.Windows.Forms.Button();
            this.reportBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClientBtn
            // 
            this.ClientBtn.Location = new System.Drawing.Point(34, 116);
            this.ClientBtn.Name = "ClientBtn";
            this.ClientBtn.Size = new System.Drawing.Size(95, 43);
            this.ClientBtn.TabIndex = 0;
            this.ClientBtn.Text = "Maintain Clients";
            this.ClientBtn.UseVisualStyleBackColor = true;
            this.ClientBtn.Click += new System.EventHandler(this.ClientBtn_Click);
            // 
            // AccommBtn
            // 
            this.AccommBtn.Location = new System.Drawing.Point(236, 117);
            this.AccommBtn.Name = "AccommBtn";
            this.AccommBtn.Size = new System.Drawing.Size(95, 45);
            this.AccommBtn.TabIndex = 1;
            this.AccommBtn.Text = "Maintain Accommodation";
            this.AccommBtn.UseVisualStyleBackColor = true;
            // 
            // StaffBtn
            // 
            this.StaffBtn.Location = new System.Drawing.Point(135, 117);
            this.StaffBtn.Name = "StaffBtn";
            this.StaffBtn.Size = new System.Drawing.Size(95, 42);
            this.StaffBtn.TabIndex = 2;
            this.StaffBtn.Text = "Maintain Staff";
            this.StaffBtn.UseVisualStyleBackColor = true;
            this.StaffBtn.Click += new System.EventHandler(this.StaffBtn_Click);
            // 
            // BookingBtn
            // 
            this.BookingBtn.Location = new System.Drawing.Point(337, 119);
            this.BookingBtn.Name = "BookingBtn";
            this.BookingBtn.Size = new System.Drawing.Size(95, 40);
            this.BookingBtn.TabIndex = 3;
            this.BookingBtn.Text = "Make a Booking";
            this.BookingBtn.UseVisualStyleBackColor = true;
            // 
            // CheckinBtn
            // 
            this.CheckinBtn.Location = new System.Drawing.Point(438, 119);
            this.CheckinBtn.Name = "CheckinBtn";
            this.CheckinBtn.Size = new System.Drawing.Size(95, 40);
            this.CheckinBtn.TabIndex = 4;
            this.CheckinBtn.Text = "Check In";
            this.CheckinBtn.UseVisualStyleBackColor = true;
            // 
            // PaymentBtn
            // 
            this.PaymentBtn.Location = new System.Drawing.Point(539, 121);
            this.PaymentBtn.Name = "PaymentBtn";
            this.PaymentBtn.Size = new System.Drawing.Size(95, 40);
            this.PaymentBtn.TabIndex = 5;
            this.PaymentBtn.Text = "Recieve Payment";
            this.PaymentBtn.UseVisualStyleBackColor = true;
            // 
            // CheckoutBtn
            // 
            this.CheckoutBtn.Location = new System.Drawing.Point(640, 121);
            this.CheckoutBtn.Name = "CheckoutBtn";
            this.CheckoutBtn.Size = new System.Drawing.Size(95, 40);
            this.CheckoutBtn.TabIndex = 6;
            this.CheckoutBtn.Text = "Check Out";
            this.CheckoutBtn.UseVisualStyleBackColor = true;
            // 
            // reportBtn
            // 
            this.reportBtn.Location = new System.Drawing.Point(337, 202);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(95, 40);
            this.reportBtn.TabIndex = 7;
            this.reportBtn.Text = "Reports";
            this.reportBtn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.CheckoutBtn);
            this.Controls.Add(this.PaymentBtn);
            this.Controls.Add(this.CheckinBtn);
            this.Controls.Add(this.BookingBtn);
            this.Controls.Add(this.StaffBtn);
            this.Controls.Add(this.AccommBtn);
            this.Controls.Add(this.ClientBtn);
            this.Name = "MainForm";
            this.Text = "Stratton Hill Management System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ClientBtn;
        private System.Windows.Forms.Button AccommBtn;
        private System.Windows.Forms.Button StaffBtn;
        private System.Windows.Forms.Button BookingBtn;
        private System.Windows.Forms.Button CheckinBtn;
        private System.Windows.Forms.Button PaymentBtn;
        private System.Windows.Forms.Button CheckoutBtn;
        private System.Windows.Forms.Button reportBtn;
    }
}