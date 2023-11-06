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
    public class BlogManager : IBlogService
    {
        IBlogDal _iBlogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _iBlogDal = blogDal;
        }


        public void Add(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void Delete(Blog blog)
        {
            throw new NotImplementedException();
        }

        public Blog GetBlogById(int id)
        {
            return _iBlogDal.GetById(id);
        }     
        public List<Blog> GetById(int id)
        {
            return _iBlogDal.GetListAll(x => x.BlogId == id);
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _iBlogDal.GetListWithCategory();
        }

        public List<Blog> GetBlogs()
        {
            return _iBlogDal.GetListAll();
        }

        public void Update(Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}
