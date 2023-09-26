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

        public ServiceManager(GenericRepository<Service> serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }
        public void TDelete(int id)
        {
            _serviceRepository.Delete(id);
        }

        public Service TGetById(int id)
        {
            return _serviceRepository.GetById(id);
        }

        public List<Service> TGetList()
        {
            return _serviceRepository.GetList();
        }

        public void TInsert(Service t)
        {
            _serviceRepository.Insert(t);
        }

        public void TUpdate(Service t)
        {
            _serviceRepository.Update(t);
        }
    }
}