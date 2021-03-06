using Myxomatosis.Connection.Message;
using System;

namespace Myxomatosis.Windsor.Attributes.SingleMessage
{
    public class SubscriptionConverter : IConverter<IStaticSubscriptionConfig, ISubscriptionConfig>
    {
        #region IConverter<IStaticSubscriptionConfig,ISubscriptionConfig> Members

        public ISubscriptionConfig Convert(IStaticSubscriptionConfig source)
        {
            return new DefaultSubscriptionConfig(source.QueueName)
            {
                CloseTimeout = TimeSpan.FromMilliseconds(source.CloseTimeout),
                OpenTimeout = TimeSpan.FromMilliseconds(source.OpenTimeout),
                SubscriptionId = source.SubscriptionId,
                Name = source.Name
            };
        }

        #endregion IConverter<IStaticSubscriptionConfig,ISubscriptionConfig> Members
    }
}