using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBLL.Entity
{
    public class Statistic
    {
        public int TotalCountOfUsers { get; set; }
        public int TotalCountOfGoods { get; set; }
        public int TotalCountOfGoodsTypes { get; set; }
        public int TotalCountOfOrders { get; set; }
    }
}