﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using ShopWebAPI.Models.Goods;
using ShopBLL.Services.Interface;
using ShopBLL.Services.ServicesEntity;
using ShopBLL.Entity.ShopItem.ShopGoods;
using AutoMapper;
using ShopBLL.Entity.ShopItem.ShopUtility.ShopEnums;

namespace ShopWebAPI.Controllers
{
    public class GoodsController : ApiController
    {
        GoodsServices services;
        IMapper mapper;

        public GoodsController (GoodsServices services)
        {
            this.services = services;
        }
        public GoodsController ()
        { }

        [HttpPost]
        [Route ("api/Goods/Add")]
        [Authorize (Roles = "admin")]
        public IHttpActionResult Add ([FromBody]AddModel model)
        {
            if (ModelState.IsValid)
            {
                var _goods = mapper.Map<Goods> (model);
                services.Add (_goods);
                return Ok ();
            } else
                return BadRequest (ModelState);
        }

        [HttpGet]
        [Route ("api/Goods/Remove/{id}")]
        [Authorize (Roles = "admin")]
        public IHttpActionResult Remove (int id)
        {
            services.Del (services.Get (id));

            return Ok ();
        }

        [HttpGet]
        [Route ("api/Goods/Get/{id}")]
        public IHttpActionResult Get (int id)
        {
            var goods = services.Get (id);
            if (goods != null)
            {
                Goods _goods = mapper.Map<Goods> (goods);
                return Ok (_goods);
            }

            return NotFound ();
        }

        [HttpGet]
        [Route ("api/Goods/GetAll")]
        public IHttpActionResult GetAll ()
        {
            var goods = services.GetAll ();

            if (goods.Count () == 0)
                return NotFound ();

            var _goods = mapper.Map<IEnumerable<Goods>> (goods);

            return Ok (_goods);
        }

        [HttpGet]
        [Route ("api/Goods/Search/{sortCriteria}")]
        public IHttpActionResult SortBy (SortCriteria sortCriteria)
        {
            var criteria = mapper.Map<SortCriteria> (sortCriteria);
            var sorted_goods = mapper.Map<IEnumerable<Goods>> (services.SortBy (criteria));

            if (sorted_goods.Count () == 0)
                return BadRequest ();

            return Ok (sorted_goods);
        }

        [HttpGet]
        [Route ("api/Goods/SortByDescending/{sortCriteria}")]
        public IHttpActionResult SortByDescending (SortCriteria sortCriteria)
        {
            var criteria = mapper.Map<SortCriteria> (sortCriteria);
            var sorted_goods = mapper.Map<IEnumerable<Goods>> (services.SortByDescending (criteria));

            if (sorted_goods.Count () == 0)
                return BadRequest ();

            return Ok (sorted_goods);
        }

        [HttpGet]
        [Route ("api/Goods/filterCategory/{id}")]
        public IHttpActionResult FilterByCategory (int id)
        {
            var goods = services.FilterByCategory (id);
            var filter_goods = mapper.Map<IEnumerable<Goods>> (goods);

            if (filter_goods.Count () == 0)
                return BadRequest ();

            return Ok (filter_goods);
        }
    }
}