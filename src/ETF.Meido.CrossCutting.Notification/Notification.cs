using ETF.Meido.CrossCutting.Errors.Contracts;
using System.Collections.Generic;

namespace ETF.Meido.CrossCutting.Notifications
{
    public class Notification
    {
        public IList<Error> Errors { get; private set; } = new List<Error>();
        public bool HasErrors { get => Errors.Count > 0; }

        public void AddError(string code, string message)
        {
            Errors.Add(new Error(code, message));
        }

        public void AddErrors(IEnumerable<Error> errors)
        {
            foreach (Error error in errors)
            {
                Errors.Add(error);
            }
        }
    }
}
