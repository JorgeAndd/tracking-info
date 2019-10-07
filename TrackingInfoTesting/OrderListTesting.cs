using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TrackingInfo.Controllers;
using TrackingInfo.Models;
using TrackingInfo.Services;
using TrackingInfoTesting.MockServices;
using Xunit;

namespace TrackingInfoTesting
{
    public class OrderListTesting
    {
        private IFirebaseService _firebaseService;

        public OrderListTesting()
        {
            _firebaseService = new FirebaseServiceMock();
        }

        [Fact]
        public void GetUserOrders()
        {
            var controller = new OrderListController(_firebaseService);
            var orders = controller.GetUserOrders(1).Value;

            var expectedList = new List<Order>()
            {
                new Order() { Id = 1, UserId = 100, LastStatus = Status.InTransit }
            };

            Assert.Single(orders);
            Assert.Equal(expectedList, orders);
        }

        [Fact]
        public void ParseOrdersList_ShouldReturnOne()
        {
            var controller = new OrderListController(_firebaseService);

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
            var controller = new OrderListController(_firebaseService);

            var emptyList = new List<Order>() { };

            var json = JsonConvert.SerializeObject(emptyList);

            var list = controller.ParseOrdersList(json);
            Assert.Empty(list);
        }
    }
}
