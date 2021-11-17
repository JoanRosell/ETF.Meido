namespace ETF.Meido.CrossCutting.Errors.Implementation
{
    public struct Error
    {
        public string Code { get; set; }
        public string Message { get; set; }

        public Error(string code, string message)
        {
            Code = code;
            Message = message;
        }
    }
}
