using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ReadifyKnock.Controllers
{
    
    public class TriangleTypeController : ApiController
    {
        public enum TriangleType
        {
            Scalene = 1, // no two sides are the same length
            Isosceles = 2, // two sides are the same length and one differs
            Equilateral = 3, // all sides are the same length
            Error = 4 // inputs can't produce a triangle
        }

        public HttpResponseMessage Get(int a, int b, int c)
        {
            return getTriangleType(a, b, c);
        }
        private HttpResponseMessage getTriangleType(int a, int b, int c)
        {
            int[] values = new int[3] { a, b, c };
            if (a <= 0 || b <= 0 || c <= 0) return this.Request.CreateResponse(HttpStatusCode.BadRequest, TriangleType.Error.ToString());
            else if (values.Distinct().Count() == 1) return this.Request.CreateResponse(HttpStatusCode.OK,TriangleType.Equilateral.ToString());
            else if (values.Distinct().Count() == 2) return this.Request.CreateResponse(HttpStatusCode.OK,TriangleType.Isosceles.ToString());
            else if (values.Distinct().Count() == 3) return this.Request.CreateResponse(HttpStatusCode.OK,TriangleType.Scalene.ToString());
            else
            {
                return this.Request.CreateResponse(HttpStatusCode.BadRequest, TriangleType.Error.ToString());
            }
        }
    }
   
}
