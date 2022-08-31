using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ChatRoomValidator : AbstractValidator<ChatRoom>
    {
        public ChatRoomValidator()
        {
            RuleFor(c => c.CreatorId).NotEmpty();
            RuleFor(c => c.CreatorId).GreaterThan(0);

            RuleFor(c => c.ChatRoomId).NotEmpty();
            RuleFor(c => c.ChatRoomId).GreaterThan(0);

            RuleFor(c => c.CurrentUser).GreaterThan(-1);
            RuleFor(c => c.CreateDate).NotEmpty();

            RuleFor(c => c.UpdateDate).NotEmpty();
        }
    }
}
