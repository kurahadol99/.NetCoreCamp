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
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
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
            return _blogDal.GetById(id);
        }
        public List<Blog> GetById(int id)
        {
            return _blogDal.GetListAll(x => x.BlogId == id);
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public List<Blog> GetBlogs()
        {
            return _blogDal.GetListAll();
        }

        public void Update(Blog blog)
        {
            throw new NotImplementedException(); 
        }
        
        public List<Blog> GetBlogListByWriter(int id)
        {
            return _blogDal.GetListAll(x => x.WriterId == id).TakeLast(2).ToList();
        }
        public List<Blog> GetLast3Blog()
        {
            return _blogDal.GetListAll().Take(3).ToList();
        }
    }
}
