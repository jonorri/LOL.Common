using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LOL.Common.API;

namespace LOL.Common.Tests
{
    [TestClass]
    public class SummonersApiTests
    {
        [TestMethod]
        public void ReturnsContent()
        {
            SummonersApi api = new SummonersApi("", "eune");
            Assert.IsNotNull(api.Get());
        }
    }
}
