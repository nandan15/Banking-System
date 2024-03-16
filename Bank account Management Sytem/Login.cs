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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            account acc = new account();
            anima1.ShowSync(acc);
            this.Hide();
            
        }
        public static String AccNumber;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nandan\Documents\BAMSDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //'
            
            if (string.IsNullOrEmpty(this.AccNumtb.Text))
            {
                MessageBox.Show("Enter the UserName");
            }
            else if (string.IsNullOrEmpty(this.PinTb.Text))
            {
                MessageBox.Show("Enter the Password");
            }
            else
            {
                Con.Open();
                string query = "select * from AccountTbl where AccNum='" + this.AccNumtb.Text + "' and PIN = '" + this.PinTb.Text + "'";
                SqlCommand cmd;
                cmd = new SqlCommand(query, Con);
                var da = new SqlDataAdapter(cmd);
                var ds = new DataSet();
                da.Fill(ds);
                int a;
                a = ds.Tables[0].Rows.Count;
                if (a == 0)
                {
                    MessageBox.Show("Wrong AccNum or PIN");
                }
                else
                {
                    AccNumber = this.AccNumtb.Text;
                    var home = new Bank_account_Management_Sytem.HOME();
                    home.Show();
                    this.Hide();
                }

                Con.Close();


            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
          if(CheckBox1.Checked)
            {
                PinTb.isPassword = false;
            }else
            {
                PinTb.isPassword = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PinTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void AccNumtb_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
