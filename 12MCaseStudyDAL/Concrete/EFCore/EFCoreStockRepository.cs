using _12MCaseStudyDAL.Abstract;
using _12MCaseStudyDAL.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12MCaseStudyDAL.Concrete.EFCore
{
    public class EFCoreStockRepository : EFCoreGenericRepository<Stock>, IStockRepository
    {
        private readonly _12M_CASE_STUDYContext _context;
        public EFCoreStockRepository(_12M_CASE_STUDYContext context) : base(context)
        {
            _context = context;
        }
        public List<Stock> SearchResult(string malKodu, string baslangicTarih, string bitisTarih)
        {
            List<Stock> stockList;
            string sql = "EXEC ListStocks @MalKodu, @BaslangicTarih, @BitisTarih";
            List<SqlParameter> parms = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@MalKodu", Value = malKodu},
                new SqlParameter{ParameterName = "@BaslangicTarih", Value = baslangicTarih},
                new SqlParameter{ParameterName = "@BitisTarih", Value = bitisTarih}
            };

            // İlgili parametreler ile ListStock procedureı çağırılır
            stockList = _context.Stocks.FromSqlRaw<Stock>(sql, parms.ToArray()).ToList();
            return stockList;
        }
    }
}
