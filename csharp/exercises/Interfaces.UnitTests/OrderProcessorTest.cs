using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Interfaces.UnitTests
{
    [TestClass]
    public class OrderProcessorTest
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order() { Shipment = new Shipment() };
            orderProcessor.Process(order);

        }

        [TestMethod]
        public void Process_OrderIsNotShipped_ShouldSetPropertyOfTheOrder()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order();
            orderProcessor.Process(order);
            Assert.IsTrue(order.IsShipped);
            Assert.AreEqual(1f, order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
        }
    }
    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1f;
        }
    }
}
