using _12MCaseStudyDAL.Abstract;
using _12MCaseStudyDAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12MCaseStudyDAL.Concrete.EFCore
{
    public class EFCoreStkRepository : EFCoreGenericRepository<Stk>, IStkRepository
    {
        public EFCoreStkRepository(_12M_CASE_STUDYContext context) : base(context)
        {

        }

    }
}
