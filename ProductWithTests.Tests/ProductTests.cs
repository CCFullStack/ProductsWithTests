using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductWithTests.Models;
using System.Linq;

namespace ProductWithTests.Tests {

    [TestClass]
    public class ProductTests {

        [TestMethod]
        public void TestProductNameRequired() {

            // Arrange
            var product = new Product {
                Name = "",
                Price = 3.33m
            };

            // Act
            var results = TestHelper.Validate(product);

            // Assert
            Assert.IsTrue(results.Any(p => p.ErrorMessage == "Name is required."));
        }

        [TestMethod]
        public void TestPriceNot17() {

        }
    }
}
