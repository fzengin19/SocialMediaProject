using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserDetailService
    {
        IResult Add(UserDetail userDetail);


        IResult Delete(UserDetail userDetail);
        IResult Update(UserDetail userDetail);

        IDataResult<UserDetail> GetByUserId(int userId);
    }
}
