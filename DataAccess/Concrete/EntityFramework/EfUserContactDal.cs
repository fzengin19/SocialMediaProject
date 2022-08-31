using DataAccess.Abstract;

using Entities.Concrete;
using Core.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserContactDal : EfEntityRepositoryBase<UserContact,ChatContext>, IUserContactDal
    {
    }
}
