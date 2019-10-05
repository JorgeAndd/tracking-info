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
            var json = client.GetStringAsync(baseUrl + "/orders").Result;

            return json;
        }
    }
}
