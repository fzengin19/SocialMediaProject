using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class GroupMessageStatusValidator : AbstractValidator<GroupMessageStatus>
    {
        public GroupMessageStatusValidator()
        {
            RuleFor(s => s.StatusId).NotEmpty();
            RuleFor(s => s.StatusId).GreaterThan(0);

            RuleFor(s => s.MessageId).NotEmpty();
            RuleFor(s => s.MessageId).GreaterThan(0);

            RuleFor(s => s.RecipientId).NotEmpty();
            RuleFor(s => s.RecipientId).GreaterThan(0);
        }
    }
}
