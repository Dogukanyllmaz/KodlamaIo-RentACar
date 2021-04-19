using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Entities.Concrete;
using Core.Utilities.Security.Hashing;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userdal;
        public UserManager(IUserDal userDal)
        {
            _userdal = userDal;
        }
        [ValidationAspect(typeof(UserValidator))] //Validasyon işlemi
        public IResult Add(User user)
        {
            _userdal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Delete(User user)
        {
            _userdal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }

        public User GetByMail(string email)
        {
            return _userdal.Get(m => m.Email == email); //GetById ismine takılma
            // IEntityRepository de GetById olarak yazmışım. Ama illaki id'ye göre sorgulama yapmama gerek yok :)
        }

        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            return new SuccessDataResult<List<OperationClaim>>(_userdal.GetClaims(user), Messages.UserListed);
        }

        public IResult Update(User user)
        {
            _userdal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }

        public IDataResult<List<User>> GetAll()
        {
           
            return new SuccessDataResult<List<User>>(_userdal.GetAll(), Messages.UserListed);
        }

        public IDataResult<User> GetByUserId(int userId)
        {
            return new SuccessDataResult<User>(_userdal.Get(user => user.Id == userId));
        }

        public IDataResult<List<User>> GetByEmail(string email)
        {
            return new SuccessDataResult<List<User>>(_userdal.GetAll(user => user.Email == email));
        }

       
        public IDataResult<List<OperationClaim>> GetClaimById(int userId)
        {
            return new SuccessDataResult<List<OperationClaim>>(_userdal.GetClaimById(userId));
        }


    }
}