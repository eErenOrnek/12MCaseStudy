using _12MCaseStudyDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12MCaseStudyBusinessLayer.Abstract
{
    public interface IStkService
    {
        List<Stk> GetAll();
    }
}
