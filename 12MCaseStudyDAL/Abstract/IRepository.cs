using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12MCaseStudyDAL.Abstract
{
    public interface IRepository<T> where T : class
    {
        T GetById(int id);
        List<T> GetAll();
        void Create(T model);
        void Update(T model);
        void Delete(T model);
    }
}
