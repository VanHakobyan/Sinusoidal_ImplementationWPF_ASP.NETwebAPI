using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GraphPlot.Models
{
    public class GraphsCreator
    {
        private List<Point> xyList;


        public List<Point> GetXY()
        {
            xyList = new List<Point>();

            for (int i = 0; i < 70; i++)
            {
                var x = i / 5.0;
                var y = Math.Sin(x);
                xyList.Add(new Point() { X = x, Y = y });
            }


            return xyList;
        }



    }
}