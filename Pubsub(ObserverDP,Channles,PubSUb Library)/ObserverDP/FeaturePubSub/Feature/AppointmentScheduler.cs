using ObserverDP.Events;
using ObserverDP.ProcessFeature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDP.Feature;
public class BookAppointementSchedule
{
    // bookAppoint schedule logic..........
    //........
    public static void RegisterObservers()
    {
        var eventProcessors = typeof(IEventProcessor);
        var classes = eventProcessors.Assembly.ExportedTypes
            .Where(x => eventProcessors.IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
            .Select(x =>
            {
                var processor = (IEventProcessor)Activator.CreateInstance(x);
                processor.Process();
                return processor;
            }
            ).ToList();
    }
    public static void Booked()
    {

        FeatureTransactionEvent.Publish(new object(), new FeatureTransaction() { Id = 5, Used = 2.33m, CreatedBy = "Maaz" });

        Console.WriteLine("Event Published");
    }
}


