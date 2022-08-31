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
    public class GroupMessageManager : IGroupMessageService
    {
        private readonly IGroupMessageDal _groupMessageDal;

        public GroupMessageManager(IGroupMessageDal groupMessageDal)
        {
            _groupMessageDal = groupMessageDal;
        }

        public IResult Add(GroupMessage groupMessage)
        {
            _groupMessageDal.Add(groupMessage);
            return new SuccessResult();
        }

        public IResult Delete(GroupMessage groupMessage)
        {
            _groupMessageDal.Delete(groupMessage);
            return new SuccessResult();
        }

        public IDataResult<List<GroupMessage>> GetGroupMessages(int chatRoomId, DateTime minDate, DateTime maxDate)
        {
            return new SuccessDataResult<List<GroupMessage>>(_groupMessageDal.GetAll(g => g.ChatRoomId == chatRoomId && g.SendDate>minDate));
        }

        public IResult Update(GroupMessage groupMessage)
        {
            _groupMessageDal.Update(groupMessage);
            return new SuccessResult();
        }
    }
}
