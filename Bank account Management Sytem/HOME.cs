using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_account_Management_Sytem
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void GunaLabel5_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            Deposit depo = new Deposit();
            depo.Show();
            this.Hide();
        }

        private void BunifuThinButton23_Click(object sender, EventArgs e)
        {
            Withdraw with = new Withdraw();
            with.Show();
            this.Hide();
        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
           Changepin pin = new Changepin();
            pin.Show();
            this.Hide();
        }

        private void BunifuThinButton24_Click(object sender, EventArgs e)
        {
            AccountReview acc = new AccountReview();
            acc.Show();
            this.Hide();
        }

        private void BunifuThinButton25_Click(object sender, EventArgs e)
        {
            Balance bal = new Balance();
            bal.Show();
            this.Hide();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static String AccNumber;
        private void HOME_Load(object sender, EventArgs e)
        {
            AccNumlbl.Text = "Account Number:" + Login.AccNumber;
            AccNumber = Login.AccNumber;
        }
    }
}
