using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IFindexScoreService
    {
        IDataResult<List<FindexScore>> GetAll();
        IDataResult<FindexScore> GetByCustomerId(int customerId);
        IResult Add(FindexScore findexScore);
        IResult Delete(FindexScore findexScore);
        IResult Update(FindexScore findexScore);

    }
}
