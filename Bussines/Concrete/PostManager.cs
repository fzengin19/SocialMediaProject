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
    public class PostManager : IPostService
    {
        IPostDal _postDal;

        public PostManager(IPostDal postDal)
        {
            _postDal = postDal;
        }

        public IResult Add(Post post)
        {
            _postDal.Add(post);
            return new SuccessResult();
        }

        public IResult Delete(Post post)
        {
            _postDal.Delete(post);
            return new SuccessResult();
        }

        public IDataResult<List<Post>> GetPosts(List<UserContact> userContacts)
        {
            List<Post> posts = new List<Post>();
            foreach (var contact in userContacts)
            {
                posts = _postDal.GetAll(p => p.UserId == contact.UserId);
                foreach (var post in posts)
                {
                    posts.Add(post);
                }
            }
            return new SuccessDataResult<List<Post>>(posts);
        }

        public IResult Update(Post post)
        {
            _postDal.Update(post);
            return new SuccessResult();
        }

    }
}
