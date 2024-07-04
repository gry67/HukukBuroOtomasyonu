using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaziU.HukukBuroOtomasyonu.DAL.Models
{
    public class YargiTuruMahkeme
    {
        public int YargiTuruId { get; set; }
        public YargiTuru YargiTuru { get; set; }

        public int MahkemeId { get; set; }
        public Mahkeme Mahkeme { get; set; }
    }
}
