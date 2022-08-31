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
    public class ChatRoomUserManager : IChatRoomUserService
    {
        IChatRoomUserDal _chatRoomUserDal;

        public ChatRoomUserManager(IChatRoomUserDal chatRoomUserDal)
        {
            _chatRoomUserDal = chatRoomUserDal;
        }

        public IResult Add(ChatRoomUser chatRoomUser)
        {
            _chatRoomUserDal.Add(chatRoomUser);
            return new SuccessResult();
        }

        public IResult Delete(ChatRoomUser chatRoomUser)
        {
            _chatRoomUserDal.Delete(chatRoomUser);
            return new SuccessResult();
        }

        public IResult Update(ChatRoomUser chatRoomUser)
        {
            _chatRoomUserDal.Update(chatRoomUser);
            return new SuccessResult();
        }
    }
}
