using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrackingInfo.Models
{
    public enum Status
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
        public Status Status { get; set; }
        public DateTime Date { get; set; }

        public override bool Equals(object obj)
        {
            var step = obj as TrackingStep;

            if (step == null)
            {
                return false;
            }

            return this.Status == step.Status && DateTime.Compare(this.Date, step.Date) == 0;
        }
    }


}
