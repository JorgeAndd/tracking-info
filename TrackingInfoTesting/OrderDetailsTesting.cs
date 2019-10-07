using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TrackingInfo.Controllers;
using TrackingInfo.Models;
using TrackingInfo.Services;
using TrackingInfoTesting.MockServices;
using Xunit;

namespace TrackingInfoTesting
{
    public class OrderDetailsTesting
    {
        private IFirebaseService _firebaseService;

        public OrderDetailsTesting()
        {
            _firebaseService = new FirebaseServiceMock();
        }

        [Fact]
        public void ParseOrderDetails_Full()
        {
            var controller = new OrderDetailsController(_firebaseService);

            var expectedList = new OrderDetail()
            {
                Id = 1,
                TrackingNumber = "LB000x000",
                TrackingSteps = new List<TrackingStep>()
                {
                    new TrackingStep() { Date = new DateTime(2019, 10, 01, 08, 00, 00), Status = Status.Bought },
                    new TrackingStep() { Date = new DateTime(2019, 10, 01, 08, 30, 00), Status = Status.Paid },
                    new TrackingStep() { Date = new DateTime(2019, 10, 01, 16, 00, 00), Status = Status.Sent },
                    new TrackingStep() { Date = new DateTime(2019, 10, 01, 16, 00, 00), Status = Status.InTransit },
                    new TrackingStep() { Date = new DateTime(2019, 10, 06, 10, 00, 00), Status = Status.Delivered }
                }
            };

            var json = JsonConvert.SerializeObject(expectedList);

            var list = controller.ParseOrderDetails(json);
            Assert.Equal(expectedList, list);
        }
    }
}
