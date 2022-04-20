using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace katmanliV2.Core.Repositories.Abstract
{
    public interface IRepository<T> where T : class
    {
        Task<T> Add(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(T entity);
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();
    }
}

/*
    IList, List, IEnumerable, ICollection
 */
