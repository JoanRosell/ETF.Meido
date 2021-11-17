using System;

namespace ETF.Meido.CrossCutting.DataTransferObject
{
    public class DataTransferObject
    {
        public Notification Notification { get; private set; } = new();
    }
}
