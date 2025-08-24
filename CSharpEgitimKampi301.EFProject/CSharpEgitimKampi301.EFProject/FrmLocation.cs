using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject

{
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGetById_Click(object sender, EventArgs e)
        {

        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var guides = db.Guide
                     .Select(g => new
                     {
                         GuideId = g.GuideId,
                         FullName = g.GuideName + " " + g.GuideSurname
                     })
                     .ToList();

            cmbGuide.DisplayMember = "FullName";   // ekranda görünen kısım
            cmbGuide.ValueMember = "GuideId";      // arka planda tutulan değer (int)
            cmbGuide.DataSource = guides;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Location.ToList();
            dataGridView1.DataSource=values;


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.Capacity = byte.Parse(nudCapacity.Value.ToString());
            location.City = txtCity.Text;
            location.Country = txtCountry.Text;
            location.Price = decimal.Parse(txtPrice.Text);
            location.DayNight = txtDaynight.Text;
            location.GuideId =int.Parse(cmbGuide.SelectedValue.ToString());
            db.Location.Add(location);
            db.SaveChanges();
            MessageBox.Show("Ekleme İşlemi Başarılı");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deleteValue = db.Location.Find(id);
            db.Location.Remove(deleteValue);
            db.SaveChanges();
            MessageBox.Show("Silme İşlemi Başarılı");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id= int.Parse(txtId.Text);
            var updateValue = db.Location.Find(id);
            updateValue.DayNight=txtDaynight.Text;
            updateValue.Price=decimal.Parse(txtPrice.Text);
            updateValue.Capacity=byte.Parse(nudCapacity.Value.ToString());
            updateValue.City=txtCity.Text;
            updateValue.Country=txtCountry.Text;
            updateValue.GuideId=int.Parse(cmbGuide.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Güncelleme  İşlemi Başarılı");
        }
    }
}
