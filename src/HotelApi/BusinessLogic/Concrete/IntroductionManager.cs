using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelApi.BusinessLogic.Abstract;
using HotelApi.DataAccess.Repositories;
using HotelApi.Shared.Entities;

namespace HotelApi.BusinessLogic.Concrete
{
    public class IntroductionManager : IIntroductionManager
    {
        private readonly GenericRepository<Introduction> _introductionRepository;

        public IntroductionManager()
        {
            _introductionRepository = new GenericRepository<Introduction>();
        }
        public void TDelete(Introduction t)
        {
            throw new NotImplementedException();
        }

        public Introduction TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Introduction> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Introduction t)
        {
            _introductionRepository.Insert(t);
        }

        public void TUpdate(Introduction t)
        {
            throw new NotImplementedException();
        }
    }
}