using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class GroupMessageValidator : AbstractValidator<GroupMessage>
    {
        public GroupMessageValidator()
        {
            RuleFor(m => m.MessageId).NotEmpty();
            RuleFor(m => m.MessageId).GreaterThan(0);

            RuleFor(m => m.SenderId).NotEmpty();
            RuleFor(m => m.SenderId).GreaterThan(0);

            RuleFor(m => m.ChatRoomId).NotEmpty();
            RuleFor(m => m.ChatRoomId).GreaterThan(0);

            RuleFor(m => m.Message).NotEmpty();

        }
    }
}
