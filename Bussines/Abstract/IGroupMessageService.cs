using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGroupMessageService
    {
        IResult Add(GroupMessage groupMessage);
        IResult Update(GroupMessage groupMessage);
        IResult Delete(GroupMessage groupMessage);
        IDataResult<List<GroupMessage>> GetGroupMessages(int chatRoomId, DateTime minDate, DateTime maxDate);
    }
}
