using Business.Abstract;
using Business.Constants;
using Core.Aspects.Autofac.Transaction;
using Core.Entities.Concrete;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserDetailManager : IUserDetailService
    {
        private readonly IUserDeatilDal _userDeatilDal;


        public UserDetailManager(IUserDeatilDal userDeatilDal)
        {
            _userDeatilDal = userDeatilDal;
        }

        public IResult Add(UserDetail userDetail)
        {
            _userDeatilDal.Add(userDetail);
            return new SuccessResult();
        }

        public IResult Delete(UserDetail userDetail)
        {
            UserDetail user = new Entities.Concrete.UserDetail { UserId = userDetail.UserId, Biography = "bio", Gender = 0, BirthDate = userDetail.BirthDate};
            _userDeatilDal.Update(user);
            return new SuccessResult();
        }

        public IDataResult<UserDetail> GetByUserId(int userId)
        {
            return new SuccessDataResult<UserDetail>(_userDeatilDal.Get(ud => Convert.ToInt32( ud.UserId) == userId ));
        }

        public IResult Update(UserDetail userDetail)
        {
             _userDeatilDal.Update(userDetail);
             return new SuccessResult();
        }

      

    }
}
