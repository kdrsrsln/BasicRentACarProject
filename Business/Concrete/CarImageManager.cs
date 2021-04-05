using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Internal;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        private ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<CarImage> Get()
        {
            throw new NotImplementedException();
        }

        //public IResult Add(CarImage carImage, List<IFormFile> files, string webRootPath)
        //{
        //    var uploadedFilesPath = FileUploadHelper.Upload(files, webRootPath);
        //    carImage.Date = DateTime.Now;

        //    foreach (var imagePath in uploadedFilesPath.Result.Data)
        //    {
        //        carImage.ImagePath = imagePath;
        //        _carImageDal.Add(carImage);
        //    }

        //   return new SuccessResult();

        //}
        [SecuredOperation("admin")]
        public IResult Add(CarImage carImage, IFormFile file, string webRootPath)
        {
            IResult result = BusinessRules.Run(CheckIfCountOfCarImagesExceed(carImage.CarId));


            if (result != null)
            {
                return result;
            }
            var uploadedFilesPath = FileHelper.Add(file, webRootPath);
            carImage.Date = DateTime.Now;
            carImage.ImagePath = uploadedFilesPath;
            _carImageDal.Add(carImage);
            
            return new SuccessResult();
        }

        public IResult Update(CarImage carImage, IFormFile file, string webRootPath)
        {
            var carImageToUpdate = _carImageDal.Get(ci => ci.Id == carImage.Id);
            carImageToUpdate.Date = DateTime.Now;
            carImageToUpdate.ImagePath = FileHelper.Update(carImageToUpdate.ImagePath, file, webRootPath);
            _carImageDal.Update(carImageToUpdate);

            return new SuccessResult();
        }

        public IResult Delete(CarImage carImage)
        {
            var carImageToDelete = _carImageDal.Get(ci => ci.Id == carImage.Id);
            FileHelper.Delete(carImageToDelete.ImagePath);
            _carImageDal.Delete(carImageToDelete);
            return new SuccessResult();
        }

        private IResult CheckIfCountOfCarImagesExceed(int carId)
        {
            var result = _carImageDal.GetAll(ci => ci.CarId == carId).Count;
            if (result >= 5)
            {
                return new ErrorResult(Messages.CarImagesReachedMaxNumberOfPhoto);
            }
            return new SuccessResult();
        }

        //private IResult CheckIfCarHasAnyImage(int carId)
        //{
        //    var result = _carImageDal.GetAll(ci => ci.CarId == carId).Any();
        //    if (!result)
        //    {
        //        SetDefaultImage();
        //    }
        //}

        //private void SetDefaultImage()
        //{
            
        //}
    }
}
