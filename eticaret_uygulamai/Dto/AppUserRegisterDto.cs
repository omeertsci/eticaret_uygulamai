using System.ComponentModel.DataAnnotations;

namespace eticaret_uygulamai.Dto
{
    public class AppUserRegisterDto
    {
        [Display(Name ="Adınızı Girin")]
        [Required(ErrorMessage ="Adınızı Boş Geçemezsiniz")]
        public string FirstName { get; set; }
        [Display(Name = "Soyadınızı Girin")]
        [Required(ErrorMessage = "Soyadınızı Boş Geçemezsiniz")]
        public string LastName { get; set; }
        [Display(Name = "Kullanıcı Adınızı Girin")]
        [Required(ErrorMessage = "Kullanıcı Adını Boş Geçemezsiniz")]
        public string UserName { get; set; }
        [Display(Name = "Şehri Girin")]
        [Required(ErrorMessage = "Şehri Boş Geçemezsiniz")]
        public string City { get; set; }
        [Display(Name = "Email Girin")]
        [Required(ErrorMessage = "Emaili Boş Geçemezsiniz")]
        public string Email { get; set; }
        [Display(Name = "Telefon Numarası Girin")]
        [Required(ErrorMessage = "Telefon Numarasını Boş Geçemezsiniz")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Şifrenizi Girin")]
        [Required(ErrorMessage = "Şifreyi Boş Geçemezsiniz")]
        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
    }
}