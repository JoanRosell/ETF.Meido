using ETF.Meido.CrossCutting.Errors.Contracts;
using Microsoft.Extensions.Options;
using System.Collections.Generic;

namespace ETF.Meido.CrossCutting.Errors.Implementation
{
    public class ErrorService : IErrorService
    {
        private readonly Dictionary<ErrorType, Error> _errors;

        public ErrorService(IOptions<Dictionary<ErrorType, Error>> configuredErrors)
        {
            _errors = configuredErrors.Value;
        }

        public Error GetError(ErrorType errorType) => _errors[errorType];
    }
}
