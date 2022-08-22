using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnessLayer.Abstract
{
    public interface IGenericService<T> where T : AEntity
    {
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
        List<T> GetAll();
        T GetById(int id);
    }
}
