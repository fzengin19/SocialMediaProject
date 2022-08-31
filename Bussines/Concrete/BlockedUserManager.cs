using Business.Abstract;
using Core.Entities.Concrete;
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
    public class BlockedUserManager : IBlockedUserService
    {
        private readonly IBlockedUserDal _blockedUserDal;
       
        public BlockedUserManager(IBlockedUserDal blockedUserDal)
        {
            _blockedUserDal = blockedUserDal;
        }

        public IResult Add(BlockedUser blockedUser)
        {
            _blockedUserDal.Add(blockedUser);
            return new SuccessResult();
        }

        public IResult Delete(BlockedUser blockedUser)
        {
            _blockedUserDal.Delete(blockedUser);
            return new SuccessResult();
        }

        public IDataResult<List<BlockedUser>> GetBlockedUsers(User user)
        {
            return new SuccessDataResult<List<BlockedUser>>(_blockedUserDal.GetAll(b => b.BlockingId == user.UserId ));
        }


    }
}
