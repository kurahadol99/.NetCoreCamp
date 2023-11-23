using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService
    {
        List<Blog> GetBlogs();
        Blog GetBlogById(int id);
        void Add(Blog blog);
        void Update(Blog blog);
        void Delete(Blog blog);
        List<Blog> GetBlogListWithCategory();
        List<Blog> GetBlogListByWriter(int id);
    }
}
