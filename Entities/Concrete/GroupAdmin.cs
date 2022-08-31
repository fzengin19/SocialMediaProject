using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class GroupAdmin : IEntity
    {
        public int GroupAdminId { get; set; }
        public int ChatRoomId { get; set; }
        public int UserId { get; set; }
    }
}
