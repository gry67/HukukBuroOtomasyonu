using GaziU.HukukBuroOtomasyonu.DAL.Models;
using GaziU.HukukBuroOtomasyonu.DAL.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaziU.HukukBuroOtomasyonu.DAL.Repsitory.Abstract
{
    public interface IAvukatRepository : IGenericRepository<Avukat>
    {
        Avukat GetAvukatByLogin(AvukatLoginDto loginData);
    }
}
