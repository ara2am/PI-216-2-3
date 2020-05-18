using System;
using System.Collections.Generic;
using System.Text;

namespace ShopBLL.Repository.Interface
{
    interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int Id);
        void Add(T obj);
        void Update(T obj);
        void Del(int Id);
    }
}
