﻿namespace TrackingInfo.Services
{
    public interface IFirebaseService
    {
        string GetUserOrder(int userId);
        string GetOrderDetails(int orderId);
    }
}
