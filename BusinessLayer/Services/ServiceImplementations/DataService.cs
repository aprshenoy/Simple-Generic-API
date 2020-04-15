using BusinessLayer.Services.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Services.ServiceImplementations
{
    class DataService<T> : IDataService<T> where T:class
    {

        public int delete(int value)
        {
            return 1;
        }

        public T get(int id)
        {
            throw new NotImplementedException();
           // return new T();
        }

        public T getAll()
        {
            throw new NotImplementedException();
        }


        public int insert(T value)
        {
            throw new NotImplementedException();
        }


        public int update(T value)
        {
            throw new NotImplementedException();
        }
    }
    
}
