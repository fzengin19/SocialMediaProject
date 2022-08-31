using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ChatRoomType : IEntity
    {
        public int ChatRoomTypeId { get; set; }
        public string ChatRoomTypeName { get; set; }
        public bool Group { get; set; }

    }
}
