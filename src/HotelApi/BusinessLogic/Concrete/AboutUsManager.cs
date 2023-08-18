using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelApi.BusinessLogic.Abstract;
using HotelApi.DataAccess.Repositories;
using HotelApi.Shared.DtoEntities;
using HotelApi.Shared.Entities;

namespace HotelApi.BusinessLogic.Concrete
{
    public class AboutUsManager : IAboutUsManager
    {
        private readonly GenericRepository<AboutUs> _aboutUsRepository;

        public AboutUsManager()
        {
            _aboutUsRepository = new GenericRepository<AboutUs>();
        }
        public void TDelete(AboutUs t)
        {
            throw new NotImplementedException();
        }

        public AboutUs TGetById(int id)
        {
            return _aboutUsRepository.GetById(id);
        }

        public List<AboutUs> TGetList()
        {
            return _aboutUsRepository.GetList();
        }

        public void TInsert(AboutUs t)
        {
            _aboutUsRepository.Insert(t);
        }

        public void TUpdate(AboutUs t)
        {
            throw new NotImplementedException();
        }
    }
}