using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaziU.HukukBuroOtomasyonu.DAL.Models
{
    public class Avukat : BaseEntity
    {
        public string Adi { get; set; }
        public Int64 TcKimlikNo { get; set; }
        public string Sifre { get; set; }
    }
}
