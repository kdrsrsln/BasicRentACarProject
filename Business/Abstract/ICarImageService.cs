using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> Get();
        IResult Add(CarImage carImage, IFormFile files, string webRootPath);
        IResult Update(CarImage carImage, IFormFile files, string webRootPath);
        IResult Delete(CarImage carImage);
    }
}
