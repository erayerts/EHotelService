using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using HotelApi.Shared.Security;

namespace HotelApi.Shared.Entities
{
    public class UserAccount
    {
        public int UserAccountId { get; set; }
        public string? Username { get; set; }
        public string? PasswordHash { get; set; }
        public string? EMail { get; set; }
        public string? Role { get; set; }
    }
}