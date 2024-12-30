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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtUserName.Text;
                string userAddress = txtUserAddress.Text;
                string userPhone = txtUserPhone.Text;
                string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sepideh\source\repos\AccountingProject\AccountingProject\AccountingApp.mdf;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();
                string query = "INSERT INTO USERS ([نام کاربر], [آدرس کاربر], [شماره تماس کاربر]) VALUES (@userName, @userAddress, @userPhone)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@userName", userName);
                command.Parameters.AddWithValue("@userAddress", userAddress);
                command.Parameters.AddWithValue("@userPhone", userPhone);
                command.ExecuteNonQuery();
                MessageBox.Show("کاربر با موفقیت اضافه شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در افزودن کاربر: " + ex.Message);
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            try
            {
                int UserID = int.Parse(txtUserID.Text);
                string UserName = txtUserName.Text;
                string UserAddress = txtUserAddress.Text;
                string UserPhone = txtUserPhone.Text;
                string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sepideh\source\repos\AccountingProject\AccountingProject\AccountingApp.mdf;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();
                string query = "UPDATE USERS SET [نام کاربر] = @UserName, [آدرس کاربر] = @UserAddress, [شماره تماس کاربر] = @UserPhone WHERE [آیدی کاربر] = @UserID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", UserID);
                command.Parameters.AddWithValue("@UserName", UserName);
                command.Parameters.AddWithValue("@UserAddress", UserAddress);
                command.Parameters.AddWithValue("@UserPhone", UserPhone);
                command.ExecuteNonQuery();
                MessageBox.Show("اطلاعات کاربر با موفقیت به‌روز شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در ویرایش کاربر: " + ex.Message);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                int UserID = int.Parse(txtUserID.Text);
                string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sepideh\source\repos\AccountingProject\AccountingProject\AccountingApp.mdf;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();
                string query = "DELETE FROM USERS WHERE [آیدی کاربر] = @UserID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", UserID);
                command.ExecuteNonQuery();
                MessageBox.Show("کاربر با موفقیت حذف شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در حذف کاربر: " + ex.Message);
            }
        }

        private void btnShowUser_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sepideh\source\repos\AccountingProject\AccountingProject\AccountingApp.mdf;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();
                string query = "SELECT [آیدی کاربر], [نام کاربر], [آدرس کاربر], [شماره تماس کاربر] FROM USERS";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewUsers.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در بارگذاری کاربران: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUserID.Text = "";
            txtUserName.Text = "";
            txtUserAddress.Text = "";
            txtUserPhone.Text = "";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
        }
    }
}

