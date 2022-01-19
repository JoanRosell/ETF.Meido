namespace ETF.Meido.CrossCutting.Errors.Contracts
{
    public interface IErrorService
    {
        public Error GetError(ErrorType errorType);
    }
}
