using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.AbstractRepositories
{
    public interface IRepository<T> where T : class //T class olduğu sürece bunlar uygulanabilir.
    {
        //Task : Methodların async olarak kullanılmasıdır.
        //List Yerine IEnumerable kullanılabilir List ile nerdeyse birebir aynıdır aralarında performans farkı azdır.IEnumerable isteği ramde işler ve sonucu gösterir 
        //IQueryable IEnumerable ve listle benze olsa da istedi veritabanında işler bu sayede daha performanslıdır. fakat dezavantaj olarak çok fazla aynı satırda yapılan LİnQ isteği aynı anda işlemez.
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
    }
}
