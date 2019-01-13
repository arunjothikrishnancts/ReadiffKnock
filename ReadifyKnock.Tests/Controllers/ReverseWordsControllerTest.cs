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
    public class ReverseWordsControllerTest
    {
        [TestMethod]
        public void Test_Reversewords()
        {
            ReverseWordsController fibonacciController = new ReverseWordsController();
            fibonacciController.Request = new HttpRequestMessage();
            fibonacciController.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey,
                                              new HttpConfiguration());

            Assert.IsTrue(fibonacciController.Get("dotnet").Content.ReadAsStringAsync().Result.Contains("tentod"));
            Assert.IsFalse(fibonacciController.Get("java").Content.ReadAsStringAsync().Result.Contains("java"));
        }
    }
}
