using ShopBLL.Services.Interface;
using ShopDAL.Context.ContextClasses;
using ShopDAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using AutoMapper;

namespace ShopBLL.Services.ServicesEntity
{
    public abstract class Service<TObject> : IService<TObject> where TObject : class
    {
        protected readonly IMapper mapper;
        public UnitOfWork Unit { get; }

        public Service(string connection)
        {
            Unit = new UnitOfWork(new ShopContext(connection));
        }

        public abstract void Add(TObject obj);
        public abstract void Del(TObject obj);
        public abstract TObject Get(int id);
        public abstract ICollection<TObject> GetAll();
        public abstract void Update(int id, TObject obj);

        public void Dispose()
        {
            Unit.Dispose();
        }
    }
}
