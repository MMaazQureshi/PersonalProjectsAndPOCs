using ObserverDP.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ObserverDP.EventPubSub
{
    internal static class ChannelProvder
    {
        public static Channel<FeatureTransaction> GetFeatureTransactionChannel()
        {
            var channel = Channel.CreateUnbounded<FeatureTransaction>();
            return channel;
        }
    }
}
