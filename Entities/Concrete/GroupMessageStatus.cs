using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class GroupMessageStatus : IEntity
    {
        public long StatusId { get; set; }
        public long MessageId { get; set; }
        public int RecipientId { get; set; }
        public bool Forwarded { get; set; }
    }
}
