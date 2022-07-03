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
    public class StockManager : IStockService
    {
        private readonly IStockRepository _stockRepository;

        public StockManager(IStockRepository stockRepository)
        {
            _stockRepository = stockRepository;
        }

        public List<Stock> SearchResult(string malKodu, string baslangicTarih, string bitisTarih)
        {
            return _stockRepository.SearchResult(malKodu, baslangicTarih, bitisTarih);
        }
    }
}
