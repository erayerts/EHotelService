using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApi.Shared.Entities
{
    public class UserAccount_output
    {
        public int UserAccountId { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }
    }
}