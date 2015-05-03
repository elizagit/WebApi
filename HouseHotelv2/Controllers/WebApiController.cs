using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HouseHotelv2.Infrastructure;

namespace HouseHotelv2.Controllers
{
    public class WebApiController : ApiController
    {
        private happyhousesv4Entities db = new happyhousesv4Entities();
        // GET api/<controller>
        public IEnumerable<Property> GetProperties()
        {
            return db.Properties;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}