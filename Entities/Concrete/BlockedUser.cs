using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class BlockedUser :IEntity
    {
        public int BlockedUserId { get; set; }
        public int BlockingId { get; set; }
        public int BlockedId { get; set; }
    }
}
