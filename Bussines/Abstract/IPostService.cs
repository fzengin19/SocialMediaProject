using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPostService
    {
        IResult Add(Post post);
        IResult Update(Post post);
        IResult Delete(Post post);

        IDataResult<List<Post>> GetPosts(List<UserContact> userContacts);
    }
}
