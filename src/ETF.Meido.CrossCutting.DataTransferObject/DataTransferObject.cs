using ETF.Meido.CrossCutting.Notifications;
using System;

namespace ETF.Meido.CrossCutting.DataTransferObject
{
    public abstract class DataTransferObject
    {
        public Notification Notification { get; private set; } = new();
    }
}
