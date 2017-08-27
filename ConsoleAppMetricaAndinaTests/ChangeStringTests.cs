using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppMetricaAndina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMetricaAndina.Tests
{
    [TestClass]
    public class ChangeStringTests
    {
        [TestMethod]
        public void buildTest()
        {
            var classchangeString = new ChangeString();

            Assert.AreEqual("a", classchangeString.build("z"));
            Assert.AreEqual("123 bcde*3", classchangeString.build("123 abcd*3"));
            Assert.AreEqual("**Dbtb 52", classchangeString.build("**Casa 52"));
        }
    }
}