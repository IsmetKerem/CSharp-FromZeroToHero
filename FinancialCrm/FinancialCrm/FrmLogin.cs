using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace FinancialCrm
{
    public partial class FrmLogin : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void btnUserLogin_Click(object sender, EventArgs e)
        {
            string user = txtLoginUserName.Text;
            string password = txtLoginPassword.Text;
            con = new SqlConnection("Data Source=localhost; Initial Catalog=FinancialCrmDb; Integrated Security=true");
            com = new  SqlCommand();
            con.Open();
            com.Connection = con;
            com = new SqlCommand("SELECT * FROM Users WHERE userName=@u AND userPassword=@p", con);
            com.Parameters.AddWithValue("@u", txtLoginUserName.Text);
            com.Parameters.AddWithValue("@p", txtLoginPassword.Text);

            dr = com.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler Giriş Başarılı");
                FrmDashboard gecis = new FrmDashboard();
                gecis.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Lütfen Tekrar Deneyiniz.");
            }
            con.Close();



        }
    }
}
