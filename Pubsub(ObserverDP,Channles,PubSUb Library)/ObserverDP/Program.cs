// See https://aka.ms/new-console-template for more information

//Observer Pattern

//using ObserverDP.Observer;
//Dynamic Event pub sub
using ObserverDP.EventPubSub;
using ObserverDP.Feature;
using ObserverDP.ProcessFeature;
using ObserverDP.Events;
using ObserverDP.PubSubLibrary;
//ObserverDemo.Run(); 



//event based pub subs
// activating processors so they can process event when it is published
BookAppointementSchedule.RegisterObservers();
BookAppointementSchedule.Booked();


////Channels based pub sub
var channel = ChannelProvder.GetFeatureTransactionChannel();
Consumer.Consume(channel);
//Consumer.Consume(channel, "consumer 2");
await Producer.Produce(channel, new FeatureTransaction() { Id = 5, Used = 2.33m, CreatedOn = DateTime.Now, CreatedBy = "Maaz" });

//pubsub library

Page p = new Page();
OtherPage op = new OtherPage();
op.ProductPurchased();
while (true)
{
    op.ProductPurchased();
    var input = Console.ReadKey();
    //await Producer.Produce(channel, new FeatureTransaction() { Id = 5, Used = 2.33m, CreatedOn = DateTime.Now, CreatedBy = "Maaz" });

    if (input.Key == ConsoleKey.Escape)
    {
        break;
    }

}


//https://github.com/upta/pubsub











