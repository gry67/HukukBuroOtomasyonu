using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GaziU.HukukBuroOtomasyonu.BL.Services.Abstract
{
    public interface IGenericService<T> where T : class
    {
        bool Create(T entity);
        T GetById(int id);
        List<T> GetAll();
        bool Update(T entity);
        bool DeleteById(int id);
        IEnumerable<T> GetAll(Expression<Func<T, bool>> expression);
    }
}
