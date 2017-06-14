using API.BLL.UnitOFWork;
using API.DTO;
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
        public IEnumerable<ItemDTO> Get()
        {
            return uow.ItemManager.GetAll().ToList().Select(c => new ItemDTO
            {
                Title = c.title,
                Description = c.description,
                Photo = c.photo,
                Price = c.price,
                Date = c.date,
                isApproved = c.isApproved,
                isAvailable = c.isAvailable,
                isDeleted = c.isDeleted,
                fk_userId = c.fk_userId,
                fk_categoryId =c.fk_categoryId
            }).ToList();


        }

        [Route("getById/{id}")]
        // GET: rpc/item/5
        public Item Get(int id)
        {
            Item item = uow.ItemManager.GetById(id);
            return item;
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
