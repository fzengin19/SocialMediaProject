using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ChatRoom : IEntity
    {
        public int ChatRoomId { get; set; }
        public int ChatRoomTypeId { get; set; }
        public int CreatorId { get; set; }
        public int? DeletedId { get; set; }
        public string ChatRoomName { get; set; }
        public int CurrentUser { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
