using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class UserContact : IEntity
    {
        public long ContactId { get; set; }
        public int UserId { get; set; }
        public int UserContactId{ get; set; }
        public string ContactName { get; set; }
        
    }

}
