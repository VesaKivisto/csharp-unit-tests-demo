using NUnit.Framework;
using System.Collections.Generic;

namespace UnitTests
{
    [TestFixture]
    public class TestClass
    {
        List<string> items;
        Basket basket;
        [SetUp]
        public void SetUp()
        {
            items = new List<string>();
            items.Add("omena");
            items.Add("banaani");
            basket = new Basket("Jari", items, 25.0);
        }

        [TearDown]
        public void TearDown()
        {
            items = null;
            basket = null;
        }

        [Test]
        public void IsCustomerString()
        {
            Assert.That(basket.ReturnCustomer(), Is.InstanceOf(typeof(string)));
        }

        [Test]
        public void IsPriceDouble()
        {
            Assert.That(basket.ReturnPrice(), Is.InstanceOf(typeof(double)));
        }

        [Test]
        public void IsContentsList()
        {
            Assert.That(basket.ReturnContents(), Is.InstanceOf(typeof(List<string>)));
        }

        [Test]
        public void AddToContents()
        {
            basket.AddProduct("kala", 5.0);
            Assert.That(basket.ReturnContents(), Contains.Item("kala"));
        }

        [Test]
        public void DeleteFromList()
        {
            basket.DeleteProduct("kala", 5.0);
            Assert.That(basket.ReturnContents(), !Contains.Item("kala"));
        }

        [Test]
        public void CalculateDiscount()
        {
            Assert.That(basket.CalculateDiscountPrice(10), Is.EqualTo(22.5));
        }

        [Test]
        public void CalculateAveragePrice()
        {
            Assert.That(basket.CalculateAverageItemPrice(), Is.EqualTo(12.5));
        }
    }
}
