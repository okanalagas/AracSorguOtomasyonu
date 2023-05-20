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

namespace _3_SahibindenUygulama
{
    public partial class FormBrandAndColor : Form
    {
        public FormBrandAndColor()
        {
            InitializeComponent();
        }
        public bool isBrand;
        public bool isBrandUpdate;
        public bool isColorUpdate;
        CarDbContext db = new CarDbContext();
        FormCarAdd fca = (FormCarAdd)Application.OpenForms["FormCarAdd"];
        FormList fl = (FormList)Application.OpenForms["FormList"];
        
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (isBrand)
            {
                if(!isBrandUpdate)
                {
                    var brand = db.Brands.FirstOrDefault(i => i.Name.ToLower() == tbName.Text.ToLower());
                    if (brand != null)
                    {
                        MessageBox.Show("Bu marka zaten mevcut!", "İşlem Durumu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        fca.BrandAddShow();
                    }
                    else
                    {
                        if (tbName.Text != "")
                        {
                            db.Brands.Add(new Brand(tbName.Text));
                            db.SaveChanges();
                            MessageBox.Show("Kayıt Başarılı.", "İşlem Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fca.cbBrandFill();
                            fl.panelBrandFill();
                        }
                        else
                        {
                            MessageBox.Show("Lütfen geçerli bir marka giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            fca.BrandAddShow();
                        }
                    }
                }
                else
                {
                    Brand brand = db.Brands.FirstOrDefault(i => i.Name.ToLower() == fca.cbBrand.Text.ToLower());
                    if (tbName.Text != "")
                    {
                        brand.Name = tbName.Text;
                        db.Entry(brand).State = EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Kayıt Başarılı.", "İşlem Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fca.cbBrandFill();
                        fl.panelBrandFill();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen geçerli bir marka giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        fca.BrandAddShow();
                    }                   
                }
            }
            else
            {
                if(!isColorUpdate)
                {
                    var color = db.Colors.FirstOrDefault(i => i.Name.ToLower() == tbName.Text.ToLower());
                    if (color != null)
                    {
                        MessageBox.Show("Bu renk zaten mevcut!", "İşlem Durumu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        fca.ColorAddShow();
                    }
                    else
                    {
                        if (tbName.Text != "")
                        {
                            db.Colors.Add(new Models.Color(tbName.Text));
                            db.SaveChanges();
                            MessageBox.Show("Kayıt Başarılı.", "İşlem Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fca.cbColorFill();
                            fl.panelColorFill();
                        }
                        else
                        {
                            MessageBox.Show("Lütfen geçerli bir renk giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            fca.ColorAddShow();
                        }
                    }
                }
                else
                {

                }
            }
            this.Close();
        }

        
    }
}
