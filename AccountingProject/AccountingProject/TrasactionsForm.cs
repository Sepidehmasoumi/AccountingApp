using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingProject
{
    public partial class TrasactionsForm : Form
    {
        public TrasactionsForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int CustomerID = int.Parse(txtCustomerID.Text);
                DateTime Date = DateTime.Parse(txtDate.Text);
                float Amount = float.Parse(txtAmount.Text);
                string Details = txtDetails.Text;
                string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sepideh\source\repos\AccountingProject\AccountingProject\AccountingApp.mdf;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();
                string query = "INSERT INTO Transactions ([آیدی مشتری], [تاریخ], [مبلغ], [جزئیات]) VALUES (@CustomerID, @Date, @Amount, @Details)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerID", CustomerID);
                command.Parameters.AddWithValue("@Date", Date);
                command.Parameters.AddWithValue("@Amount", Amount);
                command.Parameters.AddWithValue("@Details", Details);
                command.ExecuteNonQuery();
                MessageBox.Show("تراکنش با موفقیت اضافه شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در افزودن تراکنش: " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int TransactionID = int.Parse(txtID.Text);
                int CustomerID = int.Parse(txtCustomerID.Text);
                DateTime Date = DateTime.Parse(txtDate.Text);
                float Amount = float.Parse(txtAmount.Text);
                string Details = txtDetails.Text;
                string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sepideh\source\repos\AccountingProject\AccountingProject\AccountingApp.mdf;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();
                string query = "UPDATE Transactions SET [آیدی مشتری] = @CustomerID, [تاریخ] = @Date, [مبلغ] = @Amount, [جزئیات] = @Details WHERE [آیدی تراکنش] = @TransactionID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TransactionID", TransactionID);
                command.Parameters.AddWithValue("@CustomerID", CustomerID);
                command.Parameters.AddWithValue("@Date", Date);
                command.Parameters.AddWithValue("@Amount", Amount);
                command.Parameters.AddWithValue("@Details", Details);
                command.ExecuteNonQuery();
                MessageBox.Show("تراکنش با موفقیت به‌روز شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در ویرایش تراکنش: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int TransactionID = int.Parse(txtID.Text);
                string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sepideh\source\repos\AccountingProject\AccountingProject\AccountingApp.mdf;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();
                string query = "DELETE FROM Transactions WHERE [آیدی تراکنش] = @TransactionID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TransactionID", TransactionID);
                command.ExecuteNonQuery();
                MessageBox.Show("تراکنش با موفقیت حذف شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در حذف تراکنش: " + ex.Message);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sepideh\source\repos\AccountingProject\AccountingProject\AccountingApp.mdf;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();
                string query = "SELECT [آیدی تراکنش], [آیدی مشتری], [تاریخ], [مبلغ], [جزئیات] FROM Transactions";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در بارگذاری تراکنش‌ها: " + ex.Message);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtCustomerID.Text = "";
            txtDate.Text = "";
            txtAmount.Text = "";
            txtDetails.Text = "";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
        }
    }
}
