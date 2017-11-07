using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Contracts
{
    public interface IDataHandler<T> where T:class
    {
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        List<T> GetAll();
        T Get(T entity);
    }
}
