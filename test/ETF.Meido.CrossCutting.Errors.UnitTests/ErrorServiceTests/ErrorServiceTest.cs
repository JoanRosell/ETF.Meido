using ETF.Meido.CrossCutting.Errors.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ETF.Meido.CrossCutting.Errors.UnitTests.ErrorServiceTests
{
    public class ErrorServiceTest : IClassFixture<ErrorServiceTestFixture>
    {
        ErrorServiceTestFixture _fixture;

        public ErrorServiceTest(ErrorServiceTestFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Ctor_Works()
        {
            var sut = new ErrorService(_fixture.GetConfiguredErrors());
            Assert.NotNull(sut);
        }

        [Fact]
        public void GetError_ReturnsExpectedError()
        {
            var sut = new ErrorService(_fixture.GetConfiguredErrors());
            var returnedError = sut.GetError(ErrorServiceTestFixture.RequestedErrorType);

            Assert.NotNull(returnedError);
            Assert.Equal(ErrorServiceTestFixture.ExpectedError, returnedError);
        }
    }
}
