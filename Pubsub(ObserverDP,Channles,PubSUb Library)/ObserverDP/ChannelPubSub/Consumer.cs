using ObserverDP.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ObserverDP.EventPubSub
{
    internal static class Consumer
    {
        public static async Task Consume(Channel<FeatureTransaction> channel, string cm = null)
        {
            while (true)
            {
                FeatureTransaction message = null;
                message = await channel.Reader.ReadAsync();
               
                Console.WriteLine(cm ?? "From consumer");
                Console.WriteLine(JsonSerializer.Serialize(message));
            }

        }
    }
}
