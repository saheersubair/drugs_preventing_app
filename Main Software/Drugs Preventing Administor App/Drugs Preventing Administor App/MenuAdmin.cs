using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drugs_Preventing_Administor_App
{
    public partial class MenuAdmin : Form
    {
        int pid;

        public MenuAdmin(int pid2)
        {
            InitializeComponent();
            pid = pid2;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPersoncomplain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Complains complains = new Complains(pid);
            complains.Show();
                
        }

        private void btnPlacecomplain_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlaceComplian placeComplian = new PlaceComplian(pid);
            placeComplian.Show();
            
        }

        private void btnOthercomplain_Click(object sender, EventArgs e)
        {
            this.Hide();
            OtherComplain otherComplain = new OtherComplain(pid);
            otherComplain.Show();
            
        }

        private void btnAdduser_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageUser manageUser = new ManageUser(pid);
            manageUser.Show();
            
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePassword changePassword = new ChangePassword(pid);
            changePassword.Show();
        }

        private void btnPublic_Click(object sender, EventArgs e)
        {
            this.Hide();
            PublicProfileManagement publicProfileManagement = new PublicProfileManagement(pid);
            publicProfileManagement.Show();
        }
    }
}
