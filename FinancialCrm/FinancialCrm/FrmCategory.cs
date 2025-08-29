using FinancialCrm.Models;
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

namespace FinancialCrm
{
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
            

        }
        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            var totelCategory = db.Categories.Count().ToString();
            lblTotalCategory.Text = totelCategory.ToString();
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCategoryList_Click(object sender, EventArgs e)
        {
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;

        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            string title = txtCategoryName.Text;
            Categories categories = new Categories();
            categories.CategoryName = txtCategoryName.Text;
            db.Categories.Add(categories);
            db.SaveChanges();
            MessageBox.Show("Kategori Ekleme İşlemi Başarılı", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCategoryRemove_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var removeValue = db.Categories.Find(id);
            db.Categories.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Kategori Silme İşlemi Başarılı", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Categories.ToList();
            dataGridView1.DataSource=values;
        }

        private void btnCategoryUpdate_Click(object sender, EventArgs e)
        {
            string categoryname = txtCategoryName.Text;
            int id = int.Parse(txtCategoryId.Text);

            var values = db.Categories.Find(id);
            values.CategoryName = categoryname;
            db.SaveChanges();
            MessageBox.Show("Kategori Güncelleme İşlemi Başarılı", "Ödeme&Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values2 = db.Categories.ToList();
            dataGridView1.DataSource= values2;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkış başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Login sayfasını aç
            FrmLogin loginForm = new FrmLogin();
            loginForm.Show();

            // Bu formu kapat
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategory frm = new FrmCategory();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmExpenses frm = new FrmExpenses();
            frm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmBankMotion frm = new FrmBankMotion();
            frm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }
    }
}
