using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaziU.HukukBuroOtomasyonu.DAL.Models
{
    public class Durusma : BaseEntity
    {
        public int DavaDosyasiId { get; set; }
        public DavaDosyasi DavaDosyasi { get; set; }
        public DateTime DurusmaGunu { get; set; }
        public string DurusmaYeri { get; set; }
    }
}
