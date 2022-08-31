using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FriendRequestManager : IUserFriendRequestService
    {
        IUserFriendRequestDal _userFriendRequestDal;

        public FriendRequestManager(IUserFriendRequestDal userFriendRequestDal)
        {
            _userFriendRequestDal = userFriendRequestDal;
        }

        public IResult Add(FriendRequest userFriendRequest)
        {
            _userFriendRequestDal.Add(userFriendRequest);
            return new SuccessResult();
        }

        public IResult Delete(FriendRequest userFriendRequest)
        {
            _userFriendRequestDal.Delete(userFriendRequest);
            return new SuccessResult();
        }

        public IResult Update(FriendRequest userFriendRequest)
        {
            _userFriendRequestDal.Update(userFriendRequest);
            return new SuccessResult();
        }
    }
}
