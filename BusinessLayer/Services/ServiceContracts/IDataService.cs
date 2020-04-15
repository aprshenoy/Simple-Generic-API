using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLayer.Services.ServiceContracts
{
    public interface IDataService<T>
    {
        T get(int id);
        T getAll();
        int insert(T value);
        int update(T value);
        int delete(int id);
    }
}
