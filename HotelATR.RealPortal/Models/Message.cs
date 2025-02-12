using System.ComponentModel.DataAnnotations;

namespace HotelATR.RealPortal.Models
{
    public class Message
    {
        [Required(ErrorMessage = "Поле обязательно должно быть заполнено")]
        public string name { get; set; }
        public string email { get; set; }
        public string message { get; set; }
    }
}
