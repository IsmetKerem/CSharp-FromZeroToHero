using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            
            LblLocationCount.Text = db.Location.Count().ToString();
            LblSumCapacity.Text = db.Location.Sum(x => x.Capacity).ToString();
            LblGuideCount.Text = db.Guide.Count().ToString();
            LblAvgCapacity.Text = db.Location.Average(x=> x.Capacity).ToString();
            LblLocationPrice.Text=db.Location.Average(x=> x.Price).ToString()+"₺";
            int lastCountryId = db.Location.Max(x => x.LocationId);
            LblLastCountryName.Text = db.Location.Where(x => x.LocationId == lastCountryId).Select(y => y.Country).FirstOrDefault();
            LblCappadociaLocationCapacity.Text = db.Location.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();
            LblTurkiyeCapacityAvg.Text = db.Location.Where(x=>x.Country=="Türkiye").Average(y=>y.Capacity).ToString();
            var romeguideId = db.Location.Where(x => x.City == "Roma Turistik").Select(y => y.GuideId).FirstOrDefault();
            LblRomeGuideName.Text = db.Guide.Where(x => x.GuideId == romeguideId).Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString();
            var maxCapacity = db.Location.Max(x => x.Capacity);
            LblMaxCapacityLocation.Text = db.Location.Where(x => x.Capacity == maxCapacity).Select(y => y.City).FirstOrDefault().ToString();
            var maxPrice = db.Location.Max(x => x.Price);
            LblMaxPriceLocation.Text=db.Location.Where(x=>x.Price==maxPrice).Select(y=>y.City).FirstOrDefault().ToString();
            var guideİdByNameAysegülCinar=db.Guide.Where(x=>x.GuideName=="Ayşegül"&& x.GuideSurname=="Çınar").Select(y=>y.GuideId).FirstOrDefault();
            LblAysegulCinarLocationCount.Text = db.Location.Where(x => x.GuideId == guideİdByNameAysegülCinar).Count().ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void label11_Click(object sender, EventArgs e)
        {
            // Buraya tıklanınca olacak işlemleri yaz
            MessageBox.Show("Label11 tıklandı!");
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
