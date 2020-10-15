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
    public partial class BookingForm : Form
    {
        String connectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Yusuf\Documents\Stratton Hill Resort Database.mdb";

        public BookingForm()
        {
            InitializeComponent();
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {

        }

        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            //Sql query variables
            string sql1 = "SELECT Booking_ID, Client_ID, Nights_No from Booking";
            string sql2 = "SELECT * from Booking_Detail";
            
            try
            {
                //Opening connection
                OleDbConnection conn = new OleDbConnection(connectionString);

                //Declaring Variables
                OleDbCommand command = new OleDbCommand(sql1, conn);
                OleDbCommand command2 = new OleDbCommand(sql2, conn);

                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                OleDbDataAdapter adapter2 = new OleDbDataAdapter(command2);
                DataTable dt = new DataTable();
                DataTable dt2 = new DataTable();

                //Fill data grids
                adapter.Fill(dt);
                adapter2.Fill(dt2);
                dataGridView1.DataSource = dt;
                dataGridView2.DataSource = dt2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            //Variables 
            string bookingID = bookingTxtBox.Text;
            string clientID = clientTxtBox.Text;
            string nights = nightsTxtBox.Text;
            string unitNo = unitTxtBox.Text;


            //Sql query variable
            string sql = "insert into Booking (Booking_ID, Client_ID, Nights_No) VALUES (@booking,@client,@nights)";
            string sql2 = "insert into Booking_Detail (Booking_ID, Unit_Number) VALUES (@booking,@unitNo)";

            try
            {
                //Opening connection
                OleDbConnection conn = new OleDbConnection(connectionString);

                //Declaring Variables
                OleDbCommand command = new OleDbCommand(sql, conn);
                OleDbCommand command2 = new OleDbCommand(sql2, conn);

                command.Parameters.AddWithValue("@booking", bookingID);
                command.Parameters.AddWithValue("@client", clientID);
                command.Parameters.AddWithValue("@nights", nights);
                command2.Parameters.AddWithValue("@booking", bookingID);
                command2.Parameters.AddWithValue("@unitNo", unitNo);
                //Open connection
                conn.Open();

                //Execute query
                command.ExecuteNonQuery();
                command2.ExecuteNonQuery();

                //Close Connection
                conn.Close();

                MessageBox.Show("Added Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }

            DisplayBtn.PerformClick();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            //Variables 
            string bookingID = bookingTxtBox.Text;
            string clientID = clientTxtBox.Text;
            string nights = nightsTxtBox.Text;
            string unitNo = unitTxtBox.Text;

            //sql query variable 
            string sql = "UPDATE Booking SET Client_ID = @client, Nights_No = @nights WHERE Booking_ID = @booking";
            string sql2 = "UPDATE Booking_Detail SET Unit_Number = @unitNo WHERE Booking_ID = @booking";

            try
            {
                //Connect
                OleDbConnection conn = new OleDbConnection(connectionString);

                OleDbCommand command = new OleDbCommand(sql, conn);
                OleDbCommand command2 = new OleDbCommand(sql2, conn);

                command.Parameters.AddWithValue("@client", clientID);
                command.Parameters.AddWithValue("@nights", nights);
                command.Parameters.AddWithValue("@booking", bookingID);
                command.Parameters["@booking"].Value = bookingID;

                command2.Parameters.AddWithValue("@unitNo", unitNo);
                command2.Parameters.AddWithValue("@booking", bookingID);
                command2.Parameters["@booking"].Value = bookingID;

                //open connections
                conn.Open();

                command.ExecuteNonQuery();
                command2.ExecuteNonQuery();

                //close connection
                conn.Close();

                MessageBox.Show("Updated Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            DisplayBtn.PerformClick();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bookingTxtBox.Text = "";
            clientTxtBox.Text = "";
            nightsTxtBox.Text = "";
            unitTxtBox.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            bookingTxtBox.Text = row.Cells[0].Value.ToString();
            nightsTxtBox.Text = row.Cells[1].Value.ToString();
            clientTxtBox.Text = row.Cells[2].Value.ToString();
        }
    }
}
