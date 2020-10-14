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
    public partial class ClientForm : Form
    {
        String connectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Yusuf\Documents\Stratton Hill Resort Database.mdb";

        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            dateTxtBox.Mask = "####/##/##";
        }

        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            //Sql query variable
            string sql = "select * from Client";

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
            string id = idTxtBox.Text;
            string name = nameTxtBox.Text;
            string surname = surnameTxtBox.Text;
            string username = usernameTxtBox.Text;
            string email = emailTxtBox.Text;
            string phone = phoneTxtBox.Text;
            string birthdate = dateTxtBox.Text;

            //Sql query variable
            string sql = "insert into Client (Client_ID,First_Name,Last_Name,Username,Email,Phone_Number,Birth_Date) VALUES (@Client_ID,@First_Name,@Last_Name, @Username, @Email, @Phone_Number, @Birth_Date)";

            try
            {
                //Opening connection
                OleDbConnection conn = new OleDbConnection(connectionString);

                //Declaring Variable
                OleDbCommand command = new OleDbCommand(sql, conn);

                command.Parameters.AddWithValue("@Client_ID", id);
                command.Parameters.AddWithValue("@First_Name", name);
                command.Parameters.AddWithValue("@Last_Name", surname);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Phone_Number", phone);
                command.Parameters.AddWithValue("@Birth_Date", birthdate);

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
            string id = idTxtBox.Text;
            string name = nameTxtBox.Text;
            string surname = surnameTxtBox.Text;
            string username = usernameTxtBox.Text;
            string email = emailTxtBox.Text;
            string phone = phoneTxtBox.Text;
            string birthdate = dateTxtBox.Text;

            //sql query variable 
            string sql = "UPDATE Client SET First_Name = @First_Name, Last_Name = @Last_Name, Username = @Username, Email = @Email, Phone_Number = @Phone_Number, Birth_Date = @Birth_Date WHERE Client_ID = @Client_ID";

            try
            {
                //Connect
                OleDbConnection conn = new OleDbConnection(connectionString);

                OleDbCommand command = new OleDbCommand(sql, conn);

                command.Parameters.AddWithValue("@First_Name", name);
                command.Parameters.AddWithValue("@Last_Name", surname);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Phone_Number", phone);
                command.Parameters.AddWithValue("@Birth_Date", birthdate);
                command.Parameters.AddWithValue("@Client_ID", id);
                command.Parameters["@Client_ID"].Value = id;

                //open connections
                conn.Open();

                command.ExecuteNonQuery();

                //close connection
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                idTxtBox.Text = row.Cells[0].Value.ToString();
                nameTxtBox.Text = row.Cells[1].Value.ToString();
                surnameTxtBox.Text = row.Cells[2].Value.ToString();
                usernameTxtBox.Text = row.Cells[3].Value.ToString();
                emailTxtBox.Text = row.Cells[4].Value.ToString();
                phoneTxtBox.Text = row.Cells[5].Value.ToString();
                dateTxtBox.Text = row.Cells[6].Value.ToString();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            //Variable
            string id = idTxtBox.Text;

            //sql query variable 
            string sql = "DELETE FROM Client WHERE Client_ID = @Client_ID";

            try
            {
                OleDbConnection conn = new OleDbConnection(connectionString);

                OleDbCommand command = new OleDbCommand(sql, conn);

                command.Parameters.AddWithValue("@Client_ID", id);
                command.Parameters["@Client_ID"].Value = id;

                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }


        }
    }
}
