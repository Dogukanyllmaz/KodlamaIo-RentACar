using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, RentalProjectContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (var context = new RentalProjectContext())
            {
                var result = from c in context.Customers
                    join u in context.Users on c.UserId equals u.Id
                    join f in context.FindexScores on c.Id equals f.CustomerId
                    select new CustomerDetailDto
                    {
                        Id = c.Id,
                        FirstName = u.FirstName,
                        LastName = u.LastName,
                        Email = u.Email,
                        CompanyName = c.CompanyName,
                        UserId = u.Id,
                        FindexScoreValue = f.FindexScoreValue
                        
                    };

                return result.ToList();
            }
        }
        public List<CustomerDetailDto> GetCustomerDetailDto(Expression<Func<Customer, bool>> filter = null)
        {
            using (RentalProjectContext context = new RentalProjectContext())
            {
                var result = from customer in filter is null ? context.Customers : context.Customers.Where(filter)

                    join user in context.Users on customer.UserId equals user.Id
                    join findex in context.FindexScores on customer.Id equals findex.CustomerId
                    select new CustomerDetailDto()
                    {
                        Id = customer.Id,
                        CompanyName = customer.CompanyName,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        Email = user.Email,
                        FindexScoreValue = findex.FindexScoreValue
                    };
                return result.ToList();
            }
        }
    }
}
