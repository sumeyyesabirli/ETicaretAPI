using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositories
{
    //Bir veritanından sorgu ile data elde edeceksek buna Read işlemleri diyoruz 
    //Veritabanındaki işlemleri,sorguları  modelledik 
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        // hangi türde isek (T) bana   verileri getir
        IQueryable<T> GetAll(bool tracking =true);

        //Şarta uygun olan birden fazla veri elde edilsin 
        IQueryable<T> GetWhere(Expression<Func<T,bool>>method, bool tracking = true);

        //Şarta uygun olan ilk veriyi getirir 
        Task<T> GetSingleAsync(Expression<Func<T,bool>>method, bool tracking = true);
         
        //Id ye uygun hangisi ise onu getirecek 
        Task<T> GetByIdAsync(string id, bool tracking = true);
    }
}
