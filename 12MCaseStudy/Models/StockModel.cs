using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _12MCaseStudy.Models
{
    public class StockModel
    {
        public int SiraNo { get; set; }
        public string IslemTur { get; set; }
        public string EvrakNo { get; set; }
        public string Tarih { get; set; }
        public Decimal GirisMiktar { get; set; }
        public Decimal CikisMiktar { get; set; }
        public Decimal StokMiktar { get; set; }
    }
}
