using _12MCaseStudy.Models;
using _12MCaseStudyBusinessLayer.Abstract;
using _12MCaseStudyDAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _12MCaseStudy.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStkService _stkService;
        private readonly IStockService _stockService;

        public HomeController(ILogger<HomeController> logger, IStkService stkService, IStockService stockService)
        {
            _logger = logger;
            _stkService = stkService;
            _stockService = stockService;
        }

        public IActionResult Index()
        {   
            return View();
        }

        [HttpGet]
        public object GetStkModelList() // Stk tablosundan comboboxı doldurmak için gerekli veriler paketlenir ve gönderilir
        {
            return _stkService.GetAll()
                .Select(stk => new StkModel()
                {
                    Id = stk.Id,
                    MalAdi = stk.MalAdi,
                    MalKodu = stk.MalKodu
                })
                .ToList();
        }

        [HttpGet]
        public List<StockModel> GetStocks(
            [FromQuery(Name = "malKodu")] string malKodu,
            [FromQuery(Name = "baslangicTarihi")] string baslangicTarih,
            [FromQuery(Name = "bitisTarihi")] string bitisTarih
            )
        {
            if (String.IsNullOrEmpty(malKodu))
            {
                return new List<StockModel>();   // mal kodu boş ise herhangi bir data dönülmemeli
            }

            // İlgili parametrelerle yazılan procedure çağırılır
            return _stockService.SearchResult(malKodu, baslangicTarih, bitisTarih).Select(stock => new StockModel()
            {
                SiraNo = stock.SiraNo,
                IslemTur = stock.IslemTur,
                EvrakNo = stock.EvrakNo,
                Tarih = stock.Tarih,
                GirisMiktar = stock.GirisMiktar,
                CikisMiktar = stock.CikisMiktar,
                StokMiktar = stock.StokMiktar
            }).ToList();
        }
    }
}
