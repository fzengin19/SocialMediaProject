using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class PrivateMessageValidator : AbstractValidator<PrivateMessage>
    {
        public PrivateMessageValidator()
        {
            RuleFor(m => m.MessageId).NotEmpty();
            RuleFor(m => m.MessageId).GreaterThan(0);

            RuleFor(m => m.SenderId).NotEmpty();
            RuleFor(m => m.SenderId).GreaterThan(0);

            RuleFor(m => m.RecipientId).NotEmpty();
            RuleFor(m => m.RecipientId).GreaterThan(0);

            RuleFor(m => m.Message).NotEmpty();
        }
    }
}
