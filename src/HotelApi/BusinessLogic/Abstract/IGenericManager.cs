using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApi.BusinessLogic.Abstract
{
    public interface IGenericManager<T> where T : class
    {
        void TInsert(T t);
        void TDelete(int id);
        void TUpdate(T t);
        List<T> TGetList();
        T TGetById(int id);
    }
}