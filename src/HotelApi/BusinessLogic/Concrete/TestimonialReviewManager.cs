using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelApi.BusinessLogic.Abstract;
using HotelApi.DataAccess.Repositories;
using HotelApi.Shared.Entities;

namespace HotelApi.BusinessLogic.Concrete
{
    public class TestimonialReviewManager : ITestimonialReviewManager
    {
        private readonly GenericRepository<TestimonialReview> _testimonialReviewRepository;

        public TestimonialReviewManager()
        {
            _testimonialReviewRepository = new GenericRepository<TestimonialReview>();
        }

        public void TDelete(int id)
        {
            _testimonialReviewRepository.Delete(id);
        }

        public TestimonialReview TGetById(int id)
        {
            return _testimonialReviewRepository.GetById(id);
        }

        public List<TestimonialReview> TGetList()
        {
            return _testimonialReviewRepository.GetList();
        }

        public void TInsert(TestimonialReview t)
        {
            _testimonialReviewRepository.Insert(t);
        }

        public void TUpdate(TestimonialReview t)
        {
            _testimonialReviewRepository.Update(t);
        }
    }
}