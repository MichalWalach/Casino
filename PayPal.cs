﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasyno
{
    public partial class PayPal : Form
    {
        Dashboard dashboard;
        int balance;
        public PayPal(Dashboard dash, int money)
        {
            InitializeComponent();
            dashboard = dash;
            balance = money;
        }

        private void buy_100_Click(object sender, EventArgs e)
        {
            balance += 100;
            MessageBox.Show("100 Credits Added", "Credits Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void PayPal_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard.change_balance(balance);
            dashboard.Show();
        }

        private void buy_500_Click(object sender, EventArgs e)
        {
            balance += 500;
            MessageBox.Show("500 Credits Added", "Credits Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void buy_1000_Click(object sender, EventArgs e)
        {
            balance += 1000;
            MessageBox.Show("1000 Credits Added", "Credits Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void buy_5000_Click(object sender, EventArgs e)
        {
            balance += 5000;
            MessageBox.Show("5000 Credits Added", "Credits Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void buy_10000_Click(object sender, EventArgs e)
        {
            balance += 10000;
            MessageBox.Show("10000 Credits Added", "Credits Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

    }
}
