using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal iCommentDal)
        {
            _commentDal = iCommentDal;
        }

        public void Add(Comment comment)
        {
            _commentDal.Add(comment);
        }

        public List<Comment> GetComment(int id)
        {
            return _commentDal.GetListAll(x => x.BlogId == id);
        }
    }
}
