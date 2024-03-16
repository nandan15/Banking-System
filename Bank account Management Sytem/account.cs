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

namespace Bank_account_Management_Sytem
{
    public partial class account : Form
    {
        public account()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nandan\Documents\BAMSDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            int bal = 0;
            if (AccNameTb.Text == "" || AccNumTb.Text == "" || FanameTb.Text == "" || Phonetb.Text == "" || AddressTb.Text == "" || occupationtb.Text == "" || pintb.Text == "") 
            {
                MessageBox.Show("Missing Information");
            }else
            { 
             try
                {
                    Con.Open();
                    string query = "insert into AccountTbl values('" + AccNumTb.Text + "','" + AccNameTb.Text + "','" + FanameTb.Text + "','" + dobdate.Value.Date + "','" + Phonetb.Text + "','" + AddressTb.Text + "','" + educationtb.SelectedItem.ToString() + "','" + occupationtb.Text + "'," + pintb.Text + "," + bal + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully");
                    Con.Close();
                    Login log = new Login();
                    log.Show();
                    this.Hide();
                } catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void account_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            anima2.ShowSync(log);
            this.Hide();
        }
    }
}
