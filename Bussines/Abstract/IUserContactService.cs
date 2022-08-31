using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserContactService
    {
        IResult Add(UserContact userContact);
        IResult Update(UserContact userContact);
        IResult Delete(UserContact userContact);

        IDataResult<List<UserContact>> GetContacts(int userId);
    }
}
