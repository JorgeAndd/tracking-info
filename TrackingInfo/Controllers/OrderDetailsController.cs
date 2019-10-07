using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TrackingInfo.Models;
using TrackingInfo.Services;

namespace TrackingInfo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        private readonly IFirebaseService _firebaseService;

        public OrderDetailsController(IFirebaseService firebaseService)
        {
            _firebaseService = firebaseService;
        }
        public OrderDetail ParseOrderDetails(string jsonData)
        {
            var details = JsonConvert.DeserializeObject<OrderDetail>(jsonData);

            return details;
        }
    }
}