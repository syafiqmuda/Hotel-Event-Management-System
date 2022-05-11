using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _PDIE__Hotel_Event_Management_System_v._2
{
    public partial class MainMenuStaff : Form
    {
        public MainMenuStaff()
        {
            InitializeComponent();
        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            EventReservationMenu Menu = new EventReservationMenu();
            Menu.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
