using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ChatRoomTypeValidator : AbstractValidator<ChatRoomType>
    {
        public ChatRoomTypeValidator()
        {
            RuleFor(c => c.ChatRoomTypeId).NotEmpty();
            RuleFor(c => c.ChatRoomTypeId).GreaterThan(0);

            RuleFor(c => c.ChatRoomTypeName).NotEmpty();
        }
    }
}
