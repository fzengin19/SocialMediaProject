using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, ChatContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new ChatContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.OperationClaimId equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.UserId
                             select new OperationClaim { OperationClaimId = operationClaim.OperationClaimId, ClaimName = operationClaim.ClaimName };
                return result.ToList();

            }
        }

        public List<User> SearchUser(string searchText)
        {
            using (var context = new ChatContext())
            {
                var result = from user in context.Users
                             //where (user.FirstName.Contains(searchText) || user.LastName.Contains(searchText))
                             where ((user.FirstName+" "+user.LastName).Contains(searchText))
                             select new User { FirstName = user.FirstName, LastName = user.LastName, JoinDate = user.JoinDate, LastSeen = user.LastSeen,Status= user.Status,Email= user.Email,UserId = user.UserId  };
                return result.ToList();
            }
        }
    }
}
