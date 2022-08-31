using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Core.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfChatRoomTypeDal : EfEntityRepositoryBase<ChatRoomType,ChatContext>, IChatRoomTypeDal
    {
    }
}
