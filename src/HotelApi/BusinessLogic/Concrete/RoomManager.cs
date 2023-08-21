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

        public void TDelete(int id)
        {
            _roomRepository.Delete(id);
        }

        public Room TGetById(int id)
        {
            return _roomRepository.GetById(id);
        }

        public List<Room> TGetList()
        {
            return _roomRepository.GetList();
        }

        public void TInsert(Room t)
        {
            _roomRepository.Insert(t);
        }

        public void TUpdate(Room t)
        {
            _roomRepository.Update(t);
        }
    }
}