using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GraphPlot.Controllers
{
    public class PlotController : ApiController
    {
        // GET: api/Plot
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // PUT: api/Plot/5
        public void Put(int id, [FromBody]string value)
        {
        }

    }   
}
