﻿using Core.DataAccess.EntityFramework;
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
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentalProjectContext context = new RentalProjectContext())
            {
                var result = from c in context.Cars
                    join co in context.Colors
                        on c.ColorId equals co.Id
                    join br in context.Brands
                        on c.BrandId equals br.Id
                    select new CarDetailDto
                    {
                        Id = c.Id,
                        BrandId = br.Id,
                        BrandName = br.Name,
                        Name = c.Name,
                        ColorId = co.Id,
                        ColorName = co.Name,
                        DailyPrice = c.DailyPrice,
                        Description = c.Description,
                        ModelYear = c.ModelYear
                    };

                return result.ToList();
            }
        }
    }
}
