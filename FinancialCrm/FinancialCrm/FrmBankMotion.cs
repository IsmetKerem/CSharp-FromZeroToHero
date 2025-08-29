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
    public partial class FrmBankMotion : Form
    {
        public FrmBankMotion()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();
        private void FrmBankMotion_Load(object sender, EventArgs e)
        {
            var last8 = db.BankProcesses
          .OrderByDescending(x => x.ProcessDate)        // en güncel tarih en üstte
          .ThenByDescending(x => x.BankProcessId)       // aynı güne birden fazla varsa id'ye göre
          .Select(x => new
          {
              x.Description,
              x.Amount,
              x.ProcessDate
          })
          .Take(8)
          .ToList();

            var labels = new[]
            {
        lblBankMotionProcess1,
        lblBankMotionProcess2,
        lblBankMotionProcess3,
        lblBankMotionProcess4,
        lblBankMotionProcess5,
        lblBankMotionProcess6,
        lblBankMotionProcess7,
        lblBankMotionProcess8
    };
            for (int i = 0; i < last8.Count && i < labels.Length; i++)
            {
                var p = last8[i];
                labels[i].Text = $"{p.Description}  {p.Amount:#,0.00}  {p.ProcessDate:dd.MM.yyyy}";
                // TR format istiyorsan: {p.Amount.ToString("N2", new CultureInfo("tr-TR"))}
            }


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
