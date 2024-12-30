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
    public partial class DebtMangmentForm : Form
    {
        string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sepideh\source\repos\AccountingProject\AccountingProject\AccountingApp.mdf;Integrated Security=True";
        SqlConnection connection;
        public DebtMangmentForm()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionstring);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string description = txtDescription.Text;
                float amount;
                if (!float.TryParse(txtAmont.Text, out amount))
                {
                    MessageBox.Show("لطفاً مبلغ بدهی را به صورت عددی وارد کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DateTime dueDate = dtpDueDate.Value;
                bool isPaid = chkIsPaid.Checked;
                bool notPaid = chekNotPaid.Checked;

                if (isPaid && notPaid)
                {
                    MessageBox.Show("لطفاً تنها یکی از چک‌باکس‌های پرداخت شده یا پرداخت نشده را انتخاب کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!isPaid && !notPaid)
                {
                    MessageBox.Show("لطفاً وضعیت پرداخت را مشخص کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool paymentStatus = isPaid;

                connection.Open();
                string query = "INSERT INTO Debts ([توضیحات بدهی], [مبلغ], [تاریخ سررسید], [وضعیت پرداخت]) VALUES (@description, @amount, @dueDate, @paymentStatus)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@amount", amount);
                command.Parameters.AddWithValue("@dueDate", dueDate);
                command.Parameters.AddWithValue("@paymentStatus", paymentStatus ? 1 : 0);

                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("بدهی با موفقیت ثبت شد!", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ثبت بدهی انجام نشد. لطفاً دوباره امتحان کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("خطا در ثبت بدهی: " + sqlEx.Message, "خطای SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در ثبت بدهی: " + ex.Message, "خطای عمومی", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                int debtID;
                if (!int.TryParse(txtDebtID.Text, out debtID))
                {
                    MessageBox.Show("لطفاً شناسه بدهی را به صورت عددی وارد کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                connection.Open();
                string query = "DELETE FROM Debts WHERE [شناسه بدهی] = @debtID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@debtID", debtID);

                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("بدهی با موفقیت حذف شد!", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("حذف بدهی انجام نشد. لطفاً دوباره امتحان کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("خطا در حذف بدهی: " + sqlEx.Message, "خطای SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در حذف بدهی: " + ex.Message, "خطای عمومی", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();

            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM Debts";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewDebts.DataSource = dataTable;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("خطا در بارگذاری بدهی‌ها: " + sqlEx.Message, "خطای SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در بارگذاری بدهی‌ها: " + ex.Message, "خطای عمومی", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
        }
    }
}
