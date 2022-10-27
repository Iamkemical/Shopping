using Shopping;
using System;
using System.Collections.Generic;
using Xunit;

namespace ShoppingUnitTest
{
    public class UnitTest
    {
        [Fact]
        public void TestCase1()
        {
            //Arrange
            Offers offer = new Offers();
            List<Code> items = new List<Code>();
            items.Add(Code.A); items.Add(Code.B); items.Add(Code.C); items.Add(Code.D); items.Add(Code.E);

            //Act
            var totalPrice = offer.Discount(items);

            //Assert
            Assert.True(totalPrice is 9.65);
        }

        [Fact]
        public void TestCase2()
        {
            //Arrange
            Offers offer = new Offers();
            List<Code> items = new List<Code>();
            items.Add(Code.A); items.Add(Code.B); items.Add(Code.B); items.Add(Code.C); items.Add(Code.C);

            //Act
            var totalPrice = offer.Discount(items);

            //Assert
            Assert.True(totalPrice is 6.25);
        }

        [Fact]
        public void TestCase3()
        {
            //Arrange
            Offers offer = new Offers();
            List<Code> items = new List<Code>();
            items.Add(Code.B); items.Add(Code.D); items.Add(Code.D); items.Add(Code.B); items.Add(Code.B); items.Add(Code.E); items.Add(Code.E);

            //Act
            var totalPrice = offer.Discount(items);

            //Assert
            Assert.True(totalPrice is 14.30);
        }

        [Fact]
        public void TestCase4()
        {
            //Arrange
            Offers offer = new Offers();
            List<Code> items = new List<Code>();
            items.Add(Code.D); items.Add(Code.A); items.Add(Code.B); items.Add(Code.B); items.Add(Code.D); items.Add(Code.D);

            //Act
            var totalPrice = offer.Discount(items);

            //Assert
            Assert.True(totalPrice is 12.50);
        }

        [Fact]
        public void TestCase5()
        {
            //Arrange
            Offers offer = new Offers();
            List<Code> items = new List<Code>();
            items.Add(Code.D); items.Add(Code.C); items.Add(Code.D); items.Add(Code.E); items.Add(Code.E); items.Add(Code.E); items.Add(Code.C); items.Add(Code.C); items.Add(Code.D);
            items.Add(Code.D);

            //Act
            var totalPrice = offer.Discount(items);

            //Assert
            Assert.True(totalPrice is 13.77);
        }
    }
}
