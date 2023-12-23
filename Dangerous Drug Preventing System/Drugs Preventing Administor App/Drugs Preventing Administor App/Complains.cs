using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Drugs_Preventing_Administor_App
{
    public partial class Complains : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S0O97TN\ZAHEERSQL;Initial Catalog=DrugPreventingApp;Integrated Security=True");
        SqlCommand com;
        SqlDataReader dr;

        int pid;
        public Complains(int pid2)
        {
            InitializeComponent();
            pid = pid2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            con.Open();
            string sql = "SELECT * FROM AdminTable WHERE PoliceID = '" + pid + "'";
            com = new SqlCommand(sql, con);
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                string post = dr["Position"].ToString();
                con.Close();
                if (post == "DIG")
                {
                    this.Hide();
                    MenuAdmin menuAdmin = new MenuAdmin(pid);
                    menuAdmin.Show();
                }
                else if (post == "Constable")
                {
                    this.Hide();
                    MenuUser menuUser = new MenuUser(pid);
                    menuUser.Show();
                }
                else
                {
                    this.Hide();
                    MenuUser menuUser = new MenuUser(pid);
                    menuUser.Show();
                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPersoncomplain_Click(object sender, EventArgs e)
        {
            
        }

        private void btndealercomplain_Click(object sender, EventArgs e)
        {
            this.Hide();
            DrugDealerComplain drugDealer = new DrugDealerComplain(pid);
            drugDealer.Show();
        }

        private void btnVictimcomplain_Click(object sender, EventArgs e)
        {
            this.Hide();
            VictimComplain victimComplain = new VictimComplain(pid);
            victimComplain.Show();
        }

        private void btnPlacecomplain_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlaceComplian place = new PlaceComplian(pid);
            place.Show();

        }

        private void btnOthercomplain_Click(object sender, EventArgs e)
        {
            this.Hide();
            OtherComplain other = new OtherComplain(pid);
            other.Show();
        }
    }
}
