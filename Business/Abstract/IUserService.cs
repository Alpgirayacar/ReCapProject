using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();

        IDataResult<User> GetById(int id);
        IDataResult<List<User>> GetAllByUserId(int brandId);

      //  IDataResult<List<CarDetailDto>> GetCarDetails();

        IResult Add(User user);

    }
}
