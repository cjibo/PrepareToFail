using System.Collections.Generic;
using System.Web.Http;

namespace PhotoHuntServices.Controllers
{
    public class HuntController : ApiController
    {
        // GET api/hunt
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/hunt/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/hunt
        public void Post([FromBody]string value)
        {
        }

        // PUT api/hunt/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/hunt/5
        public void Delete(int id)
        {
        }
    }
}
