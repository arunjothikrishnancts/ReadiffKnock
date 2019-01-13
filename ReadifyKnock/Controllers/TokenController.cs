using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ReadifyKnock.Controllers
{
    public class TokenController : ApiController
    {
        public HttpResponseMessage Get()
        {
            return getToken();
        }

        private HttpResponseMessage getToken()
        {
            return this.Request.CreateResponse(HttpStatusCode.OK, System.Guid.NewGuid().ToString());
        }
    }
}
