using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaziU.HukukBuroOtomasyonu.DAL.Models
{
    public class DavaDosyasi : BaseEntity
    {
        public int EsasNumarası { get; set; }
        public string MahkemeBilgisi { get; set; }



        public string DosyaDurumu { get; set; }
        public string Davaci { get; set; }
        public string Davali { get; set; }
        public string? DosyaNotu { get; set; }

        //Fiziksel arşivden bulunabilmesi için
        public int DosyaNumarasi { get; set; }
        public string DavaKonusu { get; set; }


        public double? IcraTutari { get; set; }
        public string? IcraTakipKonusu { get; set; }


        public int? AtananAvukatId { get; set; }
        public Avukat AtananAvukat { get; set; }

        public int? DurusmaId { get; set; }
        public ICollection<Durusma> Durusmalar { get; set; }

    }
}
