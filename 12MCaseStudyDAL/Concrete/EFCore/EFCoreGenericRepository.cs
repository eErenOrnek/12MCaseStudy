using _12MCaseStudyDAL.Abstract;
using _12MCaseStudyDAL.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12MCaseStudyDAL.Concrete.EFCore
{
    public class EFCoreGenericRepository<TModel> : IRepository<TModel> where TModel : class
    {

        private readonly _12M_CASE_STUDYContext _context;

        public EFCoreGenericRepository(_12M_CASE_STUDYContext context)
        {
            _context = context;
        }

        public void Create(TModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(TModel model)
        {
            throw new NotImplementedException();
        }

        public List<TModel> GetAll()
        {
            return _context.Set<TModel>().ToList();
        }

        public TModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(TModel model)
        {
            throw new NotImplementedException();
        }
    }
}
