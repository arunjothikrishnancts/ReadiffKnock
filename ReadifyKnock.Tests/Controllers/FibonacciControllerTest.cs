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
    public class FibonacciControllerTest
    {
        [TestMethod]
        public void Test_FibonacciSeries()
        {
            FibonacciController fibonacciController = new FibonacciController();
            fibonacciController.Request = new HttpRequestMessage();
            fibonacciController.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey,
                                              new HttpConfiguration());

            Assert.IsTrue(fibonacciController.Get(0).Content.ReadAsStringAsync().Result.Contains("0"));
            Assert.IsTrue(fibonacciController.Get(1).Content.ReadAsStringAsync().Result.Contains("1"));
            Assert.IsFalse(fibonacciController.Get(6).Content.ReadAsStringAsync().Result.Contains("5"));
            Assert.IsTrue(fibonacciController.Get(5).Content.ReadAsStringAsync().Result.Contains("5"));
        }
    }
}
