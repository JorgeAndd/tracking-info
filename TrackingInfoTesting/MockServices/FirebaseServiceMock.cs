using TrackingInfo.Services;

namespace TrackingInfoTesting.MockServices
{
    class FirebaseServiceMock : IFirebaseService
    {
        private string ordersJson = "[{\"Id\":1,\"UserId\":100}]";
        private string orderDetailsJson = 
            "\"Id\": 1, " +
            "\"TrackingNumber\": " +
            "\"LB001X001\", " +
            "\"TrackingSteps\": " +
                "[{\"Date\": \"2009-10-02T16:00:00Z\"," +
                    "\"Step\": 1},{\"Date\": \"2009-10-02T16:30:00Z\"," +
                    "\"Step\": 2},{\"Date\": \"2009-10-03T08:00:00Z\"," +
                    "\"Step\": 3}]}";

        public string GetUserOrder(int userId)
        {
            return ordersJson;
        }

        public string GetOrderDetails(int orderId)
        {
            return orderDetailsJson;
        }
    }
}
