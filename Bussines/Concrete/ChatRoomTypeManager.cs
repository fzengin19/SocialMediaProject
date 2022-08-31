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
    public class ChatRoomTypeManager : IChatRoomTypeService
    {
        IChatRoomTypeDal _chatRoomTypeDal;

        public ChatRoomTypeManager(IChatRoomTypeDal chatRoomTypeDal)
        {
            _chatRoomTypeDal = chatRoomTypeDal;
        }

        public IResult Add(ChatRoomType chatRoomType)
        {
            _chatRoomTypeDal.Add(chatRoomType);
            return new SuccessResult();
        }

        public IResult Delete(ChatRoomType chatRoomType)
        {
            _chatRoomTypeDal.Delete(chatRoomType);
            return new SuccessResult();
        }

        public IResult Update(ChatRoomType chatRoomType)
        {
            _chatRoomTypeDal.Update(chatRoomType);
            return new SuccessResult();
        }
    }
}
