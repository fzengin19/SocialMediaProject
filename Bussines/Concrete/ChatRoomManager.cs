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
    public class ChatRoomManager : IChatRoomService
    {
        IChatRoomDal _chatRoomDal;

        public ChatRoomManager(IChatRoomDal chatRoomDal)
        {
            _chatRoomDal = chatRoomDal;
        }

        public IResult Add(ChatRoom chatRoom)
        {
            _chatRoomDal.Add(chatRoom);
            return new SuccessResult();
        }

        public IResult Delete(ChatRoom chatRoom)
        {
            _chatRoomDal.Delete(chatRoom);
            return new SuccessResult();
        }

        public IResult Update(ChatRoom chatRoom)
        {
            _chatRoomDal.Update(chatRoom);
            return new SuccessResult();
        }
    }
}
