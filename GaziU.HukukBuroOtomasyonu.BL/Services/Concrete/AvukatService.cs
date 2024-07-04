using GaziU.HukukBuroOtomasyonu.BL.Services.Abstract;
using GaziU.HukukBuroOtomasyonu.DAL.Dto;
using GaziU.HukukBuroOtomasyonu.DAL.Models;
using GaziU.HukukBuroOtomasyonu.DAL.Repsitory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaziU.HukukBuroOtomasyonu.BL.Services.Concrete
{
    public class AvukatService : GenericService<Avukat>, IAvukatService
    {
        private IAvukatRepository avRepo;
        public AvukatService(IGenericRepository<Avukat> _repository, IAvukatRepository avRepo) : base(_repository)
        {
            this.avRepo = avRepo;
        }

        public Avukat GetAvukatByLogin(AvukatLoginDto loginData)
        {
            return avRepo.GetAvukatByLogin(loginData);
        }
    }
}
