using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrackingInfo.Models;
using Newtonsoft.Json;

namespace TrackingInfo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductListController : ControllerBase
    {
        public List<Order> ParseOrdersList(string jsonData)
        {
            var orders = JsonConvert.DeserializeObject<List<Order>>(jsonData);

            return orders;
        }
    }
}