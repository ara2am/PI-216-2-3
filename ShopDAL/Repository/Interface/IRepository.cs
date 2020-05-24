using System;
using System.Collections.Generic;
using System.Text;

namespace ShopBLL.Repository.Interface
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int Id);
        void Add(T obj);
        void Del(T obj);
        void Update(int id, T obj);
    }
}
