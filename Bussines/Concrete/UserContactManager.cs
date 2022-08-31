using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserContactManager : IUserContactService
    {
        IUserContactDal _userContactDal;

        public UserContactManager(IUserContactDal userContactDal)
        {
            _userContactDal = userContactDal;
        }

        public IResult Add(UserContact userContact)
        {
            _userContactDal.Add(userContact);
            return new SuccessResult();
        }

        public IResult Delete(UserContact userContact)
        {
            _userContactDal.Delete(userContact);
            return new SuccessResult();
        }

        public IDataResult<List<UserContact>> GetContacts(int userId)
        {
            return new SuccessDataResult<List<UserContact>>(_userContactDal.GetAll(c => c.UserId == userId ));
        }

        public IResult Update(UserContact userContact)
        {
            _userContactDal.Update(userContact);
            return new SuccessResult();
        }


    }
}
