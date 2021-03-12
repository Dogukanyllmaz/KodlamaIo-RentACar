using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentalProjectContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (var context = new RentalProjectContext())
            {
                var result = from rent in context.Rentals
                    join car in context.Cars on rent.CarId equals car.Id
                    join brand in context.Brands on car.BrandId equals brand.Id
                    join color in context.Colors on car.ColorId equals color.Id
                    join cus in context.Customers on rent.CustomerId equals cus.Id
                    join user in context.Users on cus.UserId equals user.Id
                    select new RentalDetailDto
                    {
                        Id = rent.Id,
                        CarName = car.Description,
                        BrandName = brand.Name,
                        ColorName = color.Name,
                        CompanyName = cus.CompanyName,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        RentDate = rent.RentDate,
                    };

                return result.ToList();
            }
        }
    }
}
