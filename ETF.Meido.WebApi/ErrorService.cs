using ETF.Meido.CrossCutting.Errors.Contracts;
using ETF.Meido.CrossCutting.Errors.Implementation;
using Microsoft.Extensions.Options;
using System.Collections.Generic;

namespace ETF.Meido.WebApi
{
    public class ErrorService
    {
        Dictionary<ErrorType, Error> _errors;

        public ErrorService(IOptions<Dictionary<ErrorType, Error>> configuredErrors)
        {
            _errors = configuredErrors.Value;
        }

        public Error GetError(ErrorType errorType) => _errors[errorType];
    }
}
