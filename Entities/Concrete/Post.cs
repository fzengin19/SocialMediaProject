using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Post : IEntity
    {
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string? Explain { get; set; }
        public string? MediaPath { get; set; }
        public DateTime? ShareDate { get; set; }
        public short PrivacyLevel { get; set; }
    }
}
