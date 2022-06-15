using System.ComponentModel.DataAnnotations;

namespace DZDFreeTim.Web.Mvc.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Bu alan gerekli")]
        [StringLength(150)]
        [Display(Name = "Mail Adresi")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Bu alan gerekli")]
        [StringLength(50)]
        [DataType(DataType.Password)]
        [Display(Name = "Şifre")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
