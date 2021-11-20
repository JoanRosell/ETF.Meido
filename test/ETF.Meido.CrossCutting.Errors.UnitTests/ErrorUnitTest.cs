using ETF.Meido.CrossCutting.Errors.Implementation;
using System;
using Xunit;

namespace ETF.Meido.CrossCutting.Errors.UnitTests
{
    public class ErrorUnitTest
    {
        [Fact]
        public void ConstructorTest()
        {
            Error error = new("Foo", "Bar");
            Assert.NotNull(error.Code);
            Assert.Equal("Foo", error.Code);

            Assert.NotNull(error.Message);
            Assert.Equal("Bar", error.Message); 
        }

        [Fact]
        public void EqualsTest()
        {
            Error error0 = new("Foo", "Bar");
            Error error1 = new("Foo", "Bar");
            Assert.Equal(error0, error1);
        }

        [Fact]
        public void GetHashCodeTest()
        {
            Error error0 = new("Foo", "Bar");
            Error error1 = new("Foo", "Bar");
            Assert.Equal(error0.GetHashCode(), error1.GetHashCode());
        }
    }
}
