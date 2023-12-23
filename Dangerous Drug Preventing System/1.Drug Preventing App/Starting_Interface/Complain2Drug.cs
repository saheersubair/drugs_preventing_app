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
    public partial class Complain2Drug : Form
    {

        String username;

        public Complain2Drug(String username2)
        {
            InitializeComponent();
            username = username2;
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            this.Hide();

            complain_Form_Victim ComplainPerson1 = new complain_Form_Victim(username);

            ComplainPerson1.Show();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            complain1 complain1 = new complain1(username);
            complain1.Show();
        }

        private void btnPlace_Click(object sender, EventArgs e)
        {
            this.Hide();
            complain_Form_Place complainplace = new complain_Form_Place(username);
            complainplace.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            complain_Form_Drug_Dealer drugDealer = new complain_Form_Drug_Dealer(username);
            drugDealer.Show();
        }

        private void Complain2Drug_Load(object sender, EventArgs e)
        {

        }
    }
}
