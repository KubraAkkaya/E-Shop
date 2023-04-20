﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Category
    {
        public int ID { get; set; }

        [Required (ErrorMessage = "Boş Geçilemez!")] //validaiton
        [Display (Name = "Ad")]
        [StringLength (20,ErrorMessage ="Maximum 20 karakter içermelidir!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez!")] 
        [Display(Name = "Açıklama")]
        [StringLength(50, ErrorMessage = "Maximum 50 karakter içermelidir!")]
        public string Description { get; set; }

        public virtual List <Product> Products { get; set; } //birden fazla ürün olabilir.


    }
}
