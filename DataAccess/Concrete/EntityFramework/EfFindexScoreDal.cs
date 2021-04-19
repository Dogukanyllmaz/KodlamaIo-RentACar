using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfFindexScoreDal : EfEntityRepositoryBase<FindexScore, RentalProjectContext>, IFindexScoreDal
    {
    }
}
