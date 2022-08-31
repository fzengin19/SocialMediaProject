using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ChatRoomUser : IEntity
    {
        public int ChatRoomUserId { get; set; }
        public int ChatRoomId { get; set; }
        public int UserId { get; set; }
        public bool Access { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime? LeaveDate { get; set; }
    }
}
