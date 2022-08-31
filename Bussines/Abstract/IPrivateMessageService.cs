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
    public interface IPrivateMessageService
    {
        IResult Add(PrivateMessage privateMessage);
        IResult Update(PrivateMessage privateMessage);
        IResult Delete(PrivateMessage privateMessage);
        IDataResult<List<PrivateMessage>> GetByRoomId(int chatRoomId,DateTime minDate, DateTime maxDate);

    }
}
