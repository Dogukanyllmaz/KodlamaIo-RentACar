using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentalProjectContext>, ICarDal
    {
        public CarDetailDto GetCarDetails(int Id)
        {
            using(RentalProjectContext context = new RentalProjectContext())
            {
                var result = from car in context.Cars.Where(c => c.Id == Id)
                             join color in context.Colors on car.ColorId equals color.Id
                             join brand in context.Brands on car.BrandId equals brand.Id
                             select new CarDetailDto
                             {
                                 Id = car.Id,
                                 Name = car.Name,
                                 BrandId = brand.Id,
                                 ColorId = color.Id,
                                 BrandName = brand.Name,
                                 ColorName = color.Name,
                                 ModelYear = car.ModelYear,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description,
                                 Status = !(context.Rentals.Any(r => r.CarId == Id && r.ReturnDate == null))
                             };
                return result.SingleOrDefault();
            }
        }

        public List<CarDetailDto> GetCarsDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using(RentalProjectContext context = new RentalProjectContext())
            {
                var result = from car in context.Cars
                             join color in context.Colors on car.ColorId equals color.Id
                             join brand in context.Brands on car.BrandId equals brand.Id
                             select new CarDetailDto
                             {
                                 Id = car.Id,
                                 Name = car.Name,
                                 BrandId = brand.Id,
                                 BrandName = brand.Name,
                                 ColorId = color.Id,
                                 ColorName = color.Name,
                                 ModelYear = car.ModelYear,
                                 Description = car.Description,
                                 DailyPrice = car.DailyPrice,
                                 Status = !context.Rentals.Any(r => r.CarId == car.Id && r.ReturnDate == null)
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}
