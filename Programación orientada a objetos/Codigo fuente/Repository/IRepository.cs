using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_POO.Repository
{
    public interface IRepository<T>
    {
        void Create(T item);

        List<T> GetAll();

        void Update(T item);

        void Delete(T item);
    }
}
