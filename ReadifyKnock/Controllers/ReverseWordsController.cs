using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ReadifyKnock.Controllers
{
    public class ReverseWordsController : ApiController
    {
        public HttpResponseMessage Get(String sentence)
        {
            return getReverseWord(sentence);
        }

        private HttpResponseMessage getReverseWord(string word)
        {
            if (String.IsNullOrEmpty(word)) return this.Request.CreateResponse(HttpStatusCode.BadRequest);
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            return this.Request.CreateResponse(HttpStatusCode.OK,  new string(charArray));
        }
    }
}
