using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stratton_Hill_Resort_Management_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ClientBtn_Click(object sender, EventArgs e)
        {
            ClientForm client = new ClientForm();
            client.ShowDialog();
        }

        private void StaffBtn_Click(object sender, EventArgs e)
        {
            StaffForm staff = new StaffForm();
            staff.ShowDialog();
        }

        public void OpenConnection(string connectionString)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
