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
            using(RentalProjectContext context = new RentalProjectContext())
            {
                var result = from re in context.Rentals
                    join ca in context.Cars
                        on re.CarId equals ca.Id
                    join cus in context.Customers
                        on re.CustomerId equals cus.Id
                    join us in context.Users
                        on cus.UserId equals us.Id
                    select new RentalDetailDto
                    {
                        Id = re.Id,
                        CarName = ca.Name,
                        CustomerName = cus.CompanyName,
                        CarId = ca.Id,
                        RentDate = re.RentDate,
                        ReturnDate = re.ReturnDate,
                        UserName = us.FirstName + " " + us.LastName
                    };

                return result.ToList();
            }
        }
    }
}
