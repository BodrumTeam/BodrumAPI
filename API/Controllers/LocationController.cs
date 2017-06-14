using API.BLL.UnitOFWork;
using Entity.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API.JsonWebToken;
using API.DTO;
using API.Enum;

namespace API.Controllers
{
    [RoutePrefix("rpc/location")]
    public class LocationController : ApiController
    {
        private UnitOfWork uow = new UnitOfWork();
        
        [Route("countries/getAll")]
        public IEnumerable<Country> GetCountries()
        {
            return uow.CountryManager.GetAll();
        }

        [Route("cities/getAll")]
        public IEnumerable<CityDTO> GetCities()
        {
            return  uow.CityManager.GetAll().Select(c =>
            new CityDTO {
               Id =c.id,
                Name =c.name,
                Fk_countryId = c.fk_countryId
            });
        }

        [Route("regiones/getAll")]
        public IEnumerable<RegionDTO> GetRegions()
        {
            return uow.RegionManager.GetAll().Select(c =>
           new RegionDTO
           {
               Id = c.id,
               Name = c.name,
               Fk_cityId = c.fk_cityId
           });
        }


        // GET: api/Location/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Location
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Location/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Location/5
        public void Delete(int id)
        {
        }
    }
}
