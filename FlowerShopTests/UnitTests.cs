using NUnit.Framework;
using NSubstitute;
using FlowerShop;

namespace Tests
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
            //arrange 
            var dao = Substitute.For<IOrderDAO>();
            var cli = Substitute.For<IClient>();
            var ord = new Order(dao, cli);

            //act 
            ord.Deliver();

            //asserts

            dao.Received().SetDelivered(ord); 

        
            Assert.Pass();
        }
    }
}