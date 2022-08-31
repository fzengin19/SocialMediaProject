using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class GroupMessage :IEntity
    {
        public long MessageId { get; set; }
        public int SenderId { get; set; }
        public DateTime SendDate { get; set; }
        public DateTime DeleteDate { get; set; }
        public bool Forwarded { get; set; }
        public int ChatRoomId { get; set; }
        public string Message { get; set; }
    }
}
