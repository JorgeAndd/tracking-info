using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TrackingInfo.Controllers;
using TrackingInfo.Models;
using Xunit;

namespace TrackingInfoTesting
{
    public class ProductListTesting
    {
        [Fact]
        public void ParseOrdersList_ShouldReturnOne()
        {
            var controller = new ProductListController();

            var expectedList = new List<Order>()
            {
                new Order() { Id = 1, UserId = 100 }
            };

            var json = JsonConvert.SerializeObject(expectedList);

            var list = controller.ParseOrdersList(json);
            Assert.Single(list);
            Assert.Equal(expectedList, list);
        }

        [Fact]
        public void ParseOrdersList_ShouldReturnEmpty()
        {
            var controller = new ProductListController();

            var emptyList = new List<Order>() { };

            var json = JsonConvert.SerializeObject(emptyList);

            var list = controller.ParseOrdersList(json);
            Assert.Empty(list);
        }
    }
}
