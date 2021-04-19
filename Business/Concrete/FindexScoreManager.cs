using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class FindexScoreManager : IFindexScoreService
    {
        IFindexScoreDal _findexScoreDal;

        public FindexScoreManager(IFindexScoreDal findexScoreDal)
        {
            _findexScoreDal = findexScoreDal;
        }

        public IResult Add(FindexScore findexScore)
        {
            _findexScoreDal.Add(findexScore);
            return new SuccessResult(Messages.ScoreAdded);
        }

        public IResult Delete(FindexScore findexScore)
        {
            _findexScoreDal.Delete(findexScore);
            return new SuccessResult(Messages.ScoreDeleted);
        }

        public IDataResult<List<FindexScore>> GetAll()
        {
            return new SuccessDataResult<List<FindexScore>>(_findexScoreDal.GetAll());
        }

        public IDataResult<FindexScore> GetByCustomerId(int customerId)
        {
            return new SuccessDataResult<FindexScore>(_findexScoreDal.Get(f => f.CustomerId == customerId));
        }

        public IResult Update(FindexScore findexScore)
        {
            _findexScoreDal.Update(findexScore);
            return new SuccessResult(Messages.ScoreUpdated);
        }
    }
}
