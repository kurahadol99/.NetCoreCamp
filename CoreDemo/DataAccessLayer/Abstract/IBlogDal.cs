using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal : IGenericDal<Blog>
    {
        //List<Blog> GetAll();
        //Blog GetBlog(int id);
        //void Add(Blog blog);
        //void Delete(Blog blog);
        //void Update(Blog blog);
        List<Blog> GetListWithCategory();
    }
}
