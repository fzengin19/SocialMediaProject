using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBlockedUserService
    {
        IDataResult<List<BlockedUser>> GetBlockedUsers(User user);
        IResult Add(BlockedUser blockedUser);
        IResult Delete(BlockedUser blockedUser);
    }
}
