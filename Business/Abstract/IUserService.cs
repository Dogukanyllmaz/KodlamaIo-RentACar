using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<OperationClaim>> GetClaims(User user);
        User GetByMail(string email);
        IResult Update(User user);
        IResult Add(User user);
        IResult Delete(User user);
    }
}
