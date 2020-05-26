using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDAL.Context.Interface
{
    public interface IContext
    {
        int SaveChanges ();
        void Dispose ();
    }
}
