using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelApi.BusinessLogic.Abstract;
using HotelApi.DataAccess.Repositories;
using HotelApi.Shared.Entities;

namespace HotelApi.BusinessLogic.Concrete
{
    public class ServiceManager : IServiceManager
    {
        private readonly GenericRepository<Service> _serviceRepository;

        public ServiceManager()
        {
            _serviceRepository = new GenericRepository<Service>();
        }
        public void TDelete(Service t)
        {
            throw new NotImplementedException();
        }

        public Service TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Service> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Service t)
        {
            _serviceRepository.Insert(t);
        }

        public void TUpdate(Service t)
        {
            throw new NotImplementedException();
        }
    }
}