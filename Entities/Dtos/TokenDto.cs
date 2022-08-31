using Core.Entities;
using Core.Entities.Concrete;

using Core.Utilities.Security.JWT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class TokenDto :AccessToken
    {
        public User user { get; set; }
    }
}
