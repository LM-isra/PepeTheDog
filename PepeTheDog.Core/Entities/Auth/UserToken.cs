using System;

namespace PepeTheDog.Core.Entities.Auth
{
    public class UserToken
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
