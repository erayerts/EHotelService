using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelApi.BusinessLogic.Abstract;
using HotelApi.DataAccess.Repositories;
using HotelApi.Shared.Entities;

namespace HotelApi.BusinessLogic.Concrete
{
    public class NewsPostManager : INewsPostManager
    {
        private readonly GenericRepository<NewsPost> _newsPostRepository;

        public NewsPostManager()
        {
            _newsPostRepository = new GenericRepository<NewsPost>();
        }
        public void TDelete(NewsPost t)
        {
            throw new NotImplementedException();
        }

        public NewsPost TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<NewsPost> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(NewsPost t)
        {
            _newsPostRepository.Insert(t);
        }

        public void TUpdate(NewsPost t)
        {
            throw new NotImplementedException();
        }
    }
}