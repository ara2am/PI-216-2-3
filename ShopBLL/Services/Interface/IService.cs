using ShopDAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBLL.Services.Interface
{
    public interface IService<TObject> : IDisposable where TObject : class
    {
        UnitOfWork Unit { get; }
        void Add(TObject obj);
        void Del(TObject obj);
        TObject Get(int id);
        ICollection<TObject> GetAll();
        void Update(int id, TObject obj);
    }
}
