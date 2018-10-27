using Dapper.Extension;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod]
        public void TestMethod1()
        {

            ServiceContainer.Builder(c=>
            {
                c.Register<Service>();
            });
            var service = ServiceContainer.Resolve<Service>();
            service.test();

        }
    }
}
