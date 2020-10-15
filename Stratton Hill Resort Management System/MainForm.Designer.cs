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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClientBtn
            // 
            this.ClientBtn.BackColor = System.Drawing.Color.Transparent;
            this.ClientBtn.Location = new System.Drawing.Point(59, 115);
            this.ClientBtn.Name = "ClientBtn";
            this.ClientBtn.Size = new System.Drawing.Size(95, 43);
            this.ClientBtn.TabIndex = 0;
            this.ClientBtn.Text = "Maintain Clients";
            this.ClientBtn.UseVisualStyleBackColor = false;
            this.ClientBtn.Click += new System.EventHandler(this.ClientBtn_Click);
            // 
            // AccommBtn
            // 
            this.AccommBtn.BackColor = System.Drawing.Color.Transparent;
            this.AccommBtn.Location = new System.Drawing.Point(261, 116);
            this.AccommBtn.Name = "AccommBtn";
            this.AccommBtn.Size = new System.Drawing.Size(95, 43);
            this.AccommBtn.TabIndex = 1;
            this.AccommBtn.Text = "Maintain Accommodation";
            this.AccommBtn.UseVisualStyleBackColor = false;
            this.AccommBtn.Click += new System.EventHandler(this.AccommBtn_Click);
            // 
            // StaffBtn
            // 
            this.StaffBtn.BackColor = System.Drawing.Color.Transparent;
            this.StaffBtn.Location = new System.Drawing.Point(160, 116);
            this.StaffBtn.Name = "StaffBtn";
            this.StaffBtn.Size = new System.Drawing.Size(95, 43);
            this.StaffBtn.TabIndex = 2;
            this.StaffBtn.Text = "Maintain Staff";
            this.StaffBtn.UseVisualStyleBackColor = false;
            this.StaffBtn.Click += new System.EventHandler(this.StaffBtn_Click);
            // 
            // BookingBtn
            // 
            this.BookingBtn.BackColor = System.Drawing.Color.Transparent;
            this.BookingBtn.Location = new System.Drawing.Point(362, 115);
            this.BookingBtn.Name = "BookingBtn";
            this.BookingBtn.Size = new System.Drawing.Size(95, 43);
            this.BookingBtn.TabIndex = 3;
            this.BookingBtn.Text = "Make a Booking";
            this.BookingBtn.UseVisualStyleBackColor = false;
            this.BookingBtn.Click += new System.EventHandler(this.BookingBtn_Click);
            // 
            // CheckinBtn
            // 
            this.CheckinBtn.BackColor = System.Drawing.Color.Transparent;
            this.CheckinBtn.Location = new System.Drawing.Point(59, 191);
            this.CheckinBtn.Name = "CheckinBtn";
            this.CheckinBtn.Size = new System.Drawing.Size(95, 43);
            this.CheckinBtn.TabIndex = 4;
            this.CheckinBtn.Text = "Check In";
            this.CheckinBtn.UseVisualStyleBackColor = false;
            this.CheckinBtn.Click += new System.EventHandler(this.CheckinBtn_Click);
            // 
            // PaymentBtn
            // 
            this.PaymentBtn.BackColor = System.Drawing.Color.Transparent;
            this.PaymentBtn.Location = new System.Drawing.Point(160, 191);
            this.PaymentBtn.Name = "PaymentBtn";
            this.PaymentBtn.Size = new System.Drawing.Size(95, 43);
            this.PaymentBtn.TabIndex = 5;
            this.PaymentBtn.Text = "Recieve Payment";
            this.PaymentBtn.UseVisualStyleBackColor = false;
            this.PaymentBtn.Click += new System.EventHandler(this.PaymentBtn_Click);
            // 
            // CheckoutBtn
            // 
            this.CheckoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.CheckoutBtn.Location = new System.Drawing.Point(261, 191);
            this.CheckoutBtn.Name = "CheckoutBtn";
            this.CheckoutBtn.Size = new System.Drawing.Size(95, 43);
            this.CheckoutBtn.TabIndex = 6;
            this.CheckoutBtn.Text = "Check Out";
            this.CheckoutBtn.UseVisualStyleBackColor = false;
            this.CheckoutBtn.Click += new System.EventHandler(this.CheckoutBtn_Click);
            // 
            // reportBtn
            // 
            this.reportBtn.BackColor = System.Drawing.Color.Transparent;
            this.reportBtn.Location = new System.Drawing.Point(362, 191);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(95, 43);
            this.reportBtn.TabIndex = 7;
            this.reportBtn.Text = "Reports";
            this.reportBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(122, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 61);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dashboard";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(534, 295);
            this.Controls.Add(this.label1);
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
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
    }
}