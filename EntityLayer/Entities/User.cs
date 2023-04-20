using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class User
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez!")] //validaiton
        [Display(Name = "Ad")]
        [StringLength(20, ErrorMessage = "Maximum 20 karakter içermelidir!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez!")] //validaiton
        [Display(Name = "Soy ad")]
        [StringLength(20, ErrorMessage = "Maximum 20 karakter içermelidir!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez!")] //validaiton
        [Display(Name = "Mail")]
        [StringLength(50, ErrorMessage = "Maximum 50 karakter içermelidir!")]
        [EmailAddress (ErrorMessage = "E-mail formatı şeklinde girmelisiniz!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez!")] //validaiton
        [Display(Name = "Kullanıcı Ad")]
        [StringLength(20, ErrorMessage = "Maximum 20 karakter içermelidir!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez!")] //validaiton
        [Display(Name = "Şifre")]
        [StringLength(10, ErrorMessage = "Maximum 10 karakter içermelidir!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez!")] //validaiton
        [Display(Name = "Şifre")]
        [StringLength(10, ErrorMessage = "Maximum 10 karakter içermelidir!")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor!")]
        public string RePassword { get; set; }

        [StringLength(10, ErrorMessage = "Maximum 10 karakter içermelidir!")]

        public string Role { get; set; }
    }
}
