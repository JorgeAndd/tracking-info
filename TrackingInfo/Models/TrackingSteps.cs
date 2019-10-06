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

        public override bool Equals(object obj)
        {
            var step = obj as TrackingStep;

            if (step == null)
            {
                return false;
            }

            return this.Step == step.Step && DateTime.Compare(this.Date, step.Date) == 0;
        }
    }


}
