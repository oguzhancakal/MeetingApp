using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        
        public int  Id { get; set; }
        [Required(ErrorMessage ="Ad Soyad Alanı Zorunlu")]
        public string? Name { get; set; }
        [Required(ErrorMessage ="Telefon Numarası Alanı Zorunlu")]
        public string? Phone { get; set; }
        [Required(ErrorMessage ="Hatalı Email")]
        [EmailAddress]
        public string? Email { get; set; }
        [Required(ErrorMessage ="Katılım Bilgisi Zorunlu")]
        public bool? WillAttend { get; set; }
    }
}