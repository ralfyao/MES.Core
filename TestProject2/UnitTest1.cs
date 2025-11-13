using MES.Core;
using MES.Core.Repository.Impl;
using MES.MiddleWare;

namespace TestProject2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string connStr = Constant.CONNECTION_STRING;
            AuthenticateRepository repository = new AuthenticateRepository();
            var list = repository.GetList(null);
            Assert.NotZero(list.Count());
        }

        [Test]
        public void testGetMenu()
        {
            AuthenticateMenu auMenu = new AuthenticateMenu();
            Assert.NotZero(auMenu.GetMenuByAccount("admin").Count());
        }
        [Test]
        public void testGetAll()
        {

        }
    }
}