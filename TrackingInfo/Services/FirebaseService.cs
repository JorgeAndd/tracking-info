using System.Net.Http;

namespace TrackingInfo.Services
{
    public class FirebaseService : IFirebaseService
    {
        private static readonly HttpClient client = new HttpClient();
        private static readonly string baseUrl = "https://tracking-info-e774a.firebaseio.com/";

        public string GetUserOrder(int userId)
        {
            // TODO: implement filter to get only user orders
            var json = client.GetStringAsync(baseUrl + "/orders.json").Result;

            return json;
        }

        public string GetOrderDetails(int orderId)
        {
            var json = client.GetStringAsync(baseUrl + "/order-details/" + orderId + ".json").Result;

            return json;
        }

    }
}
