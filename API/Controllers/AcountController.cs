using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API.JsonWebToken;
using API.DTO;
using API.BLL.Managers;
using API.BLL.UnitOFWork;
using API.Enum;

namespace API.Controllers
{
    [RoutePrefix("rpc/account")]
    public class AcountController : ApiController
    {
        private UnitOfWork uow = new UnitOfWork();
        // GET: api/Acount
        public IEnumerable<string> Get()
        {
            string s = Token.GenerateToken("hassona", 20);
            return new string[] { "value1", "value2" };
        }

        // GET: api/Acount/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: rpc/account/login
        [Route("login")]
        public IHttpActionResult PostLogin([FromBody]UserLogin userLogin)
        {
            if(uow.UserManager.IsUserExist(userLogin))
            { 
                string s = Token.GenerateToken(userLogin.username, 20);
                return Ok(new { id_token = s });
            }
            else
            {
                throw new UnauthorizedAccessException();
            }
        }

        // POST: rpc/Acount/signup
        [Route("signup")]
        public HttpResponseMessage PostSignUp([FromBody]UserLogin userLogin)
        {
            RegisterResult RegisterResult = uow.UserManager.Register(userLogin);
            if (RegisterResult == RegisterResult.ok)
            {
                string s = Token.GenerateToken(userLogin.username, 20);
                return Request.CreateResponse(HttpStatusCode.OK,s);
            }
            else
            {
              return  Request.CreateResponse(HttpStatusCode.InternalServerError, RegisterResult.ToString());
            }
        }


        // PUT: api/Acount/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Acount/5
        public void Delete(int id)
        {
        }
    }
}
