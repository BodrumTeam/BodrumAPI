using API.BLL.UnitOFWork;
using Entity.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    [RoutePrefix("rpc/item")]
    public class ItemController : ApiController
    {
        private UnitOfWork uow = new UnitOfWork();

        [Route("getAll")]
        public IEnumerable<Item> Get()
        {
            return uow.ItemManager.GetAll().ToList();
        }
        
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Item
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Item/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Item/5
        public void Delete(int id)
        {
        }
    }
}
