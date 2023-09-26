using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelApi.Shared.Entities;

namespace HotelApi.BusinessLogic.Abstract
{
    public interface IUserManager : IGenericManager<UserAccount>
    {
        string EncryptPassword(string password);
        bool ValidateUser(string username, string password);
    }
}