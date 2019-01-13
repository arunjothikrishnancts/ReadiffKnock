using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReadifyKnock.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Hosting;

namespace Readiffy.Tests.Controllers
{
    [TestClass]
    public class TokenControllerTest
    {
        [TestMethod]
        public void Test_GetToken()
        {
            TokenController tokenController = new TokenController();
            tokenController.Request = new HttpRequestMessage();
            tokenController.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey,
                                              new HttpConfiguration());
            Assert.IsNotNull(tokenController.Get());
        }
    }
}
