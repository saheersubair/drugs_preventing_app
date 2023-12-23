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
    public partial class MenuUser : Form
    {
        int pid;
        public MenuUser(int pid2)
        {
            InitializeComponent();
            pid = pid2;
        }

        private void MenuUser_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btncomplain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Complains complains = new Complains(pid);
            complains.Show();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePassword changePassword = new ChangePassword(pid);
            changePassword.Show();
        }
    }
}
