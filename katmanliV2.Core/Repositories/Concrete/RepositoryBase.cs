using katmanliV2.Core.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace katmanliV2.Core.Repositories.Concrete
{
    public class RepositoryBase<T> : IRepository<T> where T : class
    {

        //dapper veya entity framework ile , nhabernate,  ado net olabilir
        public async Task<T> Add(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
