using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IChatRoomService
    {
        IResult Add(ChatRoom chatRoom);
        IResult Update(ChatRoom chatRoom);
        IResult Delete(ChatRoom chatRoom);
    }
}
