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
        public void TDelete(int id)
        {
            _introductionRepository.Delete(id);
        }

        public Introduction TGetById(int id)
        {
            return _introductionRepository.GetById(id);
        }

        public List<Introduction> TGetList()
        {
            return _introductionRepository.GetList();
        }

        public void TInsert(Introduction t)
        {
            _introductionRepository.Insert(t);
        }

        public void TUpdate(Introduction t)
        {
            _introductionRepository.Update(t);
        }
    }
}