using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingProject
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersForm users = new UsersForm();
            users.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrasactionsForm trasactionsForm = new TrasactionsForm();
            trasactionsForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountingSummaryForm summaryForm = new AccountingSummaryForm();
            summaryForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            DebtMangmentForm debt = new DebtMangmentForm();
            debt.Show();
        }
    }
}
