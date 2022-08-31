using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
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
    public class PrivateMessageManager : IPrivateMessageService
    {   
        private readonly IPrivateMessageDal _privateMessageDal;

        public PrivateMessageManager(IPrivateMessageDal privateMessagService)
        {
            _privateMessageDal = privateMessagService;
        }
        [SecuredOperation("User,Admin")]
        public IResult Add(PrivateMessage privateMessage)
        {
            _privateMessageDal.Add(privateMessage);
            return new SuccessResult();
        }
        [SecuredOperation("User,Admin")]
        public IResult Delete(PrivateMessage privateMessage)
        {
            _privateMessageDal.Delete(privateMessage);
            return new SuccessResult();
        }
        [SecuredOperation("User,Admin")]
        public IDataResult<List<PrivateMessage>> GetByRoomId(int chatRoomId, DateTime minDate,DateTime maxDate)
        {
            return new SuccessDataResult<List<PrivateMessage>>(_privateMessageDal.GetAll(pm => pm.ChatRoomId== chatRoomId && pm.SendDate>minDate && pm.SendDate<maxDate));
        }
        [SecuredOperation("User,Admin")]
        public IResult Update(PrivateMessage privateMessage)
        {
            _privateMessageDal.Update(privateMessage);
            return new SuccessResult();
        }



    }
}
