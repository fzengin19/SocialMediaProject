using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class GroupAdminValidator : AbstractValidator<GroupAdmin>
    {
        public GroupAdminValidator()
        {
            RuleFor(a => a.ChatRoomId).NotEmpty();
            RuleFor(a => a.ChatRoomId).GreaterThan(0);

            RuleFor(a => a.UserId).NotEmpty();
            RuleFor(a => a.UserId).GreaterThan(0);

            RuleFor(a => a.ChatRoomId).GreaterThan(0);
            RuleFor(a => a.ChatRoomId).NotEmpty();
        }
    }
}
