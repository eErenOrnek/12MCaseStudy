using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12MCaseStudyDAL.Models
{
    public class Stock
    {
        [Key]
        public int SiraNo { get; set; }
        public string IslemTur { get; set; }
        public string EvrakNo { get; set; }
        public string Tarih { get; set; }
        public Decimal GirisMiktar { get; set; }
        public Decimal CikisMiktar { get; set; }
        public Decimal StokMiktar { get; set; }

        public override string ToString()
        {
            return "Sira No: " + SiraNo + " - Islem Tur: " + IslemTur + " - Evrak No: " + EvrakNo + " - Tarih: " + Tarih + " - Giris Miktar: " + GirisMiktar + " - Cikis Miktar: " + CikisMiktar + " - Stok Miktar: " + StokMiktar;  
        }
    }
}
