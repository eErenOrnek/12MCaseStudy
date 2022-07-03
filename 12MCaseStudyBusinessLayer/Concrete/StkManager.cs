using _12MCaseStudyBusinessLayer.Abstract;
using _12MCaseStudyDAL.Abstract;
using _12MCaseStudyDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12MCaseStudyBusinessLayer.Concrete
{
    public class StkManager : IStkService
    {
        private readonly IStkRepository _stkRepository;

        public StkManager(IStkRepository stkRepository)
        {
            _stkRepository = stkRepository;
        }

        public List<Stk> GetAll()
        {
            return _stkRepository.GetAll();
        }
    }
}
