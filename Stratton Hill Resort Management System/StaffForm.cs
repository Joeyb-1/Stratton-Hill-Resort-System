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
    public partial class StaffForm : Form
    {
        String connectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Yusuf\Documents\Stratton Hill Resort Database.mdb";
        public StaffForm()
        {
            InitializeComponent();
        }

        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            //Sql query variable
            string sql = "SELECT * from Staff";

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
            string staffID = idTxtBox.Text;
            string resortID = resTxtBox.Text;
            string name = nameTxtBox.Text;
            string surname = surnameTxtBox.Text;
            string role = roleTxtBox.Text;
            string phone = phoneTxtBox.Text;
            string email = emailTxtBox.Text;
            string bankName = bankTxtBox.Text;
            string bankAccNo = baccTxtBox.Text;
            string bankBranch = bbranchTxtBox.Text;
            string nationalID = natTxtBox.Text;

            //Sql query variable
            string sql = "insert into Staff (Staff_ID,Resort_ID,First_Name,Last_Name,Role,Phone_Number,Email,Bank_Name,Bank_AccNo,Bank_BranchNo,ID_Number) VALUES (@Staff_ID,@Resort_ID,@First_Name,@Last_Name,@Role,@Phone_Number,@Email,@Bank_Name,@Bank_AccNo,@Bank_BranchNo,@ID_Number)";

            try
            {
                //Opening connection
                OleDbConnection conn = new OleDbConnection(connectionString);

                //Declaring Variable
                OleDbCommand command = new OleDbCommand(sql, conn);

                command.Parameters.AddWithValue("@Staff_ID", staffID);
                command.Parameters.AddWithValue("@Resort_ID", resortID);
                command.Parameters.AddWithValue("@First_Name", name);
                command.Parameters.AddWithValue("@Last_Name", surname);
                command.Parameters.AddWithValue("@Role", role);
                command.Parameters.AddWithValue("@Phone_Number", phone);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Bank_Name", bankName);
                command.Parameters.AddWithValue("@Bank_AccNo", bankAccNo);
                command.Parameters.AddWithValue("@Bank_BranchNo", bankBranch);
                command.Parameters.AddWithValue("@ID_Number", nationalID);

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
            string staffID = idTxtBox.Text;
            string resortID = resTxtBox.Text;
            string name = nameTxtBox.Text;
            string surname = surnameTxtBox.Text;
            string role = roleTxtBox.Text;
            string phone = phoneTxtBox.Text;
            string email = emailTxtBox.Text;
            string bankName = bankTxtBox.Text;
            string bankAccNo = baccTxtBox.Text;
            string bankBranch = bbranchTxtBox.Text;
            string nationalID = natTxtBox.Text;

            //sql query variable 
            string sql = "UPDATE Staff SET Resort_ID = @Resort_ID,First_Name = @First_Name,Last_Name = @Last_Name,Role = @Role,Phone_Number = @Phone_Number,Email = @Email ,Bank_Name = @Bank_Name,Bank_AccNo = @Bank_AccNo,Bank_BranchNo = @Bank_BranchNo, ID_Number = @ID_Number  WHERE Staff_ID = @Staff_ID";

            try
            {
                //Connect
                OleDbConnection conn = new OleDbConnection(connectionString);

                OleDbCommand command = new OleDbCommand(sql, conn);

                command.Parameters.AddWithValue("@Resort_ID", resortID);
                command.Parameters.AddWithValue("@First_Name", name);
                command.Parameters.AddWithValue("@Last_Name", surname);
                command.Parameters.AddWithValue("@Role", role);
                command.Parameters.AddWithValue("@Phone_Number", phone);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Bank_Name", bankName);
                command.Parameters.AddWithValue("@Bank_AccNo", bankAccNo);
                command.Parameters.AddWithValue("@Bank_BranchNo", bankBranch);
                command.Parameters.AddWithValue("@ID_Number", nationalID);
                command.Parameters.AddWithValue("@Staff_ID", staffID);
                command.Parameters["@Staff_ID"].Value = staffID;

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
                idTxtBox.Text = row.Cells[0].Value.ToString();
                resTxtBox.Text = row.Cells[1].Value.ToString();
                nameTxtBox.Text = row.Cells[2].Value.ToString();
                surnameTxtBox.Text = row.Cells[3].Value.ToString();
                roleTxtBox.Text = row.Cells[4].Value.ToString();
                phoneTxtBox.Text = row.Cells[5].Value.ToString();
                emailTxtBox.Text = row.Cells[6].Value.ToString();
                bankTxtBox.Text = row.Cells[7].Value.ToString();
                baccTxtBox.Text = row.Cells[8].Value.ToString();
                bbranchTxtBox.Text = row.Cells[9].Value.ToString();
                natTxtBox.Text = row.Cells[10].Value.ToString();

            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            //Variable
            string id = idTxtBox.Text;

            //sql query variable 
            string sql = "DELETE FROM Staff WHERE Staff_ID = @Staff_ID";

            try
            {
                OleDbConnection conn = new OleDbConnection(connectionString);

                OleDbCommand command = new OleDbCommand(sql, conn);

                command.Parameters.AddWithValue("@Staff_ID", id);
                command.Parameters["@Staff_ID"].Value = id;

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
            idTxtBox.Text ="";
            resTxtBox.Text="";
            nameTxtBox.Text="";
            surnameTxtBox.Text="";
            roleTxtBox.Text="";
            phoneTxtBox.Text="";
            emailTxtBox.Text="";
            bankTxtBox.Text="";
            baccTxtBox.Text="";
            bbranchTxtBox.Text="";
            natTxtBox.Text="";
        }
    } 
}
