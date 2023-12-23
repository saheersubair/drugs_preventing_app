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
    public partial class ThankYou_Final : Form
    {
        String username;

        public ThankYou_Final(String username2)
        {
            InitializeComponent();
            username = username2;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(username);
            menu.Show();       
        }
    }
}
