using ETF.Meido.CrossCutting.Errors.Implementation;
using System.Collections.Generic;

namespace ETF.Meido.CrossCutting.DataTransferObject
{
    public class Notification
    {
        public IList<Error> Errors { get; set; } = new List<Error>();
        public bool HasErrors { get => Errors.Count > 0; }
    }
}
