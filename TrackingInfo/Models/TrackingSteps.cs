using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrackingInfo.Models
{
    public enum Step
    {
        Bought,
        Paid,
        Sent,
        InTransit,
        Delivered,
        Delayed
    }

    public class TrackingStep
    {
        public Step Step { get; set; }
        public DateTime Date { get; set; }
    }
}
