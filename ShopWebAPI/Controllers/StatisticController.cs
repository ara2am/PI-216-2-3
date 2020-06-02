using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using ShopBLL.Services.ServicesEntity;
using AutoMapper;
using ShopBLL.Entity.ShopItem.ShopUtility;

namespace ShopWebAPI.Controllers
{
    public class StatisticController : ApiController
    {
        StatisticService services;
        IMapper mapper;

        public StatisticController (StatisticService services)
        {
            this.services = services;
        }
        public StatisticController ()
        { }

        [HttpGet]
        [Route ("api/Statistic")]
        public IHttpActionResult Get ()
        {
            return Ok (services.Get ());
        }
    }
}