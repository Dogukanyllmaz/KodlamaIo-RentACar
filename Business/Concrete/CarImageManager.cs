using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.BusinessAspects;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Transaction;
using Core.Utilities.Helpers;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        private ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        [CacheAspect]
        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        [CacheAspect]
        public IDataResult<List<CarImage>> GetAllByCarId(int carId)
        {
            var result = _carImageDal.GetAll(i => i.CarId == carId);

            if (result.Count > 0)
            {
                return new SuccessDataResult<List<CarImage>>(result);
            }

            List<CarImage> images = new List<CarImage>();
            images.Add(new CarImage() { CarId = 0, Id = 0, ImagePath = "/images/default.jpg" });

            return new SuccessDataResult<List<CarImage>>(images);


        }

        [CacheAspect]
        public IDataResult<CarImage> GetById(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(i => i.Id == id));
        }

        [SecuredOperation("carImage.add, admin")]
        [CacheRemoveAspect("ICarImageService.Get")]
        public IResult Add(IFormFile image, CarImage carImage)
        {

            var imageCount = _carImageDal.GetAll(c => c.CarId == carImage.CarId).Count;

            if (imageCount >= 5)
            {
                return new ErrorResult("One car must have 5 or less images");
            }

            var imageResult = FileUpload.Upload(image);
            carImage.ImagePath = imageResult.Message;
            _carImageDal.Add(carImage);
            return new SuccessResult("Car image added");
        }

        [SecuredOperation("carImage.delete, admin")]
        public IResult Delete(CarImage carImage)
        {
            var image = _carImageDal.Get(c => c.Id == carImage.Id);
            if (image == null)
            {
                return new ErrorResult("Image not found");
            }

            FileUpload.Delete(image.ImagePath);
            _carImageDal.Delete(carImage);
            return new SuccessResult("Image was deleted successfully");
        }

        [SecuredOperation("carImage.update, admin")]
        [CacheRemoveAspect("ICarImageService.Get")]
        public IResult Update(IFormFile image, CarImage carImage)
        {
            var isImage = _carImageDal.Get(c => c.Id == carImage.Id);
            if (isImage == null)
            {
                return new ErrorResult("Image not found");
            }



            var updatedFile = FileUpload.Update(image, isImage.ImagePath);
            carImage.ImagePath = updatedFile.Message;
            _carImageDal.Update(carImage);
            return new SuccessResult("Car image updated");

        }

    }
}
