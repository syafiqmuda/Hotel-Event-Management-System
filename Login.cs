using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _PDIE__Hotel_Event_Management_System_v._2
{
    public partial class Login : Form
    {
        //Database Connection
        MySqlConnection connection = new MySqlConnection("datasource = localhost; port=3306;Initial Catalog = 'hoteleventmanagement'; username=root;password=");
        MySqlCommand command;

        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public void executeMyQuery(string query)
        {
            try
            {
                openConnection();
                command = new MySqlCommand(query, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Executed");
                }

                else
                {
                    MessageBox.Show("Query Not Executed");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Query = "SELECT Authentication FROM loginprofile where Username = '" + txtUsername.Text + "' and Password = '" + txtPassword.Text + "'";

            //Save to Table
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(Query, connection);
            adapter.Fill(table);

            //Process
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please Fill All The Blank.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Clear();
                txtUsername.Clear();
                return;
            }

            else
            {
                if (table.Rows[0][0].ToString() == "Admin")
                {
                    MainMenuAdmin Admin = new MainMenuAdmin();
                    Admin.Show();
                    this.Hide();
                }

                else if (table.Rows[0][0].ToString() == "Staff")
                {
                    MainMenuStaff Staff = new MainMenuStaff();
                    Staff.Show();
                    this.Hide();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConnectionTest_Click(object sender, EventArgs e)
        {
            MainMenuStaff Staff = new MainMenuStaff();
            Staff.Show();
            this.Hide();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
