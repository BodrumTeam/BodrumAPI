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
    [RoutePrefix("rpc/needs")]
    public class NeedsController : ApiController
    {
        private UnitOfWork uow = new UnitOfWork();
        // GET: api/Needs
        [Route("getAll")]
        public IEnumerable<Need> Get()
        {
            return uow.NeedManager.GetAll().ToList();
        }

        // GET: api/Needs/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Needs
        [Route("addNeed")]
        public void Post([FromBody]Need need)
        {
                Need newNeed = new Need();
                newNeed.description = need.description;
                newNeed.date = need.date;
                newNeed.fk_userId = need.fk_userId;
                newNeed.isApproved = need.isApproved;
                newNeed.isAvailable = need.isAvailable;
                newNeed.isDeleted = need.isDeleted;

                uow.NeedManager.Add(newNeed);
                uow.NeedManager.Save();
               
        }

        // PUT: api/Needs/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Needs/5
        public void Delete(int id)
        {
        }
    }
}
