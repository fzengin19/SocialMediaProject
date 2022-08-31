using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class UserDetail : IEntity
    {
        public int UserDeatilId { get; set; }
        public int UserId { get; set; }
        public string? Biography { get; set; }
        public DateTime? BirthDate { get; set; }
        public byte? Gender { get; set; }
    }
}
