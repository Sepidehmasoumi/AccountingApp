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
    public partial class AccountingSummaryForm : Form
    {
        string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sepideh\source\repos\AccountingProject\AccountingProject\AccountingApp.mdf;Integrated Security=True";
        SqlConnection connection;
        public AccountingSummaryForm()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionstring);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            { 
            string reportContent = txtReport.Text;
            DateTime startDate = dtpStartData.Value;
            DateTime endDate = dtpEndData.Value;
            connection.Open();
            string query = "INSERT INTO ReportTable ([متن گزارش], [تاریخ شروع], [تاریخ پایان]) VALUES (@reportContent, @startDate, @endDate)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@reportContent", reportContent);
            command.Parameters.AddWithValue("@startDate", startDate);
            command.Parameters.AddWithValue("@endDate", endDate);
            int result = command.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("گزارش با موفقیت ثبت شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ثبت گزارش انجام نشد. لطفاً دوباره امتحان کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("خطا در ثبت گزارش: " + sqlEx.Message, "خطای SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در ثبت گزارش: " + ex.Message, "خطای عمومی", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int reportID = int.Parse(txtReportID.Text);
                connection.Open();
                string query = "DELETE FROM ReportTable WHERE [شناسه گزارش] = @reportID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@reportID", reportID);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("گزارش با موفقیت حذف شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("حذف گزارش انجام نشد. لطفاً دوباره امتحان کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("خطا در حذف گزارش: " + sqlEx.Message, "خطای SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در حذف گزارش: " + ex.Message, "خطای عمومی", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtReportID.Text = "";
            txtReport.Text = "";
            dtpStartData.Value = DateTime.Now;
            dtpEndData.Value = DateTime.Now;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime startDate = dtpStartData.Value;
                DateTime endDate = dtpEndData.Value;
                connection.Open();
                string query = "SELECT * FROM ReportTable WHERE [تاریخ شروع] BETWEEN @startDate AND @endDate";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@startDate", startDate);
                command.Parameters.AddWithValue("@endDate", endDate);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("خطا در بارگذاری گزارش : " + sqlEx.Message, "خطای SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در بارگذاری گزارش : " + ex.Message, "خطای عمومی", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
        }
    }
}
 
