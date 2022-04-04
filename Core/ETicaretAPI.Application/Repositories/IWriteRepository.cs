using ETicaretAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositories
{
    //İşlemler sonrasında değeri true veya false döneceği için bool verilmiştir
    public interface IWriteRepository<T>  : IRepository <T> where T : BaseEntity
    { 
        //Gelen modeli ekleme
        Task<bool> AddAsync(T model);
        // Birden fazla gelen modeli almak için List i ekliyoruz
        Task<bool> AddRangeAsync(List<T> datas);
        bool Remove(T model);
        bool RemoveRange(List<T> datas);
        // Id verilen veriyi silme 
        Task<bool> RemoveAsync(string id);
        bool Update(T model);
        Task<int> SaveAsync();
    }
    
}
