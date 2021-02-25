using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
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

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carProductDal.GetAll(), Messages.ProductsListed);
        }

        public IResult Add(Car car)
        {
            //_carProductDal.Add(car);
            //return new SuccessResult(Messages.ProductAdded);  



            ValidationTool.Validate(new CarValidator(), car);

            


            _carProductDal.Add(car);
            return new SuccessResult(Messages.ProductAdded);


        }



        public List<CarDetailDto> GetCarDetails()
        {
            return _carProductDal.GetCarDetails();
        }



        IResult ICarProductService.Delete(Car car)
        {
            _carProductDal.Delete(car);
            return new SuccessResult(Messages.ProductsDeleted);

        }

        IDataResult<List<CarDetailDto>> ICarProductService.GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public IResult Updated(Car car)
        {
            _carProductDal.Update(car);
            return new SuccessResult(Messages.ProductsUpdated);
        }

        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>(_carProductDal.Get(c => c.Id == carId), Messages.ProductsListed);
        }

    }
}
