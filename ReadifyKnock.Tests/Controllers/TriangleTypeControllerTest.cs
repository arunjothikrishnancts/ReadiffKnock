using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Http.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Readiffy;
using ReadifyKnock.Controllers;

namespace Readiffy.Tests.Controllers
{
    [TestClass]
    public class TriangleTypeControllerTest
    {
        [TestMethod]
        public void Test_GetTriangleType()
        {
            TriangleTypeController triangleTypeController = new TriangleTypeController();
            triangleTypeController.Request = new HttpRequestMessage();
            triangleTypeController.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey,
                                              new HttpConfiguration());

            Assert.IsTrue(triangleTypeController.Get(4, 4, 4).Content.ReadAsStringAsync().Result.Contains("Equilateral"),
                           "GetTriangleType(4, 4, 4) did not return Equilateral");

            Assert.IsTrue(triangleTypeController.Get(4, 4, 3).Content.ReadAsStringAsync().Result.Contains("Isosceles"),
                            "GetTriangleType(4, 4, 3) did not return Isosceles");

            Assert.IsTrue(triangleTypeController.Get(4, 3, 2).Content.ReadAsStringAsync().Result.Contains("Scalene"),
                            "GetTriangleType(4, 3, 2) did not return Scalene");

            Assert.IsTrue(triangleTypeController.Get(-4, 4, 4).Content.ReadAsStringAsync().Result.Contains("Error"),
                            "GetTriangleType(-4, 4, 4) did not return Error");

            Assert.IsTrue(triangleTypeController.Get(4, -4, 4).Content.ReadAsStringAsync().Result.Contains("Error"),
                            "GetTriangleType(4, -4, 4) did not return Error");

            Assert.IsTrue(triangleTypeController.Get(4, 4, -4).Content.ReadAsStringAsync().Result.Contains("Error"),
                            "GetTriangleType(4, 4, -4) did not return Error");
        }
        

    }
}
