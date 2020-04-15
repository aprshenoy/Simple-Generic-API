
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperCoreTest.Repositories.Interfaces
{
    public interface IRepository<T> where T:class
    {
        Task<T> get(int id);
        Task<T> getAll();
        Task<int> insert(T value);
        Task<int> update(T value);
        Task<int> delete(int id);
     
    }
}
