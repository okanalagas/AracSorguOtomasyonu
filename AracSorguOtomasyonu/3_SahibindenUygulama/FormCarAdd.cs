using _3_SahibindenUygulama.Context;
using _3_SahibindenUygulama.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _3_SahibindenUygulama
{
    public partial class FormCarAdd : Form
    {
        public FormCarAdd()
        {
            InitializeComponent();
            cbBrandFill();
            cbColorFill();

        }
        FormBrandAndColor fbg;
        CarDbContext db = new CarDbContext();
        FormList fl = (FormList)Application.OpenForms["FormList"];

        private void buttonBrandAdd_Click(object sender, EventArgs e)
        {
            fbg = new FormBrandAndColor();
            fbg.isBrand = true;
            fbg.Text = "Marka Ekle";
            fbg.Show();
        }

        private void buttonColorAdd_Click(object sender, EventArgs e)
        {
            fbg = new FormBrandAndColor();
            fbg.isBrand = false;
            fbg.Text = "Renk Ekle";
            fbg.Show();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (fl.isAdd)
            {
                var car = new Car()
                {
                    BrandId = db.Brands.FirstOrDefault(i => i.Name == cbBrand.Text).Id,
                    Model = tbModel.Text,
                    Year = int.Parse(tbYear.Text),
                    Km = int.Parse(tbKm.Text),
                    Price = int.Parse(tbPrice.Text),
                    ColorId = db.Colors.FirstOrDefault(i => i.Name == cbColor.Text).Id,
                    City = tbCity.Text
                };
                db.Entry(car).State = EntityState.Added;
                //ya da 
                //Car car1 = new Car(tbModel.Text, Convert.ToInt32(tbYear), Convert.ToInt32(tbKm), Convert.ToInt32(tbPrice), tbCity.Text);
                //car1.BrandId = (int)cbBrand.SelectedValue;
                //car1.ColorId= (int)cbColor.SelectedValue;
            }
            else
            {
                fl.id = (int)fl.dgv.CurrentRow.Cells[0].Value;
                var car = db.Cars.Find(fl.id);
                car.BrandId = db.Brands.FirstOrDefault(i => i.Name == cbBrand.Text).Id;
                car.Model = tbModel.Text;
                car.Year = int.Parse(tbYear.Text);
                car.Km = int.Parse(tbKm.Text);
                car.Price = int.Parse(tbPrice.Text);
                car.ColorId = db.Colors.FirstOrDefault(i => i.Name == cbColor.Text).Id;
                car.City = tbCity.Text;
                db.Entry(car).State = EntityState.Modified;
            }
            db.SaveChanges();
            fl.panelModelFill();
            fl.panelYearFill();
            fl.panelCityFill();
            tbCity.Text = tbKm.Text = tbModel.Text = tbPrice.Text = tbYear.Text = "";
            this.Close();
            fl.GridFill();
        }

        public void BringItems()
        {
            fl.id = (int)fl.dgv.CurrentRow.Cells[0].Value;
            cbBrand.Text = fl.dgv.CurrentRow.Cells[1].Value.ToString();
            tbModel.Text = fl.dgv.CurrentRow.Cells[2].Value.ToString();
            tbYear.Text = fl.dgv.CurrentRow.Cells[3].Value.ToString();
            tbKm.Text = fl.dgv.CurrentRow.Cells[4].Value.ToString();
            tbPrice.Text = fl.dgv.CurrentRow.Cells[5].Value.ToString();
            cbColor.Text = fl.dgv.CurrentRow.Cells[6].Value.ToString();
            tbCity.Text = fl.dgv.CurrentRow.Cells[7].Value.ToString();
        }

        public void cbBrandFill()
        {
            cbBrand.DisplayMember = "Name";
            cbBrand.ValueMember = "Id";
            cbBrand.DataSource = db.Brands.ToList();
            cbBrand.DataSource = db.Brands.OrderBy(i => i.Name).ToList();          //sıralayabilmek için
            //cbBrand.Items.Clear();
            //foreach (var brand in db.Brands)
            //{
            //    cbBrand.Items.Add($"{brand.Name}");
            //}
        }
        public void cbColorFill()
        {
            cbColor.DisplayMember = "Name";
            cbColor.ValueMember = "Id";
            cbColor.DataSource = db.Colors.ToList();
            cbColor.DataSource = db.Colors.OrderBy(i => i.Name).ToList();
            //cbColor.Items.Clear();
            //foreach (var color in db.Colors)
            //{
            //    cbColor.Items.Add($"{color.Name}");
            //}
        }

        private void buttonSave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSave_Click(sender, e);
                cbBrand.Items.Clear();
                cbColor.Items.Clear();
                this.Close();
            }
        }
        private void tbYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void tbKm_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void cbBrand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbModel.Focus();
            }
        }
        private void tbModel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbYear.Focus();
            }
        }
        private void tbYear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbKm.Focus();
            }
        }
        private void tbKm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbPrice.Focus();
            }
        }
        private void tbPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbColor.Focus();
            }
        }
        private void cbColor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbCity.Focus();
            }
        }
        private void tbCity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSave_Click(sender, e);
                cbBrand.Items.Clear();
                cbColor.Items.Clear();
                this.Close();
            }
        }
        public void ColorAddShow()
        {
            fbg = new FormBrandAndColor();
            fbg.isBrand = false;
            fbg.isColorUpdate=false;
            fbg.Text = "Renk Ekle";
            fbg.Show();
        }
        public void BrandAddShow()
        {
            fbg = new FormBrandAndColor();
            fbg.isBrand = true;
            fbg.isBrandUpdate = false;
            fbg.Text = "Marka Ekle";
            fbg.Show();
        }
        
        //Brand için 
        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fbg = new FormBrandAndColor();
            fbg.isBrand = true;
            fbg.isBrandUpdate = true;            
            fbg.Text = "Marka Güncelle";
            fbg.tbName.Text=cbBrand.Text;           
            fbg.Show();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Brand brand = db.Brands.Find(cbBrand.SelectedValue);
            db.Entry(brand).State = EntityState.Deleted;
            db.SaveChanges();
            cbBrandFill();
            fl.panelBrandFill();
        }

        //Color için
        private void güncelleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fbg = new FormBrandAndColor();
            fbg.isBrand = false;
            fbg.isColorUpdate = true;            
            fbg.Text = "Renk Güncelle";
            fbg.Show();
        }

        private void silToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Models.Color color = db.Colors.Find(cbColor.SelectedValue);
            db.Entry(color).State = EntityState.Deleted;
            db.SaveChanges();
            cbColorFill();
            fl.panelColorFill();
        }
    }
}
