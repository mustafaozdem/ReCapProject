using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarProductManager : ICarProductService
    {
        ICarProductDal _carProductDal;

        public CarProductManager(ICarProductDal carProductDal)
        {
            _carProductDal = carProductDal;
        }

        public List<Car> GetAll()
        {
            return _carProductDal.GetAll();
        }
    }
}
