using ObserverDP.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ObserverDP.ProcessFeature
{
    public  class ProcessAppointmentScheduling : IEventProcessor
    {
        public void Process()
        {
            FeatureTransactionEvent.TransactionComplete += (o, e) =>
            {
                Thread.Sleep(5000);
                Console.WriteLine(JsonSerializer.Serialize(e));
            };
        }
    }
}
