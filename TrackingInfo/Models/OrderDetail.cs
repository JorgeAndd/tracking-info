using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrackingInfo.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public string TrackingNumber { get; set; }
        public List<TrackingStep> TrackingSteps { get; set; }
    }
}
