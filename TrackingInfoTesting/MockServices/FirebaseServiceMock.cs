using TrackingInfo.Services;

namespace TrackingInfoTesting.MockServices
{
    class FirebaseServiceMock : IFirebaseService
    {
        private string ordersJson = "[{\"Id\":1,\"UserId\":100}]";

        public string GetUserOrder(int userId)
        {
            return ordersJson;
        }
    }
}
