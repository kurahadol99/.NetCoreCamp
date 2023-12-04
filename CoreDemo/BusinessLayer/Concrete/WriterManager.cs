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
	public class WriterManager : IWriterService
	{
		IWriterDal _writerDal;
		public WriterManager(IWriterDal writerDal)
		{
			_writerDal = writerDal;
		}

		public void Add(Writer writer)
		{
			_writerDal.Add(writer);
		}

        public void Delete(Writer entity)
        {
            throw new NotImplementedException();
        }

        public Writer Get(int id)
        {
            return _writerDal.GetById(id);
        }

        public List<Writer> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetWriterById(int id)
        {
            return _writerDal.GetListAll(x=> x.WriterId == id);
        }

        public void Update(Writer entity)
        {
            _writerDal.Update(entity);
        }
    }
}
