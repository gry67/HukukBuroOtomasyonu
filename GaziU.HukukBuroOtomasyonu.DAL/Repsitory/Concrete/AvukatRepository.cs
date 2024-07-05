using GaziU.HukukBuroOtomasyonu.DAL.Dto;
using GaziU.HukukBuroOtomasyonu.DAL.Models;
using GaziU.HukukBuroOtomasyonu.DAL.Repsitory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaziU.HukukBuroOtomasyonu.DAL.Repsitory.Concrete
{
    public class AvukatRepository : GenericRepository<Avukat>, IAvukatRepository
    {
        public AvukatRepository(AppDbContext _context) : base(_context)
        {
        }

        public Avukat GetAvukatByLogin(AvukatLoginDto loginData)
        {
            var avukat = context.Avukatlar.SingleOrDefault(a=> a.TcKimlikNo == loginData.AvukatTcNo && a.Sifre == loginData.Sifre);
            if (avukat!=null)
            {
                return avukat;
            }
            else
            {
                return null;
            }
        }
    }
}
