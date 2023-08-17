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

        public void TDelete(TestimonialReview t)
        {
            throw new NotImplementedException();
        }

        public TestimonialReview TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<TestimonialReview> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(TestimonialReview t)
        {
            _testimonialReviewRepository.Insert(t);
        }

        public void TUpdate(TestimonialReview t)
        {
            throw new NotImplementedException();
        }
    }
}