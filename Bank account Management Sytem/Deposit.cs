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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        private void GunaLabel5_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nandan\Documents\BAMSDb.mdf;Integrated Security=True;Connect Timeout=30");
        string Acc = Login.AccNumber;
        private void addtransaction()
        {

        
            string TrType = "Deposit";
              try
              {
                Con.Open();
                string query = "insert into TransactionTbl values('" + Acc + "','" + TrType + "'," + DepositAmtTb.Text + ",'" + DateTime.Today .ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                Login log = new Login();
                log.Show();
                this.Hide();
               }
               catch (Exception Ex)
               {
                MessageBox.Show(Ex.Message);
            }
        }
      
        
        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (DepositAmtTb.Text == "" || Convert.ToInt32(DepositAmtTb.Text) <= 0)
            {
                MessageBox.Show("Enter The Amount To Deposit");
            }
            else
            {
               newbalance = oldbalance + Convert.ToInt32(DepositAmtTb.Text);
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance=" + newbalance + " where Accnum='" + Acc + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deposited Sucessfully");
                    Con.Close();
                addtransaction();
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                } catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }
        int oldbalance, newbalance;
        private void getbalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where  AccNum='" + Acc+ "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            oldbalance = Convert.ToInt32( dt.Rows[0][0].ToString());

            Con.Close();
        }
        private void Deposit_Load(object sender, EventArgs e)
        {
            getbalance();
        }
    }
}

