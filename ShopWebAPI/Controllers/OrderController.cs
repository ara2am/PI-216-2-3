using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using ShopBLL.Services.ServicesEntity;
using ShopWebAPI.Models.GoodsType;
using AutoMapper;
using ShopBLL.Entity.ShopItem.ShopUtility;

namespace ShopWebAPI.Controllers
{
    public class OrderController : ApiController
    {
        ShopOrderService services;
        IMapper mapper;

        public OrderController (ShopOrderService services)
        {
            this.services = services;
        }
        public OrderController ()
        { }

        [HttpPost]
        [Route ("api/Order/Add")]
        public IHttpActionResult Add ([FromBody]AddModel model)
        {
            if (ModelState.IsValid)
            {
                var _order = mapper.Map<ShopOrder> (model);
                services.Add (_order);
                return Ok ();
            } else
                return BadRequest (ModelState);
        }

        [HttpGet]
        [Route ("api/Order/Remove/{id}")]
        public IHttpActionResult Remove (int id)
        {
            services.Del (services.Get (id));

            return Ok ();
        }

        [HttpGet]
        [Route ("api/Order/Get/{id}")]
        [Authorize (Roles = "admin")]
        public IHttpActionResult Get (int id)
        {
            var order = services.Get (id);
            if (order != null)
            {
                ShopOrder _order = mapper.Map<ShopOrder> (order);
                return Ok (_order);
            }

            return NotFound ();
        }

        [HttpGet]
        [Route ("api/Order/GetAll")]
        [Authorize (Roles = "admin")]
        public IHttpActionResult GetAll ()
        {
            var order = services.GetAll ();

            if (order.Count () == 0)
                return NotFound ();

            var _order = mapper.Map<IEnumerable<ShopOrder>> (order);

            return Ok (_order);
        }
    }
}