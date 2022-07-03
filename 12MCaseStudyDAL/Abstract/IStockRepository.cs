using _12MCaseStudyDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12MCaseStudyDAL.Abstract
{
    public interface IStockRepository : IRepository<Stock>
    {
        List<Stock> SearchResult(string malKodu, string baslangicTarih, string bitisTarih);
    }
}
