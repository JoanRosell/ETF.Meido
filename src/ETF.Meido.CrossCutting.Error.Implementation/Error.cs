using System;

namespace ETF.Meido.CrossCutting.Errors.Implementation
{
    public class Error
    {
        public string Code { get; set; } = "";
        public string Message { get; set; } = "";

        public Error(string code, string message)
        {
            Code = code;
            Message = message;
        }

        public override bool Equals(object obj)
        {
            return obj is Error error &&
                   Code == error.Code &&
                   Message == error.Message;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Code, Message);
        }
    }
}
