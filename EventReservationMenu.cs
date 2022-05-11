using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace _PDIE__Hotel_Event_Management_System_v._2
{
    public partial class EventReservationMenu : Form
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
        } // <<==================== Database =================

        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        } // <<==================== Database =================

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
        } // <<==================== Database =================

        public EventReservationMenu()
        {
            InitializeComponent();
        }

        private void EventReservationMenu_Load(object sender, EventArgs e)
        {
            //=========================== Automatic Retrive Data ===============================
            string selectQuery = "SELECT * FROM eventreservation";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView.DataSource = table;


            //========================== RetriveData for cboRoomName ==============================
            connection.Open();
            //Query Command
            MySqlCommand Mycommand = new MySqlCommand();
            Mycommand.Connection = connection;
            Mycommand.CommandText = "SELECT * FROM roomdetails";

            //Data Reader
            MySqlDataReader myReader;

            try
            {
                myReader = Mycommand.ExecuteReader();

                while (myReader.Read())
                {
                    string sName = myReader.GetString("RoomName");
                    cboRoomName.Items.Add(sName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();

            //========================== RetriveData for cboEventPackageName ==========================
            connection.Open();
            //Query Command
            MySqlCommand Mycommand2 = new MySqlCommand();
            Mycommand2.Connection = connection;
            Mycommand2.CommandText = "SELECT * FROM eventpackage";

            //Data Reader
            MySqlDataReader myReader2;

            try
            {
                myReader2 = Mycommand2.ExecuteReader();

                while (myReader2.Read())
                {
                    string sName = myReader2.GetString("PackageName");
                    cboEventPackageName.Items.Add(sName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();

        }

        private void cboRoomName_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            //Query Command
            MySqlCommand Mycommand = new MySqlCommand();
            Mycommand.Connection = connection;
            Mycommand.CommandText = "SELECT * FROM roomdetails WHERE RoomName='" + cboRoomName.Text + "'";

            //Data Reader
            MySqlDataReader myReader;

            try
            {
                myReader = Mycommand.ExecuteReader();

                while (myReader.Read())
                {                    
                    string roomType = myReader.GetString("RoomType");
                    string roomSize = myReader.GetString("RoomSize");
                    string roomMaxPerson = myReader.GetString("RoomMaxPerson");

                    txtRoomType.Text = roomType;
                    txtRoomSize.Text = roomSize;
                    txtRoomPax.Text = roomMaxPerson;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        private void cboEventPackageName_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            //Query Command
            MySqlCommand Mycommand = new MySqlCommand();
            Mycommand.Connection = connection;
            Mycommand.CommandText = "SELECT * FROM eventpackage WHERE PackageName='" + cboEventPackageName.Text + "'";

            //Data Reader
            MySqlDataReader myReader;

            try
            {
                myReader = Mycommand.ExecuteReader();

                while (myReader.Read())
                {
                    string packageDescription = myReader.GetString("PackageDescription");
                    txtEventDescription.Text = packageDescription;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string CBOBOX1 = Convert.ToString(cboRoomName.Text);

            string insertQuery = "INSERT INTO eventreservation(EventID,CustomerName,CustomerIC,CustomerPhone,StartDate,EndDate,PackageName) VALUES('" + txtEventID.Text + "','" + txtCustomerName.Text + "','" + txtCustomerIC.Text + "','" + txtCustomerPhone.Text + "','" + EventStartDate.Text + "','" + EventEndDate.Text + "'," + CBOBOX1 +")";
                //,'" + cboRoomName.SelectedValue + "'," + cboEventPackageName.SelectedValue +")";

            executeMyQuery(insertQuery);
        }
    }
}
