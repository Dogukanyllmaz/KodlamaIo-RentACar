using Business.Abstract;
using Core.Utilities.Results.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Business;
using Core.Utilities.Results.Concrete;
using System.IO;
using Business.Constants;
using System.Linq;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }
        public IResult Add(CarImage carImage)
        {
            IResult result = BusinessRules.Run(CheckImageCount(carImage.CarId));

            if (result!=null)
            {
                return result;
            }
            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.AddedCarImage);
        }

        public IResult Delete(CarImage carImage)
        {
            _carImageDal.Delete(carImage);
            return new SuccessResult(Messages.DeletedCarImage);
        }

        public IDataResult<List<CarImage>> GetAll(int carId)
        {
            var result = _carImageDal.GetAll(x => x.CarId == carId);
           if( result.Count == 0)
                result.Add(new CarImage { CarId = carId, ImagePath = "DefaultImage.jpg" });
                        
            return new SuccessDataResult<List<CarImage>>(result,Messages.ListedCarImages);
        }

        public IDataResult<CarImage> GetById(int Id)
        {
          return new SuccessDataResult<CarImage>( _carImageDal.Get(x => x.Id == Id),Messages.GetByIdCarImage);
        }

        public IResult Update(CarImage carImage)
        {
            var result = _carImageDal.Get(c => c.Id == carImage.Id);
            if (result!=null)
            {
                result.ImagePath = carImage.ImagePath;
                result.Date = DateTime.Now;
                _carImageDal.Update(carImage);
                return new SuccessResult(Messages.UpdatedCarImage);
            }
            return new ErrorResult(Messages.ErrorUpdateCarImage);
        }
    
    private IResult CheckImageCount(int carId)
        {
            var result = _carImageDal.GetAll(x => x.CarId == carId).Count;
            if (result<5)
            {
                return new SuccessResult();

            }
            return new ErrorResult(Messages.CarImageLimitExceeded);

        }
    }
}
