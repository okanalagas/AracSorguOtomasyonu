using _3_SahibindenUygulama.Context;
using _3_SahibindenUygulama.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _3_SahibindenUygulama
{
    public partial class FormList : Form
    {
        public FormList()
        {
            InitializeComponent();
            buttonList_Click(null, new EventArgs());
            panelBrandFill();
            panelModelFill();
            panelYearFill();
            panelColorFill();
            panelCityFill();
        }

        public void panelCityFill()
        {
            int y = 3;
            string cbname = "cbCity";
            var query = (from c in db.Cars
                         orderby c.City
                         group c by c.City into g
                         select new
                         {
                             g.Key
                         }).ToList();
            panelCity.Controls.Clear();
            foreach (var item in query)
            {
                if (item.Key != "")
                {
                    CheckBox c = new CheckBox();
                    c.Text = item.Key.ToString();
                    c.Name = cbname + item.Key.ToString();
                    c.Location = new Point(3, y);
                    y += 20;
                    panelCity.Controls.Add(c);
                }
            }
        }

        public void panelColorFill()
        {
            int y = 3;
            string cbname = "cbColor";
            panelColor.Controls.Clear();
            foreach (var item in db.Colors.OrderBy(i => i.Name))
            {
                CheckBox c = new CheckBox();
                c.Text = item.Name;
                c.Name = cbname + item.Name;
                c.Location = new Point(3, y);
                y += 20;
                panelColor.Controls.Add(c);
            }
        }

        public void panelYearFill()
        {
            string cbname = "cbYear";
            int y = 3;
            for (int year = 2023; year > 1989; year--)
            {
                CheckBox c = new CheckBox();
                c.Text = year.ToString();
                c.Name = cbname + year.ToString();
                c.Location = new Point(3, y);
                y += 20;
                panelYear.Controls.Add(c);
            }

        }

        public void panelModelFill()
        {
            int y = 3;
            string cbname = "cbModel";
            var query = (from c in db.Cars
                         orderby c.Model
                         group c by c.Model into g
                         select new
                         {
                             g.Key
                         }).ToList();
            panelModel.Controls.Clear();
            foreach (var item in query)
            {
                if (item.Key != "")
                {
                    CheckBox c = new CheckBox();
                    c.Text = item.Key.ToString();
                    c.Name = cbname + item.Key.ToString();
                    c.Location = new Point(3, y);
                    y += 20;
                    panelModel.Controls.Add(c);
                }
            }
        }

        public void panelBrandFill()
        {
            int y = 3;
            string cbname = "cbBrand";
            panelBrand.Controls.Clear();
            foreach (var item in db.Brands.OrderBy(i => i.Name))
            {

                CheckBox c = new CheckBox();
                c.Text = item.Name;
                c.Name = cbname + item.Name;
                c.Location = new Point(3, y);
                y += 20;
                panelBrand.Controls.Add(c);
            }
        }

        CarDbContext db = new CarDbContext();
        public void buttonList_Click(object sender, EventArgs e)
        {
            if(sender ==null)
            {
                GridFill();
            }
            else
            {
                DefaultValue();
                GridFill("test");
                ControlClear();
            }       
        }

        private void ControlClear()      //bu metotda filtreleme işlemi sonrası textboxları boşaltma işlemi yaptık.
        {
            tbSearch.Text=tbMaxKm.Text = tbMinKm.Text = tbMinPrice.Text = tbMaxPrice.Text = "";
            foreach(var item in panelBrand.Controls)
            {
                (item as CheckBox).Checked = false;
            }
            foreach (var item in panelModel.Controls)
            {
                (item as CheckBox).Checked = false;
            }
            foreach (var item in panelCity.Controls)
            {
                (item as CheckBox).Checked = false;
            }
            foreach (var item in panelColor.Controls)
            {
                (item as CheckBox).Checked = false;
            }
            foreach (var item in panelYear.Controls)
            {
                (item as CheckBox).Checked = false;
            }
        }

        int minPrice, maxPrice, minKm, maxKm;
        List<string> checkBrand;
        List<string> checkModel;
        List<string> checkYear;
        List<string> checkColor;
        List<string> checkCity;

        private void DefaultValue()     // bu metotda checkboxlar ve textboxlar boş bırakılırsa default değerleri 
        {                               // belirlerdik
            // Brand
            int indexBrand = 0;
            checkBrand = new List<string>();
            foreach (var item in panelBrand.Controls)
            {
                if ((item as CheckBox).Checked == true)
                {
                    checkBrand.Add((item as CheckBox).Text);
                    indexBrand++;
                }
            }
            if (indexBrand == 0)
            {
                foreach (var item in panelBrand.Controls)
                {
                    checkBrand.Add((item as CheckBox).Text);
                }
            }
            // Model
            int indexModel = 0;
            checkModel = new List<string>();
            foreach (var item in panelModel.Controls)
            {
                if ((item as CheckBox).Checked == true)
                {
                    checkModel.Add((item as CheckBox).Text);
                    indexModel++;
                }
            }
            if (indexModel == 0)
            {
                foreach (var item in panelModel.Controls)
                {
                    checkModel.Add((item as CheckBox).Text);
                }
            }
            // Year
            int indexYear = 0;
            checkYear= new List<string>();
            foreach (var item in panelYear.Controls)
            {
                if ((item as CheckBox).Checked)
                {
                    checkYear.Add((item as CheckBox).Text);
                    indexYear++;
                }
            }
            if(indexYear == 0)
            {
                foreach (var item in panelYear.Controls)
                {
                    checkYear.Add((item as CheckBox).Text);
                }
            }           
            // Km
            if (tbMinKm.Text == string.Empty)
                minKm = 0;
            else
                minKm = int.Parse(tbMinKm.Text);
            if (tbMaxKm.Text == string.Empty)
                maxKm = 1000000;
            else
                maxKm = int.Parse(tbMaxKm.Text);
            // Price
            if (tbMinPrice.Text == string.Empty)
                minPrice = 0;
            else
                minPrice = int.Parse(tbMinPrice.Text);
            if (tbMaxPrice.Text == string.Empty)
                maxPrice = 999999999;
            else
                maxPrice = int.Parse(tbMaxPrice.Text);
            // Color
            int indexColor = 0;
            checkColor = new List<string>();
            foreach (var item in panelColor.Controls)
            {
                if ((item as CheckBox).Checked)
                {
                    checkColor.Add((item as CheckBox).Text);
                    indexColor++;
                }
            }
            if (indexColor == 0)
            {
                foreach (var item in panelColor.Controls)
                {
                    checkColor.Add((item as CheckBox).Text);
                }
            }
            // City
            int indexCity = 0;
            checkCity = new List<string>();
            foreach (var item in panelCity.Controls)
            {
                if ((item as CheckBox).Checked)
                {
                    checkCity.Add((item as CheckBox).Text);
                    indexCity++;
                }
            }
            if (indexCity == 0)
            {
                foreach (var item in panelCity.Controls)
                {
                    checkCity.Add((item as CheckBox).Text);
                }
            }
        }

        public bool isAdd;
        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isAdd = true;
            FormCarAdd f = new FormCarAdd();
            f.Show();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            isAdd = false;
            FormCarAdd f = new FormCarAdd();
            f.Show();
            f.BringItems();
        }
        public int id;        
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            id = (int)dgv.CurrentRow.Cells[0].Value;
            Car car = db.Cars.Find(id);
            var result = MessageBox.Show("Silmek istediğinizden emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                db.Entry(car).State = EntityState.Deleted;
                db.SaveChanges();
                MessageBox.Show("İşlem Başarılı!", "Uyarı");
            }                           
            GridFill();
        }

        public void GridFill(string param = null)
        {
            if (param == null)
            {
                var query = from i in db.Cars
                            join b in db.Brands on i.BrandId equals b.Id
                            join r in db.Colors on i.ColorId equals r.Id
                            select new
                            {
                                Id = i.Id,
                                Marka = b.Name,
                                Model = i.Model,
                                Yıl = i.Year,
                                Km = i.Km,
                                Fiyat = i.Price,
                                Renk = r.Name,
                                Şehir = i.City
                            };
                dgv.DataSource = query.ToList();
            }
            else
            {
                var query = from i in db.Cars
                            join b in db.Brands on i.BrandId equals b.Id
                            join r in db.Colors on i.ColorId equals r.Id
                            where(((i.Model.Contains(tbSearch.Text))||(i.Brand.Name.Contains(tbSearch.Text))||(i.City.Contains(tbSearch.Text))) && (i.Price >= minPrice && i.Price <= maxPrice) &&  (i.Km >= minKm && i.Km <= maxKm) && (checkColor.Contains(r.Name)) && (checkBrand.Contains(b.Name)) && (checkModel.Contains(i.Model)) && (checkYear.Contains(i.Year.ToString())) && (checkCity.Contains(i.City)))
                            select new
                            {
                                Id = i.Id,
                                Marka = b.Name,
                                Model = i.Model,
                                Yıl = i.Year,
                                Km = i.Km,
                                Fiyat = i.Price,
                                Renk = r.Name,
                                Şehir = i.City
                            };
                dgv.DataSource = query.ToList();
            }          
        }
    }
}
