using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class FriendRequest : IEntity
    {
        public int RequestId { get; set; }
        public int RecipientId { get; set; }
        public int SenderId { get; set; }
    }
}
