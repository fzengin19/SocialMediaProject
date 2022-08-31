using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ChatRoomUserValidator : AbstractValidator<ChatRoomUser>
    {
        public ChatRoomUserValidator()
        {
            RuleFor(u => u.UserId).NotEmpty();
            RuleFor(u => u.UserId).GreaterThan(0);

            RuleFor(u => u.ChatRoomId).NotEmpty();
            RuleFor(u => u.ChatRoomId).GreaterThan(0);

            RuleFor(u => u.ChatRoomUserId).NotEmpty();
            RuleFor(u => u.ChatRoomUserId).GreaterThan(0);
        }
    }
}
