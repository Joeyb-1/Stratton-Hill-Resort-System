using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private void AccommBtn_Click(object sender, EventArgs e)
        {
            AccommodationForm accommodation = new AccommodationForm();
            accommodation.Show();
        }

        private void BookingBtn_Click(object sender, EventArgs e)
        {
            BookingForm booking = new BookingForm();
            booking.Show();
        }

        private void CheckinBtn_Click(object sender, EventArgs e)
        {
            CheckinForm checkin = new CheckinForm();
            checkin.ShowDialog();
        }

        private void CheckoutBtn_Click(object sender, EventArgs e)
        {
            CheckoutForm checkout = new CheckoutForm();
            checkout.ShowDialog();
        }

        private void PaymentBtn_Click(object sender, EventArgs e)
        {
            PaymentForm payment = new PaymentForm();
            payment.ShowDialog();
        }

        //Validate Names and Surnames
        public bool ValidateName(String n)
        {
            bool returnVal = false;
            int i = n.Length;

            if (i > 30)
            {
                return false;
            }
            else
            {
                if (n.All(char.IsLetter))
                    returnVal = true;
                else
                    returnVal = false;
            }

            return returnVal;
        }

        //Validate Email Addresses
        public bool ValidateEmail(string n)
        {
            try
            {
                var email = new System.Net.Mail.MailAddress(n);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Validate Phone Numbers
        public bool ValidatePhone(string n)
        {
            if (n.All(char.IsDigit))
                return true;
            else
                return false;
        }
    }
}
