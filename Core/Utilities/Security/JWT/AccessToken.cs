using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public class AccessToken
    {
        public User User { get; set; }
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
