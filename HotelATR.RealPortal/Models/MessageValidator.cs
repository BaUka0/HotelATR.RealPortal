using FluentValidation;

namespace HotelATR.RealPortal.Models
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(r => r.message).NotEmpty();
        }
    }

}
