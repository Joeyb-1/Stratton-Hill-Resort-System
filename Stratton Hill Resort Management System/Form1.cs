using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stratton_Hill_Resort_Management_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            usernameTxtBox.Text = "";
            passwordTxtBox.Text = "";
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            // username is Admin (not case sensitive)
            // password is 1234

            if (usernameTxtBox.Text.Equals("Admin", StringComparison.InvariantCultureIgnoreCase))
            {
                if (passwordTxtBox.Text.Equals("1234"))
                {
                    this.Hide();
                    MainForm main = new MainForm();
                    main.Show();
                }
                else { MessageBox.Show("password incorrect"); }
            }
            else 
            {
                MessageBox.Show("Wrong username");
            }
        }
    }
}
