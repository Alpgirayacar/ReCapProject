using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {

        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal; 
        }

        public IResult Add(User user)
        {
            if (user.FirstName.Length < 2)
            {
                //magic strings
                return new ErrorResult(Messages.UserNameInvalid);
            }
            _userDal.Add(user);

            return new SuccessResult(Messages.UserAdded);
        }

        public IDataResult<List<User>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<User>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UsersListed);

        }

       

        public IDataResult<List<User>> GetAllByUserId(int userId)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(p => p.UserId == userId));
        }

        public IDataResult<User> GetById(int userId)
        {
            return new SuccessDataResult<User>(_userDal.Get(p => p.UserId == userId));
        }

    
    }
}
