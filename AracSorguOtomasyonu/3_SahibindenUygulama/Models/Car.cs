using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_SahibindenUygulama.Models
{
    internal class Car
    {
        public Car()
        {
            
        }
        public Car(string model, int year, int km, int price, string city)
        {
            Model = model;
            Year = year;
            Km = km;
            Price = price;         
            City = city;
        }

        [Key]
        public int Id { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Km { get; set; }
        public int Price { get; set; }
        public int ColorId { get; set; }
        public Color Color { get; set; }
        public string City { get; set; }
    }
}
