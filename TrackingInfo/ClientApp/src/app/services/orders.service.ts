import { Injectable } from '@angular/core';
import { HttpHeaders, HttpClient, HttpParams } from "@angular/common/http";

import { Observable } from "rxjs/Observable";
import { Order } from '../models/order/orderModel';
import { OrderDetail } from '../models/order/orderDetailModel';

@Injectable({
  providedIn: 'root'
})
export class OrdersService {

    constructor(private http: HttpClient) { }

    getUserOrders(userId: number): Observable<Order[]> {
        let options = {
            headers: new HttpHeaders({ 'Content-Type': 'application/json' }),
            params: {
                'userId': userId
            }
        }

        return this.http.get<Order[]>('api/OrderList/GetUserOrders');
    }

    getOrderDetails(orderId: number): Observable<OrderDetail> {
        const params = new HttpParams().set('orderId', orderId.toString());

        return this.http.get<OrderDetail>('api/OrderDetails/GetOrderDetails', { params });
    }
}
