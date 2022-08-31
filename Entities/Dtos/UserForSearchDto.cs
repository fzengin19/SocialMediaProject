using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class UserForSearchDto :IDto
    {
        public int UserId { get; set; }
        public string? ProfilePicturesPath { get; set; }
        public string? Biography { get; set; }
        public string FullName { get; set; }
        public bool Status { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime? LastSeen { get; set; }

    }
}
