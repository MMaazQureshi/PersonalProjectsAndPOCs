using ObserverDP.Events;
using ObserverDP.PubSubLibrary.PubSub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ObserverDP.PubSubLibrary
{
    public  class Page
    {
        Hub hub = Hub.Default;
        static int count = 1;

        public Page()
        {
            hub.Subscribe<FeatureTransaction>(this, product =>
            {
                Console.WriteLine("in consumer received" +JsonSerializer.Serialize(product));
                Thread.Sleep(3000);
                // highly interesting things
                Console.WriteLine($"processing complete.. {count++}");

            });
        }
    }

    public class OtherPage
    {
        static int count = 1;
        public void ProductPurchased()
        {
            Console.WriteLine($"Published.. {count}");
            Task.Run(() => { Hub hub = Hub.Default; hub.Publish(new  { Maz="ss"}); });
            Console.WriteLine($"Publishe complete.. {count++}");

        }
    }
}
