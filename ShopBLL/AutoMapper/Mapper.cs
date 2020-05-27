using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Interception;
using System.Text;
using AutoMapper;


namespace ShopBLL.AutoMapper
{
    public class MapperInfo : Profile
    {
        MapperInfo()
        {
            CreateMap<ShopBLL.Entity.ShopItem.ShopGoods.Goods, ShopDAL.Entity.ShopItem.ShopGoods.Goods>(MemberList.Destination).PreserveReferences();
            CreateMap<ShopBLL.Entity.ShopItem.ShopUtility.ShopOrder, ShopDAL.Entity.ShopUtility.ShopOrder>(MemberList.Destination).PreserveReferences();
            CreateMap<ShopBLL.Entity.ShopItem.ShopGoods.TypeOfGoods, ShopDAL.Entity.ShopItem.ShopGoods.TypeOfGoods>(MemberList.Destination).PreserveReferences();
            CreateMap<ShopBLL.Entity.User.User, ShopDAL.Entity.User>(MemberList.Destination).PreserveReferences();

            CreateMap<ShopDAL.Entity.ShopItem.ShopGoods.Goods, ShopBLL.Entity.ShopItem.ShopGoods.Goods>(MemberList.Source).PreserveReferences();
            CreateMap<ShopDAL.Entity.ShopUtility.ShopOrder, ShopBLL.Entity.ShopItem.ShopUtility.ShopOrder>(MemberList.Source).PreserveReferences();
            CreateMap<ShopDAL.Entity.ShopItem.ShopGoods.TypeOfGoods, ShopBLL.Entity.ShopItem.ShopGoods.TypeOfGoods>(MemberList.Source).PreserveReferences();
            CreateMap<ShopBLL.Entity.User.User, ShopDAL.Entity.User>(MemberList.Source).PreserveReferences();

        }
    }
}
