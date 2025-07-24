using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace BlogApp.Models
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Username")]
        public string? UserName { get; set; }

        [Required]
        [Display(Name = "Ad Soyad")]
        public string? Name { get; set; }
       
        

        [Required]
        [EmailAddress]
        [Display(Name="Eposta")]
        public string? Email { get; set; }

        [Required]
        [StringLength(10,ErrorMessage ="Max 10 karakter belirtiniz")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string? Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Parola Tekrar")]
        [Compare(nameof(Password),ErrorMessage ="Parolanız eşleşmiyor")]
        public string ConfirmPassword { get; set; }
    }
}
