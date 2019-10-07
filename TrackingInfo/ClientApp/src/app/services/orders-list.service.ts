import { Injectable } from '@angular/core';
import { HttpHeaders, HttpClient } from "@angular/common/http";

import { Observable } from "rxjs/Observable";
import { Order } from '../models/order/orderModel';

@Injectable({
  providedIn: 'root'
})
export class OrdersListService {

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
}
