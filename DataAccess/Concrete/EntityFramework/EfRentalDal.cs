using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentalProjectContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<RentalDetailDto, bool>> filter = null)
        {   
            using(RentalProjectContext context = new RentalProjectContext())
            {
                var result = from rental in context.Rentals
                             join car in context.Cars
                             on rental.CarId equals car.Id
                             join customer in context.Customers
                             on rental.Id equals customer.Id
                             join brand in context.Brands
                             on rental.Id equals brand.Id
                             join color in context.Colors
                             on car.ColorId equals color.Id
                             join user in context.Users
                             on customer.UserId equals user.Id
                             select new RentalDetailDto
                             {
                                 Id = rental.Id,
                                 CarId = car.Id,
                                 CarName = car.Name,
                                 BrandName = brand.Name,
                                 ColorName = color.Name,
                                 ModelYear = car.ModelYear,
                                 CompanyName = customer.CompanyName,
                                 UserName = user.FirstName + " " + user.LastName,
                                 Description = car.Description,
                                 RentDate = rental.RentDate,
                                 DailyPrice = car.DailyPrice,
                                 ReturnDate = rental.ReturnDate
                             };
                return filter == null
                    ? result.ToList()
                    : result.Where(filter).ToList();
            }
        }

        public RentalDetailDto GetRentalDetails(int id)
        {
            using(RentalProjectContext context = new RentalProjectContext())
            {
                var result = from rental in context.Rentals.Where(r => r.Id == id)
                             join car in context.Cars on rental.CarId equals car.Id
                             join customer in context.Customers on rental.CustomerId equals customer.Id
                             join brand in context.Brands on car.BrandId equals brand.Id
                             join color in context.Colors on car.ColorId equals color.Id
                             join user in context.Users on customer.UserId equals user.Id
                             select new RentalDetailDto
                             {
                                 Id = rental.Id,
                                 CarId = car.Id,
                                 BrandName = brand.Name,
                                 ColorName = color.Name,
                                 CompanyName = customer.CompanyName,
                                 UserName = user.FirstName + " " + user.LastName,
                                 Description = car.Description,
                                 ModelYear = car.ModelYear,
                                 RentDate = rental.RentDate,
                                 DailyPrice = car.DailyPrice,
                                 ReturnDate = rental.ReturnDate
                             };
                return result.SingleOrDefault();
            }
        }
    }
}
