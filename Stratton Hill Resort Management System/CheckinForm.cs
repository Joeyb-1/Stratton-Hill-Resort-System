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
    public partial class CheckinForm : Form
    {
        String connectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Yusuf\Documents\Stratton Hill Resort Database.mdb";
        public CheckinForm()
        {
            InitializeComponent();
        }

        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            //Sql query variable
            string sql = "SELECT Booking_ID, Client_ID,Checkin_Date from Booking";

            try
            {
                //Opening connection
                OleDbConnection conn = new OleDbConnection(connectionString);

                //Declaring Variables
                OleDbCommand command = new OleDbCommand(sql, conn);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();

                //Fill data grids
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                bookingTxtBox.Text = row.Cells[0].Value.ToString();
                dateTxtBox.Text = row.Cells[2].Value.ToString();
            }
        }

        private void CheckinForm_Load(object sender, EventArgs e)
        {
            dateTxtBox.Mask = "####/##/##";
        }

        private void CheckinBtn_Click(object sender, EventArgs e)
        {
            //Variables 
            string bookingID = bookingTxtBox.Text;
            string date = dateTxtBox.Text;

            //Sql query variable
            string sql = "UPDATE Booking SET Checkin_Date = @Checkin WHERE Booking_ID = @booking";

            try
            {
                //Opening connection
                OleDbConnection conn = new OleDbConnection(connectionString);

                //Declaring Variable
                OleDbCommand command = new OleDbCommand(sql, conn);

                command.Parameters.AddWithValue("@Checkin", date);
                command.Parameters.AddWithValue("@booking", bookingID);
                command.Parameters["@booking"].Value = bookingID;

                //Open connection
                conn.Open();

                //Execute query
                command.ExecuteNonQuery();

                //Close Connection
                conn.Close();

                MessageBox.Show("Checked in Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }

            DisplayBtn.PerformClick();
        }
    }
}
