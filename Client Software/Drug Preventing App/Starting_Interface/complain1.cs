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
    public partial class complain1 : Form
    {
        String username;

        public complain1(String username2)
        {
            InitializeComponent();
            username = username2;
        }

        private void btnDrug_Click(object sender, EventArgs e)
        {
            this.Hide();

            Complain2Drug complain2 = new Complain2Drug(username);

            complain2.Show();
        
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu menu = new Menu(username);

            menu.Show();
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            this.Hide();

            complain_Form_Other complain_Form_Other = new complain_Form_Other(username);

            complain_Form_Other.Show();
        }
    }
}
