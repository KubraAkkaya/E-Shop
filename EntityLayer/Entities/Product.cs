using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Product
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez!")] //validaiton
        [Display(Name = "Ad")]
        [StringLength(20, ErrorMessage = "Maximum 20 karakter içermelidir!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez!")] //validaiton
        [Display(Name = "Açıklama")]
        [StringLength(50, ErrorMessage = "Maximum 50 karakter içermelidir!")]
        public string Decription { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez!")] //validaiton
        [Display(Name = "Fiyat")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez!")] //validaiton
        [Display(Name = "Stok")]
        public int Stock { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez!")] //validaiton
        [Display(Name = "Popüler")]
        public bool Popular { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez!")] //validaiton
        [Display(Name = "Onay")]
        public bool IsApproved { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez!")] //validaiton
        [Display(Name = "Resim")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez!")] //validaiton
        [Display(Name = "Adet")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez!")] //validaiton
        [Display(Name = "Kategori")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; } //her ürünün 1 Kategorisi olacak.
    }
}
