namespace Stratton_Hill_Resort_Management_System
{
    partial class StaffForm
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
            this.bankTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.phoneTxtBox = new System.Windows.Forms.TextBox();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.roleTxtBox = new System.Windows.Forms.TextBox();
            this.surnameTxtBox = new System.Windows.Forms.TextBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bbranchTxtBox = new System.Windows.Forms.TextBox();
            this.baccTxtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.DisplayBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.natTxtBox = new System.Windows.Forms.TextBox();
            this.resTxtBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nameErr = new System.Windows.Forms.Label();
            this.surnameErr = new System.Windows.Forms.Label();
            this.phoneErr = new System.Windows.Forms.Label();
            this.emailErr = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bankTxtBox
            // 
            this.bankTxtBox.Location = new System.Drawing.Point(166, 273);
            this.bankTxtBox.Name = "bankTxtBox";
            this.bankTxtBox.Size = new System.Drawing.Size(100, 20);
            this.bankTxtBox.TabIndex = 34;
            // 
            // phoneTxtBox
            // 
            this.phoneTxtBox.Location = new System.Drawing.Point(166, 222);
            this.phoneTxtBox.Name = "phoneTxtBox";
            this.phoneTxtBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTxtBox.TabIndex = 33;
            this.phoneTxtBox.TextChanged += new System.EventHandler(this.phoneTxtBox_TextChanged);
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Location = new System.Drawing.Point(166, 250);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(100, 20);
            this.emailTxtBox.TabIndex = 32;
            this.emailTxtBox.TextChanged += new System.EventHandler(this.emailTxtBox_TextChanged);
            // 
            // roleTxtBox
            // 
            this.roleTxtBox.Location = new System.Drawing.Point(166, 196);
            this.roleTxtBox.Name = "roleTxtBox";
            this.roleTxtBox.Size = new System.Drawing.Size(100, 20);
            this.roleTxtBox.TabIndex = 31;
            // 
            // surnameTxtBox
            // 
            this.surnameTxtBox.Location = new System.Drawing.Point(166, 170);
            this.surnameTxtBox.Name = "surnameTxtBox";
            this.surnameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.surnameTxtBox.TabIndex = 30;
            this.surnameTxtBox.TextChanged += new System.EventHandler(this.surnameTxtBox_TextChanged);
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(166, 147);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.nameTxtBox.TabIndex = 29;
            this.nameTxtBox.TextChanged += new System.EventHandler(this.nameTxtBox_TextChanged);
            // 
            // idTxtBox
            // 
            this.idTxtBox.Location = new System.Drawing.Point(166, 98);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.Size = new System.Drawing.Size(100, 20);
            this.idTxtBox.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Staff ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Bank Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Phone Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Role:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "First Name:";
            // 
            // bbranchTxtBox
            // 
            this.bbranchTxtBox.Location = new System.Drawing.Point(166, 324);
            this.bbranchTxtBox.Name = "bbranchTxtBox";
            this.bbranchTxtBox.Size = new System.Drawing.Size(100, 20);
            this.bbranchTxtBox.TabIndex = 39;
            // 
            // baccTxtBox
            // 
            this.baccTxtBox.Location = new System.Drawing.Point(166, 299);
            this.baccTxtBox.Name = "baccTxtBox";
            this.baccTxtBox.Size = new System.Drawing.Size(100, 20);
            this.baccTxtBox.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "National ID Number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Bank Account Number:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(91, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Bank Branch:";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(137, 476);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 45;
            this.ClearBtn.Text = "Clear Fields";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(180, 437);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 44;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(88, 437);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 43;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(180, 390);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 42;
            this.Add.Text = "Add New";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // DisplayBtn
            // 
            this.DisplayBtn.Location = new System.Drawing.Point(85, 390);
            this.DisplayBtn.Name = "DisplayBtn";
            this.DisplayBtn.Size = new System.Drawing.Size(75, 23);
            this.DisplayBtn.TabIndex = 41;
            this.DisplayBtn.Text = "Display All";
            this.DisplayBtn.UseVisualStyleBackColor = true;
            this.DisplayBtn.Click += new System.EventHandler(this.DisplayBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(384, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(724, 374);
            this.dataGridView1.TabIndex = 46;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // natTxtBox
            // 
            this.natTxtBox.Location = new System.Drawing.Point(166, 353);
            this.natTxtBox.Name = "natTxtBox";
            this.natTxtBox.Size = new System.Drawing.Size(100, 20);
            this.natTxtBox.TabIndex = 47;
            // 
            // resTxtBox
            // 
            this.resTxtBox.Location = new System.Drawing.Point(166, 124);
            this.resTxtBox.Name = "resTxtBox";
            this.resTxtBox.Size = new System.Drawing.Size(100, 20);
            this.resTxtBox.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(105, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "Resort ID:";
            // 
            // nameErr
            // 
            this.nameErr.AutoSize = true;
            this.nameErr.ForeColor = System.Drawing.Color.DarkRed;
            this.nameErr.Location = new System.Drawing.Point(272, 150);
            this.nameErr.Name = "nameErr";
            this.nameErr.Size = new System.Drawing.Size(0, 13);
            this.nameErr.TabIndex = 51;
            // 
            // surnameErr
            // 
            this.surnameErr.AutoSize = true;
            this.surnameErr.ForeColor = System.Drawing.Color.DarkRed;
            this.surnameErr.Location = new System.Drawing.Point(272, 177);
            this.surnameErr.Name = "surnameErr";
            this.surnameErr.Size = new System.Drawing.Size(0, 13);
            this.surnameErr.TabIndex = 52;
            // 
            // phoneErr
            // 
            this.phoneErr.AutoSize = true;
            this.phoneErr.ForeColor = System.Drawing.Color.DarkRed;
            this.phoneErr.Location = new System.Drawing.Point(272, 225);
            this.phoneErr.Name = "phoneErr";
            this.phoneErr.Size = new System.Drawing.Size(0, 13);
            this.phoneErr.TabIndex = 53;
            // 
            // emailErr
            // 
            this.emailErr.AutoSize = true;
            this.emailErr.ForeColor = System.Drawing.Color.DarkRed;
            this.emailErr.Location = new System.Drawing.Point(272, 253);
            this.emailErr.Name = "emailErr";
            this.emailErr.Size = new System.Drawing.Size(0, 13);
            this.emailErr.TabIndex = 54;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(404, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(261, 45);
            this.label12.TabIndex = 55;
            this.label12.Text = "Maintain Staff";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(602, 497);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(280, 13);
            this.label13.TabIndex = 56;
            this.label13.Text = "Role 1 - Cleaner | Role 2 - Receptionist | Role 3 - Manager";
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 533);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.emailErr);
            this.Controls.Add(this.phoneErr);
            this.Controls.Add(this.surnameErr);
            this.Controls.Add(this.nameErr);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.resTxtBox);
            this.Controls.Add(this.natTxtBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.DisplayBtn);
            this.Controls.Add(this.bbranchTxtBox);
            this.Controls.Add(this.baccTxtBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bankTxtBox);
            this.Controls.Add(this.phoneTxtBox);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.roleTxtBox);
            this.Controls.Add(this.surnameTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.idTxtBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox bankTxtBox;
        private System.Windows.Forms.TextBox phoneTxtBox;
        private System.Windows.Forms.TextBox emailTxtBox;
        private System.Windows.Forms.TextBox roleTxtBox;
        private System.Windows.Forms.TextBox surnameTxtBox;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox idTxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bbranchTxtBox;
        private System.Windows.Forms.TextBox baccTxtBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button DisplayBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox natTxtBox;
        private System.Windows.Forms.TextBox resTxtBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label nameErr;
        private System.Windows.Forms.Label surnameErr;
        private System.Windows.Forms.Label phoneErr;
        private System.Windows.Forms.Label emailErr;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}