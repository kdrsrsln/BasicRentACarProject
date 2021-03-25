using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        
        IDataResult<List<Car>> ICarService.GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }
        IDataResult<List<Car>> ICarService.GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == brandId));
        }
        IDataResult<List<Car>> ICarService.GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == colorId));
        }
        public IDataResult<List<CarDetailDto>> GetAllCarDetailDtos()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetAllCarDetailDtos());
        }
        public IResult Add(Car car)
        {
            if (car.Model.Length >2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                return new SuccessResult();
            }
            else
            {
                return new ErrorResult();
            }
        }
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult();
        }
        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult();
        }
    }
}
