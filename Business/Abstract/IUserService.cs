using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<OperationClaim>> GetClaims(User user);

        IDataResult<List<User>> GetAll();

        IDataResult<User> Get(int id);

        IResult Add(User entity);

        IResult Update(User entity);

        IResult Delete(User entity);

        IDataResult<User> GetByEmail(string email);
    }
}
