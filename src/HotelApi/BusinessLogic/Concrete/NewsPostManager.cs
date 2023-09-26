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

        public NewsPostManager(GenericRepository<NewsPost> newsPostRepository)
        {
            _newsPostRepository = newsPostRepository;
        }
        public void TDelete(int id)
        {
            _newsPostRepository.Delete(id);
        }

        public NewsPost TGetById(int id)
        {
            return _newsPostRepository.GetById(id);
        }

        public List<NewsPost> TGetList()
        {
            return _newsPostRepository.GetList();
        }

        public void TInsert(NewsPost t)
        {
            _newsPostRepository.Insert(t);
        }

        public void TUpdate(NewsPost t)
        {
            _newsPostRepository.Insert(t);
        }
    }
}