using SportLucky.Service.Domain.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SportLucky.Service.Test
{
    [TestClass()]
    public class BaseControllerTest
    {
        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，该上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
    }
}
