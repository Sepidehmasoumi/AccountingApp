
namespace AccountingProject
{
    partial class DebtMangmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.dataGridViewDebts = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtAmont = new System.Windows.Forms.TextBox();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.chkIsPaid = new System.Windows.Forms.CheckBox();
            this.chekNotPaid = new System.Windows.Forms.CheckBox();
            this.txtDebtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDebts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDebtID);
            this.groupBox1.Controls.Add(this.chekNotPaid);
            this.groupBox1.Controls.Add(this.chkIsPaid);
            this.groupBox1.Controls.Add(this.dtpDueDate);
            this.groupBox1.Controls.Add(this.txtAmont);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.btnHome);
            this.groupBox1.Controls.Add(this.dataGridViewDebts);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 616);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مدیریت بدهی ها";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(121, 554);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(377, 26);
            this.btnHome.TabIndex = 27;
            this.btnHome.Text = "بازگشت به صفحه اصلی";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // dataGridViewDebts
            // 
            this.dataGridViewDebts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDebts.Location = new System.Drawing.Point(26, 255);
            this.dataGridViewDebts.Name = "dataGridViewDebts";
            this.dataGridViewDebts.RowHeadersWidth = 51;
            this.dataGridViewDebts.RowTemplate.Height = 24;
            this.dataGridViewDebts.Size = new System.Drawing.Size(571, 271);
            this.dataGridViewDebts.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Location = new System.Drawing.Point(242, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "حذف";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSave.Location = new System.Drawing.Point(402, 204);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 31);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "افزودن";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnShow.Location = new System.Drawing.Point(95, 204);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(113, 31);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "نمایش بدهی ها";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(118, 61);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(479, 22);
            this.txtDescription.TabIndex = 28;
            // 
            // txtAmont
            // 
            this.txtAmont.Location = new System.Drawing.Point(118, 89);
            this.txtAmont.Name = "txtAmont";
            this.txtAmont.Size = new System.Drawing.Size(479, 22);
            this.txtAmont.TabIndex = 29;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Location = new System.Drawing.Point(98, 129);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDueDate.TabIndex = 30;
            // 
            // chkIsPaid
            // 
            this.chkIsPaid.AutoSize = true;
            this.chkIsPaid.Location = new System.Drawing.Point(211, 169);
            this.chkIsPaid.Name = "chkIsPaid";
            this.chkIsPaid.Size = new System.Drawing.Size(87, 21);
            this.chkIsPaid.TabIndex = 31;
            this.chkIsPaid.Text = "پرداخت شده";
            this.chkIsPaid.UseVisualStyleBackColor = true;
            // 
            // chekNotPaid
            // 
            this.chekNotPaid.AutoSize = true;
            this.chekNotPaid.Location = new System.Drawing.Point(98, 169);
            this.chekNotPaid.Name = "chekNotPaid";
            this.chekNotPaid.Size = new System.Drawing.Size(90, 21);
            this.chekNotPaid.TabIndex = 32;
            this.chekNotPaid.Text = "پرداخت نشده";
            this.chekNotPaid.UseVisualStyleBackColor = true;
            // 
            // txtDebtID
            // 
            this.txtDebtID.Location = new System.Drawing.Point(118, 36);
            this.txtDebtID.Name = "txtDebtID";
            this.txtDebtID.Size = new System.Drawing.Size(479, 22);
            this.txtDebtID.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "شناسه بدهی";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "توضیحات بدهی";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "مبلغ بدهی";
            // 
            // DebtMangmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 634);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DebtMangmentForm";
            this.Text = "DebtMangmentForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDebts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DataGridView dataGridViewDebts;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.CheckBox chkIsPaid;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.TextBox txtAmont;
        private System.Windows.Forms.CheckBox chekNotPaid;
        private System.Windows.Forms.TextBox txtDebtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}