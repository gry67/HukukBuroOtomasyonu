using GaziU.HukukBuroOtomasyonu.DAL.Dto;
using GaziU.HukukBuroOtomasyonu.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaziU.HukukBuroOtomasyonu.BL.Services.Abstract
{
    public interface IAvukatService : IGenericService<Avukat>
    {
        Avukat GetAvukatByLogin(AvukatLoginDto loginData);
    }
}
