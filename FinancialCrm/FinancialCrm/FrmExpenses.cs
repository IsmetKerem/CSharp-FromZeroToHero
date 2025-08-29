using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;


namespace FinancialCrm
{
    public partial class FrmExpenses : Form
    {
        public FrmExpenses()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();
        

        private void FrmExpenses_Load(object sender, EventArgs e)
        {
            var values = db.Spendings
    .Select(x => new
    {
        x.SpendingId,
        x.SpendingTitle,
        x.SpendingAmount,
        x.SpendingDate,
        CategoryName = x.Categories.CategoryName
    })
    .ToList();

            dataGridView1.DataSource = values;

            var cats = db.Categories
                .Select(c => new { c.CategoryId, c.CategoryName })
                .OrderBy(c => c.CategoryName)
                .ToList();

            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList; // Elle yazmayı kapat
            cmbCategory.DisplayMember = "CategoryName"; // ekranda görünen
            cmbCategory.ValueMember = "CategoryId";   // DB'ye gidecek olan
            cmbCategory.DataSource = cats;
        }

        private void btnExpensesList_Click(object sender, EventArgs e)
        {

            var values = db.Spendings
     .Select(x => new
     {
         x.SpendingId,
         x.SpendingTitle,
         x.SpendingAmount,
         x.SpendingDate,
         CategoryName = x.Categories.CategoryName
     })
     .ToList();

            dataGridView1.DataSource = values;
        }

        private void btnExpensesAdd_Click(object sender, EventArgs e)
        {
            string expensesTitle = txtExpensesName.Text;
            decimal expensesAmount = decimal.Parse(txtExpensesAmount.Text);
            //string expensesPeriod = txtExpensesDate.Text;
            DateTime expensesPeriod = DateTime.Parse(txtExpensesDate.Text);
            Spendings spendings = new Spendings();
            spendings.SpendingTitle = expensesTitle;
            spendings.SpendingAmount= expensesAmount;
            spendings.SpendingDate = expensesPeriod;
            int categoryId = (int)cmbCategory.SelectedValue;
            var spendings1 = new Spendings
            {
                SpendingTitle = txtExpensesName.Text.Trim(),
                SpendingAmount = expensesAmount,
                SpendingDate = expensesPeriod,
                CategoryId = categoryId              // 🔥 kritik ek
                                                     // eğer modelde sadece navigation varsa:
                                                     // Categories = db.Categories.Find(categoryId)
            };

            
            db.Spendings.Add(spendings1);
            db.SaveChanges();
            MessageBox.Show("Yeni Gider Ekleme İşlemi Başarılı", "Giderler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Spendings
        .Select(x => new
        {
            x.SpendingId,
            x.SpendingTitle,
            x.SpendingAmount,
            x.SpendingDate,
            CategoryName = x.Categories.CategoryName
        })
        .ToList();

            dataGridView1.DataSource = values;
            

        }

        private void btnExpensesRemove_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtExpensesId.Text);
            var removeValue = db.Spendings.Find(id);
            db.Spendings.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Gider Silme İşlemi Başarılı!", "Gider Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Spendings.ToList();
        }

        private void btnExpensesUpdate_Click(object sender, EventArgs e)
        {
           
            string title = txtExpensesName.Text;
            decimal amount = decimal.Parse(txtExpensesAmount.Text);
            DateTime Period = DateTime.Parse(txtExpensesDate.Text);
            int id = int.Parse(txtExpensesId.Text) ;
            int categoryId = (int)cmbCategory.SelectedValue;   // combodan id
           

            var values = db.Spendings.Find(id);
            values.CategoryId = categoryId;
            values.SpendingTitle = title;
            values.SpendingAmount = amount;
            values.SpendingDate = Period;
            db.SaveChanges();
            MessageBox.Show(" Başarılı Bir Şekilde Sistemde Güncellendi", "Ödeme&Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values2 = db.Spendings.ToList();
            dataGridView1.DataSource = values2;
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

        private void btnBanksForm_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
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
