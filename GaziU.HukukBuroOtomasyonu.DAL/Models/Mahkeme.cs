using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaziU.HukukBuroOtomasyonu.DAL.Models
{
    public class Mahkeme : BaseEntity
    {
        public string MahkemeAdi { get; set; }
        public int YargiTuruId { get; set; }
        public YargiTuru YargiTuru { get; set; }
    }
}
