using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starting_Interface
{
    public partial class Menu : Form
    {

        String username;

        public Menu(String username2)
        {
            InitializeComponent();
            username = username2;
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            complain1 complain1 = new complain1(username);

            complain1.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure To Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }

            else
            {

            }
            
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            this.Hide();

            Contact_Info contact_Info = new Contact_Info(username);

            contact_Info.Show();

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            this.Hide();

            ProfileSettings help = new ProfileSettings(username);

            help.Show();
        }

        
    }
}
