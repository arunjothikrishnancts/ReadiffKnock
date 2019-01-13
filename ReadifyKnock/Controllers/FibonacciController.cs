using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ReadifyKnock.Controllers
{
    public class FibonacciController : ApiController
    {
        public HttpResponseMessage Get(long n)
        {
            return getFibonacciSeries(n);
        }

        private HttpResponseMessage getFibonacciSeries(long n)
        {
            Int64 firstnumber = 0, secondnumber = 1, result = 0;
            if (n == 0) return this.Request.CreateResponse(HttpStatusCode.OK,"0");
            if (n == 1) return this.Request.CreateResponse(HttpStatusCode.OK, "1");
            for (long i=2; i<=n;i++)
            {
                result = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = result;
            }
            return this.Request.CreateResponse(HttpStatusCode.OK, result); ;
        }
    }
}
