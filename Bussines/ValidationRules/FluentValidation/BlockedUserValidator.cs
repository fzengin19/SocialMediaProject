using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class BlockedUserValidator : AbstractValidator<BlockedUser>
    {
        public BlockedUserValidator()
        {
            RuleFor(u => u.BlockedUserId).NotEmpty();
            RuleFor(u => u.BlockedUserId).GreaterThan(0);

            RuleFor(u => u.BlockedId).NotEmpty();
            RuleFor(u => u.BlockedId).GreaterThan(0);

            RuleFor(u => u.BlockingId).NotEmpty();
            RuleFor(u => u.BlockingId).GreaterThan(0);
        }
    }
}
