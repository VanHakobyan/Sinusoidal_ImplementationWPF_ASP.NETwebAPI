using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GraphPlot.Models;
namespace GraphPlot.Controllers
{
    public class PlotController : ApiController
    {

        private GraphsCreator CreateGraph;
        // GET: api/Plot
        public IHttpActionResult Get()
        {
            CreateGraph = new GraphsCreator();
            List<Point> XYList = new List<Point>();
            XYList = CreateGraph.GetXY();
            return Ok(XYList);
        }

        //public IHttpActionResult Post([FromUri]string function, [FromBody] string param)
        //{
           
        //}

    }   
}
