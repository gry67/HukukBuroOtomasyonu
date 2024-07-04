using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaziU.HukukBuroOtomasyonu.DAL.Models
{
    public class YargiTuru : BaseEntity
    {
        public string YargiTuruAdi { get; set; }


        public ICollection<YargiTuruMahkeme> YargiTuruMahkemeler { get; set; }
    }
}
