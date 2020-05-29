using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using ShopBLL.Services.ServicesEntity;
using ShopWebAPI.Models.GoodsType;
using AutoMapper;
using ShopBLL.Entity.ShopItem.ShopGoods;

namespace ShopWebAPI.Controllers
{
    public class GoodsTypeController : ApiController
    {
        TypeOfGoodsService services;
        IMapper mapper;

        public GoodsTypeController (TypeOfGoodsService services)
        {
            this.services = services;
        }
        public GoodsTypeController ()
        { }

        [HttpPost]
        [Route ("api/GoodsType/Add")]
        [Authorize (Roles = "admin")]
        public IHttpActionResult Add ([FromBody]AddModel model)
        {
            if (ModelState.IsValid)
            {
                var _type = mapper.Map<TypeOfGoods> (model);
                services.Add (_type);
                return Ok ();
            } else
                return BadRequest (ModelState);
        }

        [HttpGet]
        [Route ("api/GoodsType/Remove/{id}")]
        [Authorize (Roles = "admin")]
        public IHttpActionResult Remove (int id)
        {
            services.Del (services.Get (id));

            return Ok ();
        }

        [HttpGet]
        [Route ("api/GoodsType/Get/{id}")]
        public IHttpActionResult Get (int id)
        {
            var type = services.Get (id);
            if (type != null)
            {
                TypeOfGoods _type = mapper.Map<TypeOfGoods> (type);
                return Ok (_type);
            }

            return NotFound ();
        }

        [HttpGet]
        [Route ("api/GoodsType/GetAll")]
        public IHttpActionResult GetAll ()
        {
            var type = services.GetAll ();

            if (type.Count () == 0)
                return NotFound ();

            var _type = mapper.Map<IEnumerable<TypeOfGoods>> (type);

            return Ok (_type);
        }
    }
}