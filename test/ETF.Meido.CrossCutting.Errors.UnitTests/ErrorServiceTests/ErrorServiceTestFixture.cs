using ETF.Meido.CrossCutting.Errors.Contracts;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETF.Meido.CrossCutting.Errors.UnitTests.ErrorServiceTests
{
    public class ErrorServiceTestFixture
    {
        public static ErrorType RequestedErrorType { get; set; } = ErrorType.GenericError;
        public static Error ExpectedError { get; set; } = new Error("T00", "Sample error message");

        private readonly Mock<IOptions<Dictionary<ErrorType, Error>>> _fakeConfiguredErrors;
        private static readonly Dictionary<ErrorType, Error> _fakeErrors = new()
        {
            {
                RequestedErrorType,
                ExpectedError
            }
        };

        public ErrorServiceTestFixture()
        {
            _fakeConfiguredErrors = new Mock<IOptions<Dictionary<ErrorType, Error>>>();
        }

        public IOptions<Dictionary<ErrorType, Error>> GetConfiguredErrors()
        {
            _fakeConfiguredErrors.Setup(mock => mock.Value)
                .Returns(_fakeErrors);

            return _fakeConfiguredErrors.Object;
        }
    }
}
