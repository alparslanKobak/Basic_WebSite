

using System.ComponentModel.DataAnnotations;
// Hata almamak için bunu kaydetmeliyiz. Bu hata mesajlarını yönetebilmemiz için geçerlidir...

namespace WebApplication1.Models
{
    public class Uye
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Ad alanı boş bırakılamaz."), StringLength(50)] // StringLength ile ad alanına kaç karakter gönderilebileceğini sınırlayabiliriz.
        public string Ad { get; set; }
        [Required(ErrorMessage = "{0} alanı boş bırakılamaz."), StringLength(50)]
        public string Soyad { get; set; }
        [Required(ErrorMessage = "{0} alanı boş bırakılamaz ve geçersiz giriş yapılamaz."), StringLength(50)]
        [Display(Name ="E-Mail")]
        public string Email { get; set; }
        [Required(ErrorMessage = "{0} alanı boş bırakılamaz ve geçersiz giriş yapılamaz."), StringLength(50)]
        public string Telefon { get; set; }

        [Display(Name ="TC Kimlik Numarası")] // Ekranda TcKimlikNo yerine TC Kimlik Numarası yazsın
        [MinLength(11, ErrorMessage ="{0} 11 karakter olmalıdır.")]
        [MaxLength(11, ErrorMessage = "{0} 11 karakter olmalıdır.")]
        public string? TcKimlikNo { get; set; }

        [Display(Name ="Doğrum Tarihi")]
        public DateTime? DogumTarihi { get; set; }
        [Display(Name = "Kullanıcı Adı")]
        public string? KullaniciAdi { get; set; }
        [Display(Name = "Şifre")]
        public string? Sifre { get; set; }
        [Display(Name = "Şifre Tekrar")]
        public string? SifreTekrar { get; set; }

        //Bilgilerin zorunlu olmadığı noktalarda istenilen satırın veri tipinin sağına soru işareti eklenir.
    }
}
