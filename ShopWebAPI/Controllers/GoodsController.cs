using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using ShopWebAPI.Models.Goods;
using ShopBLL.Services.Interface;

namespace ShopWebAPI.Controllers
{
    public class GoodsController : ApiController
    {
        [HttpPost]
        [Route ("api/Goods/Add")]
        public IHttpActionResult Add ([FromBody]AddModel model)
        {
            if (ModelState.IsValid)
            {
                
                return Ok ("");
            }
            return BadRequest ();
        }

        [HttpGet]
        [Route ("api/Goods/Remove")]
        public IHttpActionResult Remove ([FromUri]RemoveModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok ("");
            }
            return BadRequest ();
        }
    }
}