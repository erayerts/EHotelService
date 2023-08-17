using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelApi.BusinessLogic.Abstract;
using HotelApi.DataAccess.Repositories;
using HotelApi.Shared.Entities;

namespace HotelApi.BusinessLogic.Concrete
{
    public class RoomManager : IRoomManager
    {
        private readonly GenericRepository<Room> _roomRepository;

        public RoomManager()
        {
            _roomRepository = new GenericRepository<Room>();
        }

        public void TDelete(Room t)
        {
            throw new NotImplementedException();
        }

        public Room TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Room> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Room t)
        {
            _roomRepository.Insert(t);
        }

        public void TUpdate(Room t)
        {
            throw new NotImplementedException();
        }
    }
}