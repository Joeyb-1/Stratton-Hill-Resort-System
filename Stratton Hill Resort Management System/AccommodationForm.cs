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
    public partial class AccommodationForm : Form
    {
        String connectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Yusuf\Documents\Stratton Hill Resort Database.mdb";
        public AccommodationForm()
        {
            InitializeComponent();
        }

        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            //Sql query variable
            string sql = "SELECT * from Room";

            try
            {
                //Opening connection
                OleDbConnection conn = new OleDbConnection(connectionString);

                //Declaring Variables
                OleDbCommand command = new OleDbCommand(sql, conn);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();

                //Fill data grid
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            //Variables 
            string unitNo = unitTxtBox.Text;
            string type = typeTxtBox.Text;
            string adults = adultsTxtBox.Text;
            string children = childTxtBox.Text;
            string bed = bedTxtBox.Text;
            string bath = bathTxtBox.Text;
            string status = statusTxtBox.Text;

            //Sql query variable
            string sql = "insert into Room (Unit_Number,Room_Type,Adults_No,Children_No,Bedrooms_No,Bathrooms_No,Status) VALUES (@unitNo,@type,@adults,@children,@bed,@bath,@status)";

            try
            {
                //Opening connection
                OleDbConnection conn = new OleDbConnection(connectionString);

                //Declaring Variable
                OleDbCommand command = new OleDbCommand(sql, conn);

                command.Parameters.AddWithValue("@unitNo", unitNo);
                command.Parameters.AddWithValue("@type", type);
                command.Parameters.AddWithValue("@adults", adults);
                command.Parameters.AddWithValue("@children", children);
                command.Parameters.AddWithValue("@bed", bed);
                command.Parameters.AddWithValue("@bath", bath);
                command.Parameters.AddWithValue("@status", status);
                //Open connection
                conn.Open();

                //Execute query
                command.ExecuteNonQuery();

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
            string unitNo = unitTxtBox.Text;
            string type = typeTxtBox.Text;
            string adults = adultsTxtBox.Text;
            string children = childTxtBox.Text;
            string bed = bedTxtBox.Text;
            string bath = bathTxtBox.Text;
            string status = statusTxtBox.Text;

            //sql query variable 
            string sql = "UPDATE Room SET Room_Type = @type, Adults_No = @adults, Children_No = @children, Bedrooms_No = @bed, Bathrooms_No = @bath, Status = @status WHERE Unit_Number = @unitNo";

            try
            {
                //Connect
                OleDbConnection conn = new OleDbConnection(connectionString);

                OleDbCommand command = new OleDbCommand(sql, conn);

                command.Parameters.AddWithValue("@type", type);
                command.Parameters.AddWithValue("@adults", adults);
                command.Parameters.AddWithValue("@children", children);
                command.Parameters.AddWithValue("@bed", bed);
                command.Parameters.AddWithValue("@bath", bath);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@unitNo", unitNo);
                command.Parameters["@unitNo"].Value = unitNo;

                //open connections
                conn.Open();

                command.ExecuteNonQuery();

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                unitTxtBox.Text = row.Cells[0].Value.ToString();
                typeTxtBox.Text = row.Cells[1].Value.ToString();
                adultsTxtBox.Text = row.Cells[2].Value.ToString();
                childTxtBox.Text = row.Cells[3].Value.ToString();
                bedTxtBox.Text = row.Cells[4].Value.ToString();
                bathTxtBox.Text = row.Cells[5].Value.ToString();
                statusTxtBox.Text = row.Cells[6].Value.ToString();

            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            //Variable
            string unitNo = unitTxtBox.Text;

            //sql query variable 
            string sql = "DELETE FROM Room WHERE Unit_Number = @unitNo";

            try
            {
                OleDbConnection conn = new OleDbConnection(connectionString);

                OleDbCommand command = new OleDbCommand(sql, conn);

                command.Parameters.AddWithValue("@unitNo", unitNo);
                command.Parameters["@unitNo"].Value = unitNo;

                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Deletion Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            DisplayBtn.PerformClick();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            unitTxtBox.Text = "";
            typeTxtBox.Text = "";
            adultsTxtBox.Text = "";
            childTxtBox.Text = "";
            bedTxtBox.Text = "";
            bathTxtBox.Text = "";
            statusTxtBox.Text = "";
        }
    }
}
