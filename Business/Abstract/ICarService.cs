using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<List<Car>> GetCarsByColorId(int colorId);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IDataResult<List<CarDetailDto>> GetAllCarDetailDtos();
        IDataResult<CarDetailDto> GetCarDetail(int carId);
        IDataResult<List<CarDetailDto>> GetAllCarDetailByBrand(int brandId);
        IDataResult<List<CarDetailDto>> GetAllCarDetailByColor(int colorId);
        IDataResult<List<CarDetailDto>> GetAllCarDetailByBrandAndColor(int brandId, int colorId);
    }
}
