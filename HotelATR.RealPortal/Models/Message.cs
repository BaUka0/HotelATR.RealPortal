using System.ComponentModel.DataAnnotations;

namespace HotelATR.RealPortal.Models
{
    public class Message
    {
        [Required(ErrorMessage = "Поле обязательно должно быть заполнено")]
        public string name { get; set; }


        public string email { get; set; }

        [Required(ErrorMessage = "Поле email обязательно к заполнению")]
        [EmailAddress(ErrorMessage = "Указан не корректный emailадрес ")]
        public string message { get; set; }

        [CustomDate]
        public DateTime createDate { get; set; }

        [NameValidate(NotAllowed = new string[] {"Шымкент"}, 
            ErrorMessage ="Отправлять форму с города шымкент нельзя")]
        public string city { get; set; }
    }
}
