using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDP.Events
{
    public class FeatureTransactionEvent
    {
        public static event EventHandler<FeatureTransaction> TransactionComplete;
        public static void Publish(object sender, FeatureTransaction featureTransaction)
        {
            if (TransactionComplete != null)
            {
                TransactionComplete(sender, featureTransaction);
            }
            }
    }

    public class FeatureTransaction
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int FeatureId { get; set; }
        public decimal Used { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
    }
}
