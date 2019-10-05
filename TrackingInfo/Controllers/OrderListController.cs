using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrackingInfo.Models;
using Newtonsoft.Json;
using TrackingInfo.Services;

namespace TrackingInfo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderListController : ControllerBase
    {
        private readonly IFirebaseService _firebaseService;

        public OrderListController(IFirebaseService firebaseService)
        {
            _firebaseService = firebaseService;
        }

        [HttpGet("[action]")]
        public ActionResult<List<Order>> GetUserOrders(int userId)
        {
            try
            {
                var firebaseJson = _firebaseService.GetUserOrder(userId);
                var orders = ParseOrdersList(firebaseJson);

                return orders;
            }
            catch (Exception)
            {
                return StatusCode(500, "Error getting order list");
            }
            
        }

        public List<Order> ParseOrdersList(string jsonData)
        {
            var orders = JsonConvert.DeserializeObject<List<Order>>(jsonData);

            return orders;
        }
    }
}