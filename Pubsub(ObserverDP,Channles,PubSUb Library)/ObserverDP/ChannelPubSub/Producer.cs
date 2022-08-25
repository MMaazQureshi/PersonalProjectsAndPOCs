using ObserverDP.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ObserverDP.EventPubSub
{
    internal static class Producer
    {
        public static async Task Produce(Channel<FeatureTransaction> channel, FeatureTransaction model)
        {
            var rnd = new Random();
            await channel.Writer.WriteAsync(model);
        }
    }
}
