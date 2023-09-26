using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelApi.BusinessLogic.Abstract;
using HotelApi.Shared.Entities;
using System.Security.Cryptography;
using System.Text;
using HotelApi.DataAccess.Repositories;

namespace HotelApi.BusinessLogic.Concrete
{
    public class UserManager : IUserManager
    {
        private readonly GenericRepository<UserAccount> _userRepository;
        private readonly UserRepository _userValidationRepository;
        
        public UserManager(GenericRepository<UserAccount> userRepository, UserRepository userValidationRepository)
        {
            _userRepository = userRepository;
            _userValidationRepository = userValidationRepository;
        }

        public string EncryptPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                string hashString = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                return hashString;
            }
        }

        public void TDelete(int id)
        {
            _userRepository.Delete(id);
        }

        public UserAccount TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserAccount> TGetList()
        {
            return _userRepository.GetList();
        }

        public void TInsert(UserAccount t)
        {
            _userRepository.Insert(t);
        }

        public void TUpdate(UserAccount t)
        {
            throw new NotImplementedException();
        }

        public bool ValidateUser(string username, string passwordHash)
        {
            return _userValidationRepository.ValidateUser(username, passwordHash);
        }
    }
}